using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_Ej1_Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular(Button btn)
        {
            if (btn.Name == btnSumar.Name)
            {
                Sumar sumar = new Sumar();

                tbResultado.Text = "" + sumar.operar((int) tbNum1.Value, (int) tbNum2.Value);
            }
            else if (btn.Name == btnRestar.Name)
            {
                Restar restar = new Restar();

                tbResultado.Text = "" + restar.operar((int)tbNum1.Value, (int)tbNum2.Value);
            }
            else if (btn.Name == btnMultiplicar.Name)
            {
                Multiplicar multiplicar = new Multiplicar();

                tbResultado.Text = "" + multiplicar.operar((int)tbNum1.Value, (int)tbNum2.Value);
            }
            else
            {
                tbNum1.Value = 0;
                tbNum2.Value = 0;
                tbResultado.Text = "";
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Calcular((Button) sender);
        }
    }
}
