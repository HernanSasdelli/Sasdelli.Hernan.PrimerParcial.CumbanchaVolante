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

namespace FrmETicket
{
    public partial class frm_emitirEticket : Form
    {

        private Vuelo vueloSeleccionado;
        private Pasajero pasajeroComprador;

        public frm_emitirEticket()
        {
            InitializeComponent();
        }
        public frm_emitirEticket(Pasajero pasajeroASubir, Vuelo vueloSelect):this()
        {
            vueloSeleccionado = vueloSelect;
            pasajeroComprador = pasajeroASubir;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_apellido.Text = pasajeroComprador.Apellido;
            lbl_nombre.Text = pasajeroComprador.Nombre;

            lbl_muestraDestino.Text = vueloSeleccionado.DestinoVuelo;
            lbl_muestraOrigen.Text = vueloSeleccionado.OrigenVuelo;

            lbl_muestraVuelo.Text = vueloSeleccionado.CodigoDeVuelo;
           
            
        }

        private void btn_emitirTicket_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}
