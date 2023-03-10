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
    public partial class Agregar_Plan : Form
    {
        public Agregar_Plan()
        {
            InitializeComponent();
        }

        private void button_agregar_Plan_Click(object sender, EventArgs e)
        {
            Conection cno= new Conection();
            cno.AgregarPlan(int.Parse(textBox1.Text),textBox2.Text,int.Parse(textBox3.Text),this.textBox4.Text);
            MessageBox.Show("Registro agregado con éxito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Menu menu = new Menu();
            menu.Show(this);
            this.Close();
        }

        private void button_Cancelar_agregar_Plan_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
