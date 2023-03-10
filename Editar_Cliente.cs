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
    public partial class Editar_Cliente : Form
    {
        int idCliente;
        public Editar_Cliente(int idCliente)
        {
            InitializeComponent();

            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.idCliente = idCliente;

            llenarCampos();
        }

        public void llenarCampos()
        {
            Conection con = new Conection();
            string[] cliente_info_i = con.hallar_Cliente_info("V_Cliente_info", this.idCliente);
            string[] cliente_estad = con.hallar_Cliente_estad("Cliente_estadisticas",this.idCliente);

            MessageBox.Show("" + cliente_estad[1]);

            this.textBox1.Text = cliente_info_i[0].ToString();
            this.textBox2.Text = cliente_info_i[1].ToString();
            this.textBox3.Text = cliente_info_i[2].ToString();
            this.textBox4.Text = cliente_info_i[3].ToString();
            this.textBox5.Text = cliente_info_i[4];
            this.textBox6.Text = cliente_estad[1];
            this.textBox7.Text = cliente_info_i[5].ToString();
            this.textBox8.Text = cliente_info_i[6].ToString();
        }

        private void button_editar_Cliente_Click(object sender, EventArgs e)
        {
            Conection con = new Conection();
            if (con.actualizar_Cliente_info(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text,
                this.textBox4.Text, this.textBox5.Text, this.textBox7.Text, this.textBox8.Text) ||
                con.actualizar_Cliente_estad(this.textBox1.Text, this.textBox6.Text)) {
                MessageBox.Show("Registro editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido editar el registro!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void button_Cancelar_editar_Cliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
