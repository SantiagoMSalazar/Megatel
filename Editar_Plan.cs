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
    public partial class Editar_Plan : Form
    {
        public Editar_Plan()
        {
            InitializeComponent();
        }

        private void button_editar_Plan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Cancelar_editar_Plan_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
