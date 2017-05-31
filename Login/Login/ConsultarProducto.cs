using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace Login
{
    public partial class ConsultarProducto : Consultas
    {
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDataGridView("Productos").Tables[0];
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;

                    string sql = "SELECT * FROM PRODUCTOS where nom_prod like '%" + txt_Nombre.Text.Trim() + "%';";
                    DS = Utilidades.Ejecutar(sql);
                    dataGridView1.DataSource = DS.Tables[0];

                }
                catch (Exception error)
                {
                    MessageBox.Show("ah ocurrido un error : " + error.Message);
                }
            }
        }
    }
}
