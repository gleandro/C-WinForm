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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }


        public override bool Guardar()
        {
            try
            {
                string sql = string.Format("EXEC SP_UPDATEINSERTCLIENT '{0}','{1}','{2}'", txt_IdCliente.Text.Trim(), txt_Nombre.Text.Trim(), txt_Apellido.Text.Trim());
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
                string sql = string.Format("EXEC SP_DELETECLIENT '{0}'", txt_IdCliente.Text.Trim());
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
            txt_IdCliente.Text = "";
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
        }
    }

}
