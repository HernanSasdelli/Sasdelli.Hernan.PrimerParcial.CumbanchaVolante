﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmMenuPrincipal;
using LibreriaDeClases;

namespace FrmLogueo
{
    public partial class FrmLogueo : Form
    {
        public FrmLogueo()
        {
            InitializeComponent();
        }

        private void BotonLogueoSalir(object sender, EventArgs e)
        {
            Close();
        }
        private void tb_usuario_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_errorIngreso.Visible = false;
        }

        private void tb_contraseña_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_errorIngreso.Visible = false;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {               
                Usuario usuarioIngresado =
                    Validacion.ValidarUsuarioyContraseña(tb_usuario.Text, tb_contraseña.Text,Venta.listaUsuarios);

                Frm_menuPrincipal frmMenuPrincipal = new Frm_menuPrincipal(usuarioIngresado);
                Hide();
                frmMenuPrincipal.ShowDialog();

                
                

            }
            catch (Exception exception)
            {
                lbl_errorIngreso.Text = exception.Message;
                lbl_errorIngreso.Visible = true;
            }


        }

        private void btn_logueoAleatorio_Click(object sender, EventArgs e)
        {
            lbl_errorIngreso.Visible = false;
            Usuario usuarioRandom = Usuario.LogueoAleatorio(Venta.listaUsuarios);
            tb_usuario.Text = usuarioRandom.Nombre;
            tb_contraseña.Text = usuarioRandom.Contraseña;
        }
    }
}
