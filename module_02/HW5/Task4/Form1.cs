using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] s = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        string[] ss = null;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
                button2.Visible = true;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(s);
                ss = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z = listBox1.SelectedIndex;
            if (z < 0)
            {
                MessageBox.Show("Список пуст или\n нет выбранного элемента");
            }
            else
            {
                listBox1.Items.RemoveAt(z);
            }
        }
    }
}
