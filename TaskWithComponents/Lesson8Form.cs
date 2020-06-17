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
    public partial class Lesson8Form : Form
    {
        private int num;
        public Lesson8Form()
        {
            InitializeComponent();
            num = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.ToolStripMenuItem_Click;
            menuToolStripMenuItem.DropDownItems.Add(mi);
        }
        private void ToolStripMenuItem_Click(object sender, System.EventArgs e) 
        {
            MessageBox.Show(((ToolStripMenuItem)sender).Text);
        }
    }
}
