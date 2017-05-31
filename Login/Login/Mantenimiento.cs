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
    public partial class Mantenimiento : FormBase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

    }
}
