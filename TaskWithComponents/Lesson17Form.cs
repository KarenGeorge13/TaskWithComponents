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
    public partial class Lesson17Form : Form
    {
        public Lesson17Form()
        {
            InitializeComponent();
            progressBar1.Value = 53;
        }

        private void Lesson17Form_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls) 
            {
                if (c is ButtonBase) 
                {
                    ((ButtonBase)c).FlatStyle = FlatStyle.System;
                }
            }
        }
    }
}
