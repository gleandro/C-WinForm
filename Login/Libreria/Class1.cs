using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Utilidades
    {

        public static DataSet Ejecutar(String cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Proyecto_Form;User ID=sa;Password=sql");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, con);

            DA.Fill(DS);

            con.Close();

            return DS;

        }
    }
}
