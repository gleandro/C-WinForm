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
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        public override bool Guardar()
        {
            try
            {
                string sql = string.Format("EXEC SP_UPDATEINSERTPRODUCT '{0}','{1}','{2}'",txt_IdProducto.Text.Trim(),txt_Descripcion.Text.Trim(),txt_Precio.Text.Trim());
                Utilidades.Ejecutar(sql);
                MessageBox.Show("Se ah guardado Correctamente");
                Nuevo();
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ah ocurrido un error: " + error.Message);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string sql = string.Format("EXEC SP_DELETEPRODUCT '{0}'", txt_IdProducto.Text.Trim());
                Utilidades.Ejecutar(sql);
                MessageBox.Show("Se ah eliminado");
                Nuevo();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ah ocurrido un error: " + error.Message);
            }
        }

        public override void Consultar()
        {
            
        }

        public override void Nuevo()
        {
            txt_IdProducto.Text = "";
            txt_Descripcion.Text = "";
            txt_Precio.Text = "";
        }

    }
}
