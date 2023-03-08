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
            Conection con= new Conection();
            con.AgregarCliente(int.Parse(this.textBox_idcliente.Text),int.Parse(textBox2.Text),textBox3.Text,textBox4.Text,textBox6.Text,textBox7.Text,textBox8.Text);
            
            MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Menu menu = new Menu();
            menu.Show(this);
            this.Close();
        }

        private void button_Cancelar_agregar_Cliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
