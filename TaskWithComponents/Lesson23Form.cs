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
    public partial class Lesson23Form : Form
    {
        public Lesson23Form()
        {
            InitializeComponent();
        }

        private void Lesson23Form_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.ContextMenuStrip = contextMenuStrip1;
                c.MouseDown += new MouseEventHandler(this.ShowPopupMenu);
            }
        }
        private void ShowPopupMenu(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Right) 
            {
                Control c = (Control)sender;
                if (c.ContextMenuStrip != null) 
                {
                    c.ContextMenuStrip.Show(c, new Point(e.X, e.Y));
                }
            }
        }
    }
}
