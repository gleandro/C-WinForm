using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;

            if (File.Exists("E:\\TEMPORALES\\NUEVO\\A\\" + openFileDialog1.SafeFileName) == true)
            MessageBox.Show("El archivo existe");
            else
            File.Copy(label1.Text, "E:\\TEMPORALES\\NUEVO\\A\\" + openFileDialog1.SafeFileName);
        }
    }
}
