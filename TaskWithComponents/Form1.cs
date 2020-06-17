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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.Items.AddRange(init());
		}
		private static string [] init() 
		{
			string[] mas = new string[32];
			for (int i = 0; i < 32; i++) 
			{
				mas[i] = "Урок " + (i + 1);
			}
			return mas;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			switch (comboBox1.Text) 
			{
				case "Урок 1":
					Lesson1Form l1 = new Lesson1Form();
					l1.ShowDialog();
					break;
				case "Урок 2":
					Lesson2Form l2 = new Lesson2Form();
					l2.ShowDialog();
					break;
				case "Урок 3":
					Lesson3_5Form l3 = new Lesson3_5Form();
					l3.ShowDialog();
					break;
				case "Урок 4":
					Lesson3_5Form l4 = new Lesson3_5Form();
					l4.ShowDialog();
					break;
				case "Урок 5":
					Lesson3_5Form l5 = new Lesson3_5Form();
					l5.ShowDialog();
					break;
				case "Урок 6":
					Lesson6Form l6 = new Lesson6Form();
					l6.ShowDialog();
					break;
				case "Урок 7":
					Lesson7Form l7 = new Lesson7Form();
					l7.ShowDialog();
					break;
				case "Урок 8":
					Lesson8Form l8 = new Lesson8Form();
					l8.ShowDialog();
					break;
				case "Урок 9":
					Lesson9Form l9 = new Lesson9Form();
					l9.ShowDialog();
					break;
				case "Урок 10":
					Lesson10Form l10 = new Lesson10Form();
					l10.ShowDialog();
					break;
				case "Урок 11":
					Lesson11Form l11 = new Lesson11Form();
					l11.ShowDialog();
					break;
				case "Урок 12":
					Lesson12Form l12 = new Lesson12Form();
					l12.ShowDialog();
					break;
				case "Урок 13":
					Lesson13Form l13 = new Lesson13Form();
					l13.ShowDialog();
					break;
				case "Урок 14":
					Lesson14_16Form l14 = new Lesson14_16Form();
					l14.ShowDialog();
					break;
				case "Урок 15":
					Lesson14_16Form l15 = new Lesson14_16Form();
					l15.ShowDialog();
					break;
				case "Урок 16":
					Lesson14_16Form l16 = new Lesson14_16Form();
					l16.ShowDialog();
					break;
				case "Урок 17":
					Lesson17Form l17 = new Lesson17Form();
					l17.ShowDialog();
					break;
				case "Урок 18":
					Lesson18_20Form l18 = new Lesson18_20Form();
					l18.ShowDialog();
					break;
				case "Урок 19":
					Lesson18_20Form l19 = new Lesson18_20Form();
					l19.ShowDialog();
					break;
				case "Урок 20":
					Lesson18_20Form l20 = new Lesson18_20Form();
					l20.ShowDialog();
					break;
				case "Урок 21":
					Lesson21Form l21 = new Lesson21Form();
					l21.ShowDialog();
					break;
				case "Урок 22":
					Lesson22Form l22 = new Lesson22Form();
					l22.ShowDialog();
					break;
				case "Урок 23":
					Lesson23Form l23 = new Lesson23Form();
					l23.ShowDialog();
					break;
				case "Урок 24":
					Lesson24Form l24 = new Lesson24Form();
					l24.ShowDialog();
					break;
				case "Урок 25":
					Lesson25Form l25 = new Lesson25Form();
					l25.ShowDialog();
					break;
				case "Урок 26":
					Lesson26Form1 l26 = new Lesson26Form1();
					l26.ShowDialog();
					break;
				case "Урок 27":
					Lesson27Form l27 = new Lesson27Form();
					l27.ShowDialog();
					break;
				case "Урок 28":
					Lesson28Form l28 = new Lesson28Form();
					l28.ShowDialog();
					break;
				case "Урок 29":
					Lesson29Form l29 = new Lesson29Form();
					l29.ShowDialog();
					break;
				case "Урок 30":
					Lesson30Form l30 = new Lesson30Form();
					l30.ShowDialog();
					break;
				case "Урок 31":
					Lesson31Form l31 = new Lesson31Form();
					l31.ShowDialog();
					break;
				case "Урок 32":
					Lesson32Form l32 = new Lesson32Form();
					l32.ShowDialog();
					break;
				default:
					break;
			}
        }
    }
}
