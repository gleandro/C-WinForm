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
    public partial class ConsultarCliente : Consultas
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDataGridView("Clientes").Tables[0];
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;

                    string sql = "SELECT * FROM CLIENTES where nom_cli like '%" + txt_Nombre.Text.Trim() + "%' or apel_cli like '%" + txt_Nombre.Text.Trim() + "%';";
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
