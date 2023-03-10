using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megatel
{
    public partial class Agregar_Empleado : Form
    {
        public Agregar_Empleado()
        {
            InitializeComponent();
        }

        private void button_agregar_Empleado_Click(object sender, EventArgs e)
        {
            Conection con=new Conection();
            con.AgregarEmpleado(int.Parse(this.textBox1.Text),int.Parse(this.textBox2.Text),this.textBox3.Text,this.textBox4.Text,this.textBox5.Text,this.textBox6.Text,this.textBox7.Text,this.textBox8.Text);
                MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();
            
        }

        private void button_Cancelar_agregar_Empleado_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
