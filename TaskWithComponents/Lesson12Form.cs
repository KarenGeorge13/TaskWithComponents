using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWithComponents
{
    public partial class Lesson12Form : Form
    {
        public Lesson12Form()
        {
            InitializeComponent();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, 100, 100);
            gp.AddEllipse(110, 0, 100, 100);
            Region r = new Region(gp);
            this.Region = r;
        }
    }
}
