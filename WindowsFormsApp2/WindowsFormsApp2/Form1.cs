using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("RAIZ");
            treeView1.Nodes[0].Nodes.Add("Hijo");
            treeView1.Nodes[0].Nodes.Add("Hijo 2");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("S Hijo 2");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("S Hijo 3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Valor1");
            listView1.Items[0].SubItems.Add("Valor2");
            listView1.Items.Add("Valor3");
            listView1.Items[1].SubItems.Add("Valor4");

        }
    }
}
