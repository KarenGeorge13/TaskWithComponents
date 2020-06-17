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
    public partial class Lesson2Form : Form
    {
        public Lesson2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                label1.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                label1.Text = ex.Message;
            }
            catch 
            {
                label1.Text = "Неизвестная ошибка";
            }
        }
    }
}
