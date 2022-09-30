using FrmNuevoPasajero;
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
        public frm_subirAlAvion()
        {
            InitializeComponent();
        }

        private void frm_subirAlAvion_Load(object sender, EventArgs e)
        {
            lbl_muestraNumero.Enabled = false;
        }

        private void lbl_muestraNumero_Click(object sender, EventArgs e)
        {
            
        }

        private void nup_numeroPasajeros_ValueChanged(object sender, EventArgs e)
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
            frm_cargarPasajero subirPasajero = new frm_cargarPasajero();
           // this.Hide();
            subirPasajero.ShowDialog();
            
        }
    }
}
