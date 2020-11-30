using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] lines = new string[]{ "один", "два", "три", "четыре", "пять", "шесть", "семь" };

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Lines = lines;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Результат:\n"+String.Join(' ',textBox1.Lines));
        }
    }
}
