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
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static int codigo;
        public static string cuenta;
        public static string nombre;
        public static string foto;


        private void btn_Iniciar_Click(object sender, EventArgs e)
        {

            try
            {
                string CMD = string.Format("select * from Usuario where account ='{0}' and password ='{1}'",txt_usuario.Text.Trim(),txt_clave.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                codigo = Convert.ToInt16(ds.Tables[0].Rows[0]["id_usuario"]);
                nombre = ds.Tables[0].Rows[0]["nom_usu"].ToString().Trim();
                cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                foto = ds.Tables[0].Rows[0]["foto"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                Boolean bl_admin = Convert.ToBoolean(ds.Tables[0].Rows[0]["bl_admin"]);

                if (bl_admin)
                {
                    VentanaAdmin v_adm = new VentanaAdmin();
                    this.Hide();
                    v_adm.Show();
                }
                else
                {
                    VentanaUser v_user = new VentanaUser();
                    this.Hide();
                    v_user.Show();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR : "+error.Message);
            }

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
