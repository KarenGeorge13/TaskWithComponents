using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace TaskWithComponents
{
    public partial class Lesson7Form : Form
    {
        public Lesson7Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("1.xml");
            XmlNode d = xml.DocumentElement;
            XmlNodeList xnl = d.ChildNodes;
            for (int i = 0; i < d.ChildNodes.Count; i++)
            {
                MessageBox.Show(xnl[i].Attributes["text"].Value + " " + xnl[i].Attributes["rustext"].Value);
            }

        }
    }
}
