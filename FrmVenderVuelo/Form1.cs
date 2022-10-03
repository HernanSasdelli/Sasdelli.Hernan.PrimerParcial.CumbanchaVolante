using FrmNuevoPasajero;
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


namespace FrmVenderVuelo
{
    public partial class frm_subirAlAvion : Form
    {
        Vuelo vueloSeleccionado;

        public frm_subirAlAvion(string codVueloSeleccionado)
        {
            InitializeComponent();
            vueloSeleccionado = Vuelo.BuscarVueloPorId(codVueloSeleccionado);
            
        }


        private void frm_subirAlAvion_Load(object sender, EventArgs e)
        {
            cbo_tipoServicio.DataSource=Enum.GetNames(typeof(ETipoServicio));
            lbl_muestraTipoDestino.Text = vueloSeleccionado.TipoDestino;
            lbl_muestraVuelo.Text = vueloSeleccionado.CodigoDeVuelo;
            lbl_muestraOrigen.Text = vueloSeleccionado.OrigenVuelo;
            lbl_muestraDestino.Text = vueloSeleccionado.DestinoVuelo;
            lbl_muestraAeronave.Text = Vuelo.BuscarNombreAeronavePorPatente(vueloSeleccionado.PatenteAeronave);

            lbl_muestraCantBaños.Text = Vuelo.CantidadBañosPorPatente(vueloSeleccionado.PatenteAeronave).ToString();
            lbl_siNoWifi.Text = Validacion.ValidarServicio(vueloSeleccionado.TieneWifi);
            lbl_siNoRefrigerio.Text = Validacion.ValidarServicio(vueloSeleccionado.TieneServicioRefrescoBasico);
            lbl_siNoBufet.Text = Validacion.ValidarServicio(vueloSeleccionado.TieneServicioComida);

            lbl_muestraHorarioSalida.Text = vueloSeleccionado.HoraPartidaVuelo.ToString();
            lbl_muestraDuracion.Text = vueloSeleccionado.DuracionVuelo.ToString();
            lbl_muestraTotalTuris.Text = vueloSeleccionado.AsientosClaseTurista.ToString();
            lbl_muestraTotalPrem.Text = vueloSeleccionado.AsientosClasePremium.ToString();









        }

        private void lbl_muestraNumero_Click(object sender, EventArgs e)
        {
            
        }

        private void rad_variosPasajeros_CheckedChanged(object sender, EventArgs e)
        {
            lbl_muestraNumero.Enabled = true;
            nup_numeroPasajeros.Enabled  = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_siguienteEnVenta_Click(object sender, EventArgs e)
        {
            frm_cargarPasajero subirPasajero;
            try
            {
                if (rad_unPasajero.Checked == true)
                {
                    int cantPasajero = 1;
                    if (Vuelo.ConfirmarDisponibilidadVuelo(cbo_tipoServicio.Text, lbl_muestraVuelo.Text, cantPasajero))
                    {
                        subirPasajero = new frm_cargarPasajero();
                        subirPasajero.ShowDialog();
                    }
                }
                else if (rad_variosPasajeros.Checked == true)
                {
                    int cantPasajero = (int)nup_numeroPasajeros.Value;
                    if (Vuelo.ConfirmarDisponibilidadVuelo(cbo_tipoServicio.Text, lbl_muestraVuelo.Text, cantPasajero))
                    {
                        for (int i = 0; i < nup_numeroPasajeros.Value; i++)
                        {
                            subirPasajero = new frm_cargarPasajero();
                            subirPasajero.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_errorDispon.Text = ex.Message;
                lbl_errorDispon.Visible = true;
            }

        }

        private void cbo_tipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_tipoServicio.SelectedIndex == 0)
            {
                lbl_muestraAtencion.Visible = false;
                lbl_siNoBolsoMano.Text = "Si";
                lbl_cantValijaBodega.Text = "1";
                lbl_kgValija.Text = "23";
            }
            else if(cbo_tipoServicio.SelectedIndex == 1)
            {
                lbl_muestraAtencion.Visible = true;
                lbl_siNoBolsoMano.Text = "Si";
                lbl_cantValijaBodega.Text = "2";
                lbl_kgValija.Text = "25";
            }
        }
    }
}
