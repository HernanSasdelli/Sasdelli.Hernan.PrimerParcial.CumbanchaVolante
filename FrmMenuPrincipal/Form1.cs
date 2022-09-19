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

namespace FrmMenuPrincipal
{
    public partial class Frm_menuPrincipal : Form
    {
        public Frm_menuPrincipal()
        {
            InitializeComponent();
        }

        private void tmr_fechaYHoraActual_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            //lbl_diaSistema.Text = DateTime.Now.DayOfWeek.ToString();
            lbl_fechaSistema.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_vuelos_Click(object sender, EventArgs e)
        {
            List<Aeronave> listaAMostrar = Harcodeo.CargarAeronaves();
            dtg_principal.DataSource = listaAMostrar;
          
            
            
        }
    }
}
