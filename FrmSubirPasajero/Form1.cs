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
        private string idVuelo;
        private Vuelo vueloSeleccionado;
        private int cantPasajero;
        Pasajero nuevoPasajero;

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
        }

        public int CantPasajero { get => cantPasajero; set => cantPasajero = value; }

        public frm_subePasajero()
        {
            InitializeComponent();

        }

        public frm_subePasajero(string idVuelo):this()
        {
            this.idVuelo = idVuelo;
            vueloSeleccionado = Vuelo.BuscarVueloPorId(idVuelo);
            Venta.listaPasajerosAuxiliar = new List<Pasajero>();
            CantPasajero = 0;
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

            }
        }

        private void rad_variosPasajeros_CheckedChanged(object sender, EventArgs e)
        {
            lbl_muestraNumero.Enabled = true;
            nup_numeroPasajeros.Enabled = true;
            lbl_muestraNumero.Visible = true;
            nup_numeroPasajeros.Visible = true;
        }

        private void rad_unPasajero_CheckedChanged(object sender, EventArgs e)
        {
            lbl_muestraNumero.Visible = false;
            nup_numeroPasajeros.Visible = false;
            lbl_muestraNumero.Enabled = false;
            nup_numeroPasajeros.Enabled = false;
            lbl_errorGeneral.Visible = true;
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
            }
            else if (chk_esMenor.Checked == false)
            {
                lbl_errorGeneral.Visible = false;
                lbl_rerponsableMenor.Visible = false;
                btn_agregarCliente.Text = "Agregar Cliente";
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
                   // Venta.listaPasajerosAuxiliar.Add(nuevoPasajero); funcionalidad de + de un cliente

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

                    // Venta.listaPasajerosAuxiliar.Add((Pasajero)nuevoPasajero);  funcionalidad de + de un cliente
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
                if (rad_unPasajero.Checked==true)
                {
                    CantPasajero = 1;
                    if (Vuelo.ConfirmarDisponibilidadVuelo(cbo_tipoServicio.Text, vueloSeleccionado.CodigoDeVuelo, CantPasajero))
                    {
                        if(chk_bolsoMano.Checked==true && chk_valijaBodega.Checked == true)
                        {
                            if(cbo_tipoServicio.Text=="Turista")
                            {
                                if (chk_bolsoMano.Checked == true)
                                {
                                    nuevoPasajero.EquipajeDeMano = true;
                                }
                                if(chk_valijaBodega.Checked==true)
                                {
                                    nuevoPasajero.ValijaTurista = true; 
                                }                                  
                                
                            }
                            else if(cbo_tipoServicio.Text=="Premium")
                            {
                                if (chk_bolsoMano.Checked == true)
                                {
                                    nuevoPasajero.EquipajeDeMano = true;
                                }
                                if (chk_valijaBodega.Checked == true)
                                {
                                    nuevoPasajero.ValijaPremium = true;
                                    nuevoPasajero.CantValijaPremium = (int)nup_cantValijas.Value;
                                }
                            }
                        }
                        frm_emitirEticket facturar = new frm_emitirEticket(nuevoPasajero, vueloSeleccionado);
                        facturar.ShowDialog();
                        Close();
                    }
                    else
                    {
                        throw new Exception ("Debe elegir cantidad de pasajeros");
                    }
                }
                else if(rad_variosPasajeros.Checked==true)
                {
                    btn_siguiente.Enabled = false;
                    lbl_errorGeneral.Text = "No esta disponible";
                    lbl_errorGeneral.Visible = true;
                   /* CantPasajero = (int)nup_numeroPasajeros.Value;
                    if (Vuelo.ConfirmarDisponibilidadVuelo(cbo_tipoServicio.Text, vueloSeleccionado.CodigoDeVuelo, CantPasajero))
                    {
                        for(int i = 1; i < nup_numeroPasajeros.Value; i++)
                        {
                            frm_subePasajero pasajerosGrupo = new frm_subePasajero();
                            pasajerosGrupo.ShowDialog();
                        }
                        
                        frm_emitirEticket facturar = new frm_emitirEticket(listaPasajerosAuxiliar, vueloSeleccionado);
                        facturar.ShowDialog();                        
                        Close();
                    }*/
                }
            }
            catch(Exception ex)
            {
                lbl_errorDispon.Text = ex.Message;
                lbl_errorDispon.Visible = true;
            }

        }
    }
}
