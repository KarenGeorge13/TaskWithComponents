using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWithComponents
{
    public partial class Lesson13Form : Form
    {
        public Lesson13Form()
        {
            InitializeComponent();
            InstalledFontCollection ifc = new InstalledFontCollection();
            foreach (FontFamily ff in ifc.Families) 
            {
                listBox1.Items.Add(ff.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(listBox1.Text, 20);
        }
    }
}
