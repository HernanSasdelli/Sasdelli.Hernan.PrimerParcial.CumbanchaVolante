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
        private void CambiarVisibilidadOcupacion(bool trueOFalse)
        {
            lbl_ocupacionCabina.Visible = trueOFalse;
            lbl_mostrarOcupacionCabina.Visible = trueOFalse;
            lbl_mostrarOcupacionBodega.Visible = trueOFalse;
            lbl_ocupacionBodega.Visible = trueOFalse;
        }


        private void tmr_fechaYHoraActual_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();            
            lbl_fechaSistema.Text = DateTime.Now.ToLongDateString();
        }   

        private void btn_vuelos_Click(object sender, EventArgs e)
        {
            dtg_principal.DataSource = VistaUsuario.listaVuelosProximosParaMostrar;

        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            frm_nuevoCliente frmNuevoCliente = new frm_nuevoCliente();
            frmNuevoCliente.ShowDialog();
            

        }

        private void btn_nuevoVuelo_Click(object sender, EventArgs e)
        {
            frm_nuevoVuelo frmNuevoVuelo = new frm_nuevoVuelo();
            frmNuevoVuelo.ShowDialog(); 
            
        }

        private void Frm_menuPrincipal_Load(object sender, EventArgs e)
        {
            CambiarVisibilidadOcupacion(false);
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
           
        }

        private void btn_venderVuelo_Click(object sender, EventArgs e)
        {
            frm_subePasajero datosVenta = new frm_subePasajero(idVuelo);
            datosVenta.ShowDialog();
            Refresh();
        }

        private void btn_aviones_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled=false;
            dtg_principal.DataSource = Venta.listaAeronaves;
            dtg_secundario.DataSource = null;
            CambiarVisibilidadOcupacion(false);
        }

        private void dtg_principal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            dtg_secundario.DataSource = null;
            lbl_mostrarOcupacionBodega.Text = null;
            if (dtg_principal.DataSource == VistaUsuario.listaVuelosProximosParaMostrar)
            {
                CambiarVisibilidadOcupacion(true);
                btn_venderVuelo.Enabled = true;
                idVuelo = dtg_principal.CurrentRow.Cells[1].Value.ToString();
                Vuelo unVuelo = Vuelo.BuscarVueloPorId(idVuelo);
                dtg_secundario.DataSource = unVuelo.ListaDePasajeros;
                lbl_mostrarOcupacionCabina.Text = $"{unVuelo.PasajerosABordo} de {unVuelo.AsientosDisponiblesVuelo}";
                lbl_mostrarOcupacionBodega.Text = $"{unVuelo.ValijasEnBodega} de {unVuelo.CapacidadBodega}";
            }
            if(dtg_principal.DataSource == Venta.listaDeClientes)
            {
                string docClienteSelec = dtg_principal.CurrentRow.Cells[2].Value.ToString();
                Cliente unCliente = Venta.BuscarClientePorDni(docClienteSelec);
                dtg_secundario.DataSource = unCliente.VuelosYDestinos;
            }
        }

        private void btn_pasajeros_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled = false;
            dtg_principal.DataSource = Venta.listaDeClientes;
            dtg_secundario.DataSource = null;
            CambiarVisibilidadOcupacion(false);
        }
    }
}

