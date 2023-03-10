using System;
using System.Windows.Forms;

namespace Megatel
{
    public partial class Agregar_Contrato : Form
    {
        public Agregar_Contrato()
        {
            InitializeComponent();
        }

        private void button_agregar_Contrato_Click(object sender, EventArgs e)
        {
            String agencia = "";
            if (this.com_Agencia.Text == "El Ángel")
            {
                agencia = "1";
            }
            else if (this.com_Agencia.Text == "Tulcán")
            {
                agencia = "2";
            }
            Conection cn = new Conection();
            cn.AgregarContrato(this.textBox4_idContrato.Text, this.textBox6_idCliente.Text, this.textBox5_idPlan.Text, this.textBox7.Text, agencia);
            MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Menu menu = new Menu();
            menu.Show(this);
            this.Close();
        }

        private void button_Cancelar_agregar_Contrato_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
