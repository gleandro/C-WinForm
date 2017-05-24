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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            XmlElement raiz = xml.CreateElement("Libros");
            xml.AppendChild(raiz);

            XmlElement libro = xml.CreateElement("libro");
            raiz.AppendChild(libro);

            XmlElement titulo = xml.CreateElement("titulo");
            titulo.AppendChild(xml.CreateTextNode("El Hobbit"));
            libro.AppendChild(titulo);

            XmlElement precio = xml.CreateElement("precio");
            precio.AppendChild(xml.CreateTextNode("10.00"));
            libro.AppendChild(precio);

            xml.Save("E:\\TEMPORALES\\XML\\archivo.xml");
        }
    }
}
