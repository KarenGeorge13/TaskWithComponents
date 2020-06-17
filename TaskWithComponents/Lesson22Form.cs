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
    public partial class Lesson22Form : Form
    {
        public Lesson22Form()
        {
            InitializeComponent();
        }

        private void Lesson22Form_Load(object sender, EventArgs e)
        {
            linkLabel1.Links[0].LinkData = "https://www.youtube.com";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
