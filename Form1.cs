using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1DS4
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int aleatorio;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                aleatorio = random.Next(101);
                label1.Text = aleatorio.ToString("D2");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = new DateTime(1900, 1, 01);
            dateTimePicker1.MaxDate = DateTime.Today;
        }


        private void EliminarTexto(TextBox cajaTxt, String patron)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cajaTxt.Text, patron))
            {
                cajaTxt.Text = cajaTxt.Text.Remove(cajaTxt.Text.Length - 1);
                cajaTxt.SelectionStart = cajaTxt.Text.Length;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EliminarTexto(textBox1, @"[^a-zA-Z]");


        }
    }
}

