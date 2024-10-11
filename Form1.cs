using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ejemplo2_Tarea
{
    public partial class Form1 : Form
    {
        List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            listBoxNumeros.Items.Clear();
            numeros.Clear();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(rand.Next(0, 1001));
            }

            numeros = numeros.OrderBy(x => rand.Next()).ToList();

            foreach (int numero in numeros)
            {
                listBoxNumeros.Items.Add(numero);
            }

            int suma = numeros.Sum();

            toolStripLabelCantidad.Text = $"Cantidad: {suma}";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < numeros.Count - 1; i++)
            {
                for (int j = 0; j < numeros.Count - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            listBoxNumeros.Items.Clear();
            foreach (int numero in numeros)
            {
                listBoxNumeros.Items.Add(numero);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
