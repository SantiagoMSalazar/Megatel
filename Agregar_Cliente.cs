using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megatel
{
    public partial class Agregar_Cliente : Form
    {
        public Agregar_Cliente()
        {
            InitializeComponent();
        }

        private void button_agregar_Cliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Cancelar_agregar_Cliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
