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

namespace FrmNuevoCliente
{
    public partial class frm_nuevoCliente : Form
    {
        public frm_nuevoCliente()
        {
            InitializeComponent();
        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                
                Venta.AgregarClienteALista(
                        Validacion.ValidarNuevoCliente(
                            txt_nombre.Text,
                            txt_apellido.Text,
                            txt_dni.Text,
                            txt_pasaporte.Text,
                            dtp_fechaNacimiento.Value.ToShortDateString(),
                            txt_direccion.Text,
                            txt_telefono.Text,
                            txt_email.Text
                            ));
                MessageBox.Show("Cliente Agregado con éxito", "", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                lbl_error.Visible = true;
                lbl_error.Text = (ex.Message);
            }


        }

        private void btn_cancelarCargaVuelo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_nuevoCliente_Load(object sender, EventArgs e)
        {

            dtp_fechaNacimiento.MinDate = DateTime.Today.AddYears(-100);
            dtp_fechaNacimiento.MaxDate = DateTime.Today.AddYears(-18);

        }
        

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void dtp_fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void lbl_mensajeDni_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void txt_pasaporte_TextChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }
    }
}
