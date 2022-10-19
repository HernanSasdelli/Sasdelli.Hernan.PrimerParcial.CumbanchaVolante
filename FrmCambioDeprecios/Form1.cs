using LibreriaDeClases;
using System;
using System.Windows.Forms;


namespace FrmCambioDeprecios
{
    public partial class frm_cambioPrecio : Form
    {
        public frm_cambioPrecio()
        {
            InitializeComponent();
        }

        private void frm_cambioPrecio_Load(object sender, EventArgs e)
        {
            lbl_muestraImpYTa.Text = Facturacion.ValorImpTazasYCargos.ToString();
            lbl_muestraImpPais.Text = Facturacion.ValorImpuestoPais.ToString();
            lbl_muestraImpUtn.Text = Facturacion.ValorImpuestoUtn.ToString();
            lbl_muestraCostoNacional.Text = Facturacion.ValorHoraVueloNacional.ToString();
            lbl_muestraCostoInternacional.Text = Facturacion.ValorHoraVueloInternacional.ToString();
           lbl_muestraPorcentaje.Text = Facturacion.PorcentajeMayorValorPremium.ToString();
          
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cambiarImpTaz_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Visible = false;
                Facturacion.ValorImpTazasYCargos = Facturacion.CambioPrecios( txt_ingresaImpuestoYtaza.Text);
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
 
        }

        private void btn_cambiarImpPais_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Visible = false;
                Facturacion.ValorImpuestoPais = Facturacion.CambioPrecios(txt_ingresaImpuestoPais.Text);
                

            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
            
        }
        
        private void btn_cambiarImpUTN_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Visible = false;                
                Facturacion.ValorImpuestoUtn = Facturacion.CambioPrecios(txt_ingresaImpuestoUtn.Text);
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
            
        }

        private void btn_cambiarHoraNac_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Visible = false;
                Facturacion.ValorHoraVueloNacional = Facturacion.CambioPrecios(txt_ingresaHoraNac.Text);
                Facturacion.ActualizarPreciosPremium();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }

        }

        private void btn_cambiarHoraInter_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Visible = false;
                Facturacion.ValorHoraVueloInternacional = Facturacion.CambioPrecios(txt_ingresaHoraInt.Text);
                Facturacion.ActualizarPreciosPremium();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }



        }

        private void btn_cambiarPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Visible = false;
                Facturacion.PorcentajeMayorValorPremium = Facturacion.CambioPrecios(txt_porcentaje.Text);
                Facturacion.ActualizarPreciosPremium();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                lbl_error.Visible = true;
            }
            
        }
    }
}
