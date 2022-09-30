using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrmNuevoCliente;
using FrmNuevoVuelo;
using FrmVenderVuelo;
using LibreriaDeClases;


namespace FrmMenuPrincipal
{
    public partial class Frm_menuPrincipal : Form
    {
        private Usuario usuarioLogueado;
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
           // List<Aeronave> listaAMostrar = Harcodeo.CargarAeronaves();
           // dtg_principal.DataSource = listaAMostrar;              
            
        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            frm_nuevoCliente frmNuevoCliente = new frm_nuevoCliente();
            frmNuevoCliente.ShowDialog();
            this.Enabled = true;

        }

        private void btn_nuevoVuelo_Click(object sender, EventArgs e)
        {
            frm_nuevoVuelo frmNuevoVuelo = new frm_nuevoVuelo();
            frmNuevoVuelo.ShowDialog(); 
            
        }

        private void Frm_menuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cambiarUsuario_Click(object sender, EventArgs e)
        {

            Close();         
            
            
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
            
            btn_venderVuelo.Enabled = true;
            btn_venderVuelo.BackColor  = System.Drawing.Color.LightGreen;
        }

        private void btn_venderVuelo_Click(object sender, EventArgs e)
        {
            frm_subirAlAvion ventaVuelo = new frm_subirAlAvion();
            ventaVuelo.ShowDialog();
        }

        private void btn_aviones_Click(object sender, EventArgs e)
        {
            dtg_principal.DataSource = Venta.listaAeronaves;
        }
    }
}

