using FrmETicket;
using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSubirPasajero
{
    public partial class frm_subePasajero : Form
    {        
        private Vuelo vueloSeleccionado;
        private int cantPasajero;
        Pasajero nuevoPasajero;
        List<Pasajero> listaPasajerosASubir;


        public frm_subePasajero(string idVuelo) 
        {
            InitializeComponent();            
            vueloSeleccionado = Vuelo.BuscarVueloPorId(idVuelo);  
            listaPasajerosASubir = new List<Pasajero>();
            CantPasajero = 0;
        }

        
        public int CantPasajero { get => cantPasajero; set => cantPasajero = value; }


        private void CambiarEnabled(bool trueOFalse)
        {
            txt_apellido.Enabled = trueOFalse;
            txt_dni.Enabled = trueOFalse;
            txt_nombre.Enabled = trueOFalse;
            txt_email.Enabled = trueOFalse;
            txt_pasaporte.Enabled = trueOFalse;
            dtp_fechaNacimiento.Enabled = trueOFalse;
            txt_direccion.Enabled = trueOFalse;
            txt_telefono.Enabled = trueOFalse;
            chk_esMenor.Enabled = trueOFalse;
        }

        private void InhabilitarBotones()
        {
            btn_siguiente.Enabled = false;
            nup_numeroPasajeros.Enabled = false;
            rad_unPasajero.Enabled = false;
            lbl_errorGeneral.Visible = false;
            cbo_tipoServicio.Enabled = false; 
            dtp_fechaNacimiento.ResetText();
        }

        private void LimpiarTodosLosTxtBox()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
        }
        
        private void VistaSegunCantidadDePasajeros(bool trueOFalse)
        {
            lbl_muestraNumero.Enabled = trueOFalse;
            nup_numeroPasajeros.Enabled = trueOFalse;
            lbl_muestraNumero.Visible = trueOFalse;
            nup_numeroPasajeros.Visible = trueOFalse;
        }
        



        private void frm_subePasajero_Load(object sender, EventArgs e)
        {
            
            if (vueloSeleccionado != null)
            {
                cbo_tipoServicio.DataSource = Enum.GetNames(typeof(ETipoServicio));
                lbl_muestraVuelo.Text = vueloSeleccionado.CodigoDeVuelo;
                lbl_muestraOrigen.Text = vueloSeleccionado.OrigenVuelo;
                lbl_muestraDestino.Text = vueloSeleccionado.DestinoVuelo;

                lbl_muestraCantBaños.Text = Vuelo.CantidadBañosPorPatente(vueloSeleccionado.PatenteAeronave).ToString();
                lbl_siNoWifi.Text = Validacion.ValidarServicio(vueloSeleccionado.TieneWifi);
                lbl_siNoRefrigerio.Text = Validacion.ValidarServicio(vueloSeleccionado.TieneServicioRefrescoBasico);
                lbl_siNoBufet.Text = Validacion.ValidarServicio(vueloSeleccionado.TieneServicioComida);

                lbl_muestraHorarioSalida.Text = vueloSeleccionado.HoraPartidaVuelo.ToString();
                lbl_muestraDuracion.Text = vueloSeleccionado.DuracionVuelo.ToString();


                lbl_muestraDispTurista.Text = $"{Vuelo.SumarPasajerosTurista(vueloSeleccionado.CodigoDeVuelo)} de " +
                $"{vueloSeleccionado.AsientosClaseTurista} lugares ocupados";

                lbl_muestraDispPremium.Text = $"{Vuelo.SumarPasajerosPremium(vueloSeleccionado.CodigoDeVuelo)} de " +
                $"{vueloSeleccionado.AsientosClasePremium} lugares ocupados";
                rad_unPasajero.Checked = true;

            }
        }

        private void rad_variosPasajeros_CheckedChanged(object sender, EventArgs e)
        {
            VistaSegunCantidadDePasajeros(true);
            cantPasajero = (int)nup_numeroPasajeros.Value;
        }

        private void rad_unPasajero_CheckedChanged(object sender, EventArgs e)
        {
            VistaSegunCantidadDePasajeros(false);
            cantPasajero = 1;

        }

        private void btn_cancelarDatos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            
            Cliente unCliente = Venta.BuscarClienteXDni(txt_dni.Text);
            if (unCliente != null)
            {                     
                nuevoPasajero = Pasajero.CargarUnPasajeroDesdeUnCliente(unCliente);
                if(nuevoPasajero != null)
                {
                    lbl_esCliente.Visible = true;
                    lbl_esCliente.Text = "Ya es Cliente";
                    txt_apellido.Text = unCliente.Apellido;
                    txt_nombre.Text = unCliente.Nombre;
                    txt_pasaporte.Text = unCliente.Pasaporte.ToString();
                    dtp_fechaNacimiento.Text = unCliente.FechaNacimiento.ToString();
                    txt_direccion.Text = unCliente.Direccion;
                    txt_telefono.Text = unCliente.Telefono.ToString();
                    txt_email.Text = unCliente.Email;

                    CambiarEnabled(false);

                    btn_siguiente.Enabled = true;
                }                              
               
            }
            else
            {
                lbl_esCliente.Visible = true;
                lbl_esCliente.Text = "No es Cliente";
                btn_agregarCliente.Enabled = true;
            }
        }

        private void chk_esMenor_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_esMenor.Checked == true)
            {
                lbl_errorGeneral.Visible = true;
                lbl_errorGeneral.Text = "El menor debe viajar con la autorizacion correspondiente, no se añadira a Clientes";
                lbl_rerponsableMenor.Visible = true;
                btn_agregarCliente.Text = "Validar Datos";
                lbl_pasajeroCliente.Visible = false;
            }
            else if (chk_esMenor.Checked == false)
            {
                lbl_errorGeneral.Visible = false;
                lbl_rerponsableMenor.Visible = false;
                btn_agregarCliente.Text = "Agregar Cliente";
                lbl_pasajeroCliente.Visible = true;
            }
        }

        private void cbo_tipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tipoServicio.Text == "Turista")
            {
                chk_valijaBodega.Text = "Valija en Bodega hasta 21 KG";
                nup_cantValijas.Visible = false;
                lbl_muestraAtencion.Visible = false;
            }
            else if (cbo_tipoServicio.Text == "Premium")
            {
                chk_valijaBodega.Text = "Valija en Bodega hasta 25 KG";
                nup_cantValijas.Visible = true;
                lbl_muestraAtencion.Visible = true;
            }
        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            lbl_errorGeneral.Text = null;
            try
            {
                if (chk_esMenor.Checked)
                {
                    nuevoPasajero = Validacion.ValidarMenor(
                                txt_nombre.Text,
                                txt_apellido.Text,
                                txt_dni.Text,
                                txt_pasaporte.Text,
                                dtp_fechaNacimiento.Value.ToShortDateString(),
                                txt_direccion.Text,
                                txt_telefono.Text,
                                txt_email.Text
                                );
                    MessageBox.Show("Datos Validos", "", MessageBoxButtons.OK);
                   

                }
                else
                {
                    Cliente clienteValidado = Validacion.ValidarNuevoCliente(
                         txt_nombre.Text,
                         txt_apellido.Text,
                         txt_dni.Text,
                         txt_pasaporte.Text,
                         dtp_fechaNacimiento.Value.ToShortDateString(),
                         txt_direccion.Text,
                         txt_telefono.Text,
                         txt_email.Text
                         );
                    Venta.AgregarClienteALista(clienteValidado);
                    MessageBox.Show("Cliente Agregado con éxito", "", MessageBoxButtons.OK);

                    nuevoPasajero = new Pasajero(txt_nombre.Text,
                         txt_apellido.Text,
                         Convert.ToInt32(txt_dni.Text),
                         Convert.ToInt32(txt_pasaporte.Text),
                         dtp_fechaNacimiento.Value.ToShortDateString(),
                         txt_direccion.Text,
                         Convert.ToInt32(txt_telefono.Text),
                         txt_email.Text);

                   
                }
                CambiarEnabled(false);

                btn_siguiente.Enabled = true;
            }

            catch (Exception ex)
            {
                lbl_errorGeneral.Visible = true;
                lbl_errorGeneral.Text = (ex.Message);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {            
            try
            {              
                if(cantPasajero>0 && Pasajero.CargarValijasAlPasajero(nuevoPasajero, chk_bolsoMano.Checked, chk_valijaBodega.Checked, nup_cantValijas.Value, cbo_tipoServicio.Text)==true)
                {                    
                    if(Vuelo.VerificarPasajeroEnVentaYVuelo(nuevoPasajero.Dni, listaPasajerosASubir,vueloSeleccionado.ListaDePasajeros))
                    {   
                        if(Vuelo.ConfirmarDisponibilidadVuelo(cbo_tipoServicio.Text,vueloSeleccionado.CodigoDeVuelo,CantPasajero))
                        {
                            Pasajero.CargarClase(cbo_tipoServicio.Text,nuevoPasajero);
                            listaPasajerosASubir.Add(nuevoPasajero);

                            if (listaPasajerosASubir.Count()==cantPasajero)
                            {                            
                                frm_emitirEticket facturar = new frm_emitirEticket(listaPasajerosASubir, vueloSeleccionado);
                                facturar.ShowDialog();
                                Close();
                            }
                            lbl_muestraTotalPasajerosASubir.Text =$"Pasajero {listaPasajerosASubir.Count()+1} de {cantPasajero}";
                                                                     
                            LimpiarTodosLosTxtBox();
                            CambiarEnabled(true);
                            InhabilitarBotones();                          

                        }
                    }
                }
                else
                {
                    throw new Exception("Debe cargar cantidad de pasajeros");
                }               
              

            }
            catch(Exception ex)
            {
                lbl_errorGeneral.Text= ex.Message;
                lbl_errorGeneral.Visible = true;
            }

        }

        private void nup_numeroPasajeros_ValueChanged(object sender, EventArgs e)
        {
            cantPasajero = (int)nup_numeroPasajeros.Value;
        }
    }
}
