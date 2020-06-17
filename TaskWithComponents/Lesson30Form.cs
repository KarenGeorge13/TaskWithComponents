using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWithComponents
{
    public partial class Lesson30Form : Form
    {
        string fileName;
        public Lesson30Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                fileName = openFileDialog1.FileName;
                Text = fileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in openFileDialog1.FileNames) 
                {
                    listBox1.Items.Add(s);
                }
            }
        }
    }
}
