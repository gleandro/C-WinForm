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
    public partial class Facturacion : Procesos
    {
        public static int cont_filas = 0;

        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * from usuario where id_usuario = " +VentanaLogin.codigo;

            DataSet DS = Utilidades.Ejecutar(sql);

            lbl_Atiende.Text = DS.Tables[0].Rows[0]["nom_usu"].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Codigo.Text.Trim()) == false )
            {
                try
                {
                    string sql = "select * from Clientes where id_cliente = " + txt_Codigo.Text.Trim();

                    DataSet DS = Utilidades.Ejecutar(sql);

                    txt_Cliente.Text = DS.Tables[0].Rows[0]["nom_cli"].ToString().Trim() + " " + DS.Tables[0].Rows[0]["apel_cli"].ToString().Trim();

                    txt_Codigo_Cab.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se encontraron Registros");
                }
               
            }
        }

        private void btn_Colocar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int num_fila = 0;

            if (cont_filas == 0)
            {
                dataGridView1.Rows.Add(txt_Codigo_Cab.Text,txt_Descripcion.Text,txt_Cantidad.Text,txt_Precio.Text);
                double importe = Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[3].Value);
                dataGridView1.Rows[cont_filas].Cells[4].Value = importe;

                cont_filas++;
            }
            else
            {
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == txt_Codigo_Cab.Text)
                    {
                        existe = true;
                        num_fila = fila.Index;
                    }
                }

                if (existe == true)
                {
                    dataGridView1.Rows[num_fila].Cells[3].Value = Convert.ToDouble(txt_Cantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);
                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[num_fila].Value) * Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[num_fila].Value);
                    dataGridView1.Rows[cont_filas].Cells[num_fila].Value = importe;
                }
                else
                {
                    dataGridView1.Rows.Add(txt_Codigo_Cab.Text, txt_Descripcion.Text, txt_Cantidad.Text, txt_Precio.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[3].Value);
                    dataGridView1.Rows[cont_filas].Cells[4].Value = importe;

                    cont_filas++;
                }

            }
        }
    }
}
