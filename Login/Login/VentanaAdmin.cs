using System;
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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            txt_Admin.Text = VentanaLogin.nombre;
            txt_Usuario.Text = VentanaLogin.cuenta;
            txt_Codigo.Text = VentanaLogin.codigo.ToString();
            pictureBox1.Image = Image.FromFile(VentanaLogin.foto);
        }
    }
}
