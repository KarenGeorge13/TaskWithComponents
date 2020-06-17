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
    public partial class Lesson31Form : Form
    {
        public Lesson31Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C\:tmp";
            saveFileDialog1.Filter = "abc files (*.abs)|*.abs|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                label1.Text = saveFileDialog1.FileName;
            }
        }
    }
}
