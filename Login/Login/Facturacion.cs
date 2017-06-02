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
        public static double total = 0;

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
                dataGridView1.Rows.Add(txt_Codigo_Cab.Text,txt_Descripcion.Text,txt_Precio.Text,txt_Cantidad.Text);
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
                    double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);
                    dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                }
                else
                {
                    dataGridView1.Rows.Add(txt_Codigo_Cab.Text, txt_Descripcion.Text, txt_Precio.Text, txt_Cantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_filas].Cells[3].Value);
                    dataGridView1.Rows[cont_filas].Cells[4].Value = importe;

                    cont_filas++;
                }

            }

            total = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                total += Convert.ToDouble(fila.Cells[4].Value);
            }
            lbl_Total.Text = "S/." + total.ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cont_filas > 0)
            {
                total = total - Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                lbl_Total.Text = "S/." + total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                cont_filas--;
            }
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ConsultarCliente C_cli = new ConsultarCliente();
            C_cli.ShowDialog();
            if (C_cli.DialogResult == DialogResult.OK)
            {
                txt_Codigo.Text = C_cli.dataGridView1.Rows[C_cli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txt_Cliente.Text = C_cli.dataGridView1.Rows[C_cli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txt_Codigo_Cab.Focus();
            }
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            ConsultarProducto C_pro = new ConsultarProducto();
            C_pro.ShowDialog();
            if (C_pro.DialogResult == DialogResult.OK)
            {
                txt_Codigo_Cab.Text = C_pro.dataGridView1.Rows[C_pro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txt_Descripcion.Text = C_pro.dataGridView1.Rows[C_pro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txt_Precio.Text = C_pro.dataGridView1.Rows[C_pro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txt_Cantidad.Focus();
            }
        }

        private void btn_Nuevos_Click(object sender, EventArgs e)
        {
            txt_Cantidad.Text = "";
            txt_Cliente.Text = "";
            txt_Codigo.Text = "";
            txt_Codigo_Cab.Text = "";
            txt_Descripcion.Text = "";
            txt_Precio.Text = "";
            lbl_Total.Text = "S/";
            dataGridView1.Rows.Clear();
        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            if (cont_filas != 0)
            {
                try
                {
                    string sql = string.Format("EXEC SP_UPDATEFACT '{0}'",txt_Codigo.Text.Trim());
                    DataSet DS = Utilidades.Ejecutar(sql);

                    string Numfac = DS.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        sql = string.Format("EXEC SP_UPDATEDETAIL '{0}','{1}','{2}','{3}'", Numfac, fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(), fila.Cells[3].Value.ToString());
                        DS = Utilidades.Ejecutar(sql);
                    }

                    MessageBox.Show("Se ah generado la factura '"+Numfac+"' exitosamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("se ah producido un error : " + error.Message);
                }


            }
        }
    }
}
