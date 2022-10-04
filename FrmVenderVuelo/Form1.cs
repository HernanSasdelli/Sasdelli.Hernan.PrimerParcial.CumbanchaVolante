
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
    public partial class frm_nuevoPasajero : Form
    {/*
        private void btn_siguienteEnVenta_Click(object sender, EventArgs e)
        {

        }

        private void frm_nuevoPasajero_Load(object sender, EventArgs e)
        {

        }
        /Vuelo vueloSeleccionado;
string vueloNro;

public string VueloNro { get => vueloNro; }

public frm_nuevoPasajero(string codVueloSeleccionado)
{
InitializeComponent();
vueloSeleccionado = Vuelo.BuscarVueloPorId(codVueloSeleccionado);
//VueloNro = codVueloSeleccionado;
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


lbl_muestraDispTurista.Text = $"{Vuelo.SumarPasajerosTurista(vueloSeleccionado.CodigoDeVuelo)} de " +
$"{vueloSeleccionado.AsientosClaseTurista}";
lbl_muestraDispPremium.Text = $"{Vuelo.SumarPasajerosPremium(vueloSeleccionado.CodigoDeVuelo)} de " +
$"{vueloSeleccionado.AsientosClasePremium}";








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
       subirPasajero = new frm_cargarPasajero(lbl_muestraVuelo.Text,1, cantPasajero, cbo_tipoServicio.Text); ;
       subirPasajero.ShowDialog();
   }
}
else if (rad_variosPasajeros.Checked == true)
{
   int cantPasajero = (int)nup_numeroPasajeros.Value;
   if (Vuelo.ConfirmarDisponibilidadVuelo(cbo_tipoServicio.Text, lbl_muestraVuelo.Text, cantPasajero))
   {
       for(int i = 1; i <= cantPasajero; i++)
       { 
           subirPasajero = new frm_cargarPasajero(lbl_muestraVuelo.Text,i, cantPasajero, cbo_tipoServicio.Text);
           subirPasajero.ShowDialog();
       }
   }
}
else
{
   throw new Exception("Debe cargar cantidad de pasajeros");
}
Close();

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
lbl_kgValija.Text = "21";
}
else if(cbo_tipoServicio.SelectedIndex == 1)
{
lbl_muestraAtencion.Visible = true;
lbl_siNoBolsoMano.Text = "Si";
lbl_cantValijaBodega.Text = "2";
lbl_kgValija.Text = "25";
}
}

private void nup_numeroPasajeros_ValueChanged(object sender, EventArgs e)
{

}*/
        private void frm_nuevoPasajero_Load(object sender, EventArgs e)
        {

        }
    }
}
