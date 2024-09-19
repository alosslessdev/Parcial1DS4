using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1DS4
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, string edad, string sexo, string signo, string prediccion, string numeros)
        {
            InitializeComponent();
            label1.Text = nombre;
            label2.Text = edad;
            label3.Text = sexo;
            label4.Text = signo;
            label5.Text = prediccion;
            label6.Text = numeros;
        }


    }
}
