using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrmNuevoCliente;
using System.Linq;
using FrmNuevoVuelo;
using FrmSubirPasajero;
using LibreriaDeClases;
using Estadisticas;
using FrmCambioDeprecios;

namespace FrmMenuPrincipal
{
    public partial class Frm_menuPrincipal : Form
    {
        private Usuario usuarioLogueado;
        private string idVuelo;
        Vuelo unVuelo;
        List<Factura> listaFacturacion;
        
        

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

        //LOAD
        private void Frm_menuPrincipal_Load(object sender, EventArgs e)
        {
            CambiarVisibilidadOcupacion(false);            
            Vuelo.SumarHorasDeVueloAeronaves(Venta.listaDeVuelos);
            Vuelo.CambiarEstadoDeVuelo(Venta.listaDeVuelos);
            Cliente.CargarDestinosYCantDeVuelosACliente(Venta.listaDeVuelos);
            
            

        }
        //Botones Arriba
        private void tmr_fechaYHoraActual_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();            
            lbl_fechaSistema.Text = DateTime.Now.ToLongDateString();
        }   

        private void btn_vuelos_Click(object sender, EventArgs e)
        {
            dtg_secundario.Columns.Clear();         
            
            VistaUsuario.ListaVuelosSegunEstado = VistaUsuario.CrearNuevaListadeVuelos(Venta.listaDeVuelos, "Proximo");

            dtg_principal.DataSource = VistaUsuario.ListaVuelosSegunEstado;
        }

        private void btn_pasajeros_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled = false;
            dtg_principal.DataSource = Venta.listaDeClientes;

            dtg_secundario.DataSource = null;
            CambiarVisibilidadOcupacion(false);
        }
        private void btn_aviones_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled = false;
            dtg_principal.DataSource = Venta.listaAeronaves;
            dtg_secundario.DataSource = null;
            dtg_secundario.Columns.Clear();
            CambiarVisibilidadOcupacion(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dtg_principal.DataSource = null;
            dtg_secundario.Columns.Clear();
            Facturacion.listaDeFacturas = Facturacion.FacturarDesdeHarcodeo(Venta.listaDeVuelos);
            dtg_principal.DataSource = Facturacion.listaDeFacturas;
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            Form1 estadisticas = new Form1();
            estadisticas.ShowDialog();
        }
        //dataGridView
        private void dtg_principal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_secundario.DataSource = null;
            dtg_secundario.Columns.Clear();

            lbl_mostrarOcupacionBodega.Text = null;
            if (dtg_principal.DataSource == VistaUsuario.ListaVuelosSegunEstado)
            {
                CambiarVisibilidadOcupacion(true);
                btn_venderVuelo.Enabled = true;
                idVuelo = dtg_principal.CurrentRow.Cells[1].Value.ToString();
                unVuelo = Vuelo.BuscarVueloPorId(idVuelo);
                dtg_secundario.DataSource = unVuelo.ListaDePasajeros;
                lbl_mostrarOcupacionCabina.Text = $"{unVuelo.PasajerosABordo} de {unVuelo.AsientosDisponiblesVuelo}";
                lbl_mostrarOcupacionBodega.Text = $"{unVuelo.ValijasEnBodega} de {unVuelo.CapacidadBodega}";
            }
            else if (dtg_principal.DataSource == Venta.listaDeClientes)
            {

                string docClienteSelec = dtg_principal.CurrentRow.Cells[5].Value.ToString();
                Cliente unCliente = Venta.BuscarClientePorDni(docClienteSelec);

                List<string> vuelosRealizadosXCliente = unCliente.ListaDestinosXCliente();

                dtg_secundario.Columns.Add("VuelosRealizados", "Vuelos Realizados");
                for (int i = 0; i < vuelosRealizadosXCliente.Count; i++)
                {
                    dtg_secundario.Rows.Add(vuelosRealizadosXCliente[i]);
                }

                MessageBox.Show(unCliente.MostrarInfoCliente());
            }
            else if(dtg_principal.DataSource == Venta.listaAeronaves)
            {
                string patenteAeronaveSelec = dtg_principal.CurrentRow.Cells[0].Value.ToString();
                dtg_secundario.DataSource = Aeronave.ListaVuelosPorPatente(patenteAeronaveSelec);
            }
        }
        private void dtg_secundario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_secundario.DataSource == unVuelo.ListaDePasajeros)
            {
                string dni = dtg_secundario.CurrentRow.Cells[10].Value.ToString();
                Pasajero pasajeroSelect = Pasajero.BuscarPasajeroPorDni(dni, unVuelo);
                MessageBox.Show(pasajeroSelect.MostrarInfoCliente());
            }
        }

        //Botones de Abajo
        private void btn_venderVuelo_Click(object sender, EventArgs e)
        {
            frm_subePasajero datosVenta = new frm_subePasajero(idVuelo);
            datosVenta.ShowDialog();
            
        }


        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled = false;
            frm_nuevoCliente frmNuevoCliente = new frm_nuevoCliente();
            frmNuevoCliente.ShowDialog();

        }

        private void btn_nuevoVuelo_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled = false;
            frm_nuevoVuelo frmNuevoVuelo = new frm_nuevoVuelo();
            frmNuevoVuelo.ShowDialog();
        }
        private void btn_mostrarEstadisticas_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled = false;
            frm_cambioPrecio cambiarPrecio = new frm_cambioPrecio();
            cambiarPrecio.ShowDialog();

        }


        //Salir
        private void btn_salirMenuPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("               ¿Seguro desea Salir?", "", MessageBoxButtons.YesNo);

            switch (salir)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private void btn_vuelosHistorico_Click(object sender, EventArgs e)
        {
            btn_venderVuelo.Enabled = false;
            List<Vuelo> listaOrdenadaXFecha = Venta.listaDeVuelos.OrderBy(vuelo => DateTime.Parse(vuelo.FechaVuelo)).ToList();
            dtg_principal.DataSource = listaOrdenadaXFecha;
        }


    }
}

