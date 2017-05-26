﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class VentanaUser : Form
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = VentanaLogin.nombre;
            txt_Usuario.Text = VentanaLogin.cuenta;
            txt_Codigo.Text = VentanaLogin.codigo.ToString();
            pictureBox1.Image = Image.FromFile(VentanaLogin.foto);
        }
    }
}