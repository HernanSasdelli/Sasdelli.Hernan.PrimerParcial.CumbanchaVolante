using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrmNuevoCliente;

using FrmNuevoVuelo;
using FrmSubirPasajero;
using LibreriaDeClases;


namespace FrmMenuPrincipal
{
    public partial class Frm_menuPrincipal : Form
    {
        private Usuario usuarioLogueado;
        private string idVuelo;

        public string IdVuelo { get => idVuelo;}

        public Frm_menuPrincipal(Usuario usuarioIngresado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioIngresado;
            lbl_usuario.Text = $"Hola {usuarioIngresado.Nombre}";

        }

        private void tmr_fechaYHoraActual_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();            
            lbl_fechaSistema.Text = DateTime.Now.ToLongDateString();
        }   

        private void btn_vuelos_Click(object sender, EventArgs e)
        {
            dtg_principal.DataSource = Venta.listaDeVuelos;

        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            frm_nuevoCliente frmNuevoCliente = new frm_nuevoCliente();
            frmNuevoCliente.ShowDialog();
            //this.Enabled = true;

        }

        private void btn_nuevoVuelo_Click(object sender, EventArgs e)
        {
            frm_nuevoVuelo frmNuevoVuelo = new frm_nuevoVuelo();
            frmNuevoVuelo.ShowDialog(); 
            
        }

        private void Frm_menuPrincipal_Load(object sender, EventArgs e)
        {
 
        }


        private void btn_salirMenuPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("               ¿Seguro desea Salir?", "",MessageBoxButtons.YesNo);

            switch(salir)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;             
                
            }            
        }

        private void dtg_principal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_principal.DataSource == Venta.listaDeVuelos)
            {
                btn_venderVuelo.Enabled = true;
                idVuelo = dtg_principal.CurrentRow.Cells[1].Value.ToString();
                foreach (Vuelo unVuelo in Venta.listaDeVuelos)
                {
                    dtg_secundario.DataSource = unVuelo.ListaDePasajeros;
                    dtg_terceario.DataSource = unVuelo.ValijasEnBodega;
                }
                
            }
        }

        private void btn_venderVuelo_Click(object sender, EventArgs e)
        {
            frm_subePasajero datosVenta = new frm_subePasajero(idVuelo);
            datosVenta.ShowDialog();

        }

        private void btn_aviones_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled=false;
            dtg_principal.DataSource = Venta.listaAeronaves;
        }
    }
}

