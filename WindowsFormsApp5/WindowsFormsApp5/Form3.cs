using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("E:\\TXT\\log.txt",FileMode.Open,FileAccess.Read) ;
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() != -1)
            {
                richTextBox1.Text += reader.ReadLine() + "\r";
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("E:\\TXT\\log2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine("Esta es la linea "+i);
            }

            writer.Close();
        }
    }
}
