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
    public partial class Lesson29Form : Form
    {
        Font font;
        public Lesson29Form()
        {
            InitializeComponent();
            font = DefaultFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) 
            {
                font = fontDialog1.Font;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Test", font, Brushes.Blue, 20, 20);
            base.OnPaint(e);
        }
    }
}
