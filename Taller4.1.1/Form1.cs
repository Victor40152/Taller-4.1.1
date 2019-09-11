using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller4._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            int numero, total, contador;
            numero = int.Parse(txtnombre.Text);
            contador = 0;
            int limite = 10;
           for (int i = 1; i <=limite;i++)
            {

                contador = contador + 1;

               total = numero * contador;
                dgdatos.Rows.Add(numero, contador.ToString(), total.ToString());

         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgdatos.Rows.Clear();
            txtnombre.Text = "";
            txtnombre.Focus();
        }
    }
}
