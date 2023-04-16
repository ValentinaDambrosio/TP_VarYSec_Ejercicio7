using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio7
{
    public partial class fSumaDeDigitos : Form
    {
        public fSumaDeDigitos()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSuma_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tNumero.Text);
            int aux = num;
            int suma = num % 10;
            aux = num / 10;
            suma = suma + aux;
            MessageBox.Show("La suma de los dígitos del número " + num + " es " + suma);
        }
    }
}
