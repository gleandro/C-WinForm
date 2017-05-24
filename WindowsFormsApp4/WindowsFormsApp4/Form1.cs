using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlReader = new XmlTextReader("E:\\TEMPORALES\\XML\\archivo.xml");
            String ultimaEtiqueta = "";
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType ==XmlNodeType.Element)
                {
                    richTextBox1.Text += (new String(' ',xmlReader.Depth*3) + "<" + xmlReader.Name + ">");
                    ultimaEtiqueta = xmlReader.Name;
                    continue;
                }
                if (xmlReader.NodeType == XmlNodeType.Text)
                {
                    richTextBox1.Text += xmlReader.ReadContentAsString() + "</" + ultimaEtiqueta + ">";
                }
                else
                {
                    richTextBox1.Text += "\r";
                }
            }

        }
    }
}
