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

namespace FrmNuevoPasajero
{
    public partial class frm_cargarPasajero : Form
    {
        int indice;
        int total;
        string codVuelo;
        string clase;
        


        public int Indice { get => indice; }
        public int Total { get => total; }
        public string Vuelo { get => codVuelo; }
        public string Clase { get => clase; }

        public frm_cargarPasajero()
        {
            InitializeComponent();
            //facturar = new frm_emitirEticket();
        }
        public frm_cargarPasajero(string idVuelo, int cantidad, string claseSelect) : this()
        {
            codVuelo = idVuelo;
            clase = claseSelect;
            total = cantidad;
        }

        public frm_cargarPasajero(string idVuelo, int orden, int cantidad, string claseSelect) : this()
        {
            indice = orden;
            total = cantidad;
            codVuelo = idVuelo;
            clase = claseSelect;

        }

        public frm_cargarPasajero(string codVuelo)
        {
            this.codVuelo = codVuelo;
        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (chk_esMenor.Checked)
                {
                    Pasajero nuevoPasajeroMenor = Validacion.ValidarMenor(
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

                   
                }


            }
            catch (Exception ex)
            {
                lbl_errorGeneral.Visible = true;
                lbl_errorGeneral.Text = (ex.Message);
            }
        }

        private void frm_cargarPasajero_Load(object sender, EventArgs e)
        {
            if (cbo_tipoServicio.Text == "Turista")
            {
                chk_valijaBodega.Text = "Valija en Bodega hasta 21 KG";

            }
            else if (cbo_tipoServicio.Text == "Premium")
            {
                chk_valijaBodega.Text = "Valija en Bodega hasta 25 KG";
            }
       


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

                txt_apellido.Enabled = false;
                txt_apellido.Text = unCliente.Apellido;

                txt_nombre.Enabled = false;
                txt_nombre.Text = unCliente.Nombre;

                txt_pasaporte.Enabled = false;
                txt_pasaporte.Text = unCliente.Pasaporte.ToString();

                dtp_fechaNacimiento.Enabled = false;
                dtp_fechaNacimiento.Text = unCliente.FechaNacimiento.ToString();

                txt_direccion.Enabled = false;
                txt_direccion.Text = unCliente.Direccion;

                txt_telefono.Enabled = false;
                txt_telefono.Text = unCliente.Telefono.ToString();

                txt_email.Enabled = false;
                txt_email.Text = unCliente.Email;
            }
            else
            {
                lbl_esCliente.Visible = true;
                lbl_esCliente.Text = "No es Cliente";
                btn_agregarCliente.Enabled = true;
            }

        }

        private void txt_dni_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_esCliente.Text = "";
            lbl_esCliente.Visible = false;
            lbl_esCliente.Text = "";
            txt_apellido.Enabled = true;
            txt_apellido.Text = "";
            txt_nombre.Enabled = true;
            txt_nombre.Text = "";
            txt_pasaporte.Enabled = true;
            txt_pasaporte.Text = "";
            dtp_fechaNacimiento.Enabled = true;
            dtp_fechaNacimiento.Text = "";
            txt_direccion.Enabled = true;
            txt_direccion.Text = "";
            txt_telefono.Enabled = true;
            txt_telefono.Text = "";
            txt_email.Enabled = true;
            txt_email.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo_tipoServicio.Text == "Premium")
            {
                lbl_cantidad.Visible = true;
                nup_cantValijas.Visible = true;
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

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (Indice == Total)
            {
               // facturar.ShowDialog();

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
        }
    }
}