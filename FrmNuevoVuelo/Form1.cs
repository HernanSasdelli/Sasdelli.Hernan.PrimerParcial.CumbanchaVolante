using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeClases;

namespace FrmNuevoVuelo
{
    public partial class frm_nuevoVuelo : Form
    {
        public frm_nuevoVuelo()
        {
            InitializeComponent();
          
        }        

        private void btn_agregarVuelo_Click(object sender, EventArgs e)
        {
            
            try
            {
                Venta.AgregarVueloALista(
               Validacion.ValidarVuelo(
                      lbl_mostrarCodVueloRamdom.Text,
                      cbo_aeronaveDesignada.Text,
                      cbo_tipoVuelo.Text,
                      cbo_origenNuevoVuelo.Text,
                      cbo_destinoNuevoVuelo.Text,
                      lbl_mostrarDuracionVueloRamdom.Text,
                      dtp_fechaNuevoVuelo.Value.Hour,
                      dtp_fechaNuevoVuelo.Value.ToShortDateString(),
                      lbl_mostrarCantAsientos.Text,
                      chk_comida.Checked,
                      chk_refresco.Checked,
                      chk_wifi.Checked,
                      lbl_mostrarCapacidadBodega.Text));

                MessageBox.Show("Vuelo Agregado con éxito", "", MessageBoxButtons.OK);
            }
            catch (Exception exepcion)
            {
                lbl_mostrarExepcion.Visible = true;
                lbl_mostrarExepcion.Text = exepcion.Message;
            }
            
        }

        private void btn_cancelarCargaVuelo_Click(object sender, EventArgs e)
        {
            Close();           
        }

        private void cbo_aeronaveDesignada_SelectedIndexChanged(object sender, EventArgs e)
        {           
            string aeronave = cbo_aeronaveDesignada.Text;

            Aeronave aeronaveDesignada = Vuelo.BuscarAeronavePorPatente(Venta.listaAeronaves, aeronave);
            
            lbl_nombreAeronave.Text = aeronaveDesignada.NombreAeronave;
            lbl_cantBaños.Text = aeronaveDesignada.CantidadDeBaños.ToString();
            lbl_mostrarCantAsientos.Text = aeronaveDesignada.CantidadDeAsientos.ToString();
            lbl_mostrarCapacidadBodega.Text = aeronaveDesignada.CapacidadDeBodega.ToString();
            
            int asientosPremium = Vuelo.CalcularCantidadAsientosPremium(aeronaveDesignada.CantidadDeAsientos);
            lbl_mostrarCantPremium.Text = asientosPremium.ToString();
            lbl_mostrarCantTurista.Text = Vuelo.CalcularCantidadAsientosTurista(aeronaveDesignada.CantidadDeAsientos, asientosPremium).ToString(); 

        }

        private void cbo_origenNuevoVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string origen = cbo_origenNuevoVuelo.Text;            
            if(cbo_tipoVuelo.SelectedIndex == 0)
            {
                cbo_destinoNuevoVuelo.DataSource = Vuelo.DestinosPosiblesNac(origen);
            }
            else if(cbo_tipoVuelo.SelectedIndex == 1)
            {
                    cbo_destinoNuevoVuelo.DataSource = Vuelo.DestinosPosiblesInter(origen);          
            }      
            
         
        }

        private void frm_nuevoVuelo_Load(object sender, EventArgs e)
        {
            cbo_aeronaveDesignada.SelectedItem = null;
            cbo_tipoVuelo.DataSource = Enum.GetNames(typeof(ETipoDestino));
            cbo_aeronaveDesignada.DataSource = Vuelo.ListaPatentes(Venta.listaAeronaves);

           lbl_mostrarCodVueloRamdom.Text = Vuelo.CodigoDeVueloRandom().ToString();

            
            dtp_fechaNuevoVuelo.MinDate = DateTime.Today.AddDays(1);
            dtp_fechaNuevoVuelo.MaxDate = DateTime.Today.AddDays(365.25);



        }

        private void cbo_tipoVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_destinoNuevoVuelo.DataSource = null;

            if (cbo_tipoVuelo.SelectedIndex == 1)
            {
                cbo_origenNuevoVuelo.DataSource = Vuelo.listaDestinosInternacionales;
            }
            else if (cbo_tipoVuelo.SelectedIndex == 0)
            {
                cbo_origenNuevoVuelo.DataSource = Vuelo.listaDestinosNacionales;
            }
        }

        private void cbo_destinoNuevoVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_mostrarDuracionVueloRamdom.Text = "";

            if (cbo_tipoVuelo.SelectedIndex == 1)
            {
                lbl_mostrarDuracionVueloRamdom.Text = Vuelo.CalcularHorasVueloInter().ToString();
            }
            else if (cbo_tipoVuelo.SelectedIndex == 0)
            {
                lbl_mostrarDuracionVueloRamdom.Text = Vuelo.CalcularHorasVueloNac().ToString();
            }
        }

        private void dtp_fechaNuevoVuelo_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}