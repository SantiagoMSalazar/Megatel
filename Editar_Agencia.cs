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
    public partial class Editar_Agencia : Form
    {
        public Editar_Agencia()
        {
            InitializeComponent();
        }

        private void button_editar_Agencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Cancelar_editar_Agencia_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
