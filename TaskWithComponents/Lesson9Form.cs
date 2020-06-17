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
    public partial class Lesson9Form : Form
    {
        public Lesson9Form()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you?");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you?");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.AddRange(new ToolStripItem[] { this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem });
            this.ContextMenuStrip = cms;
        }
    }
}
