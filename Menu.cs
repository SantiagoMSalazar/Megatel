using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megatel
{
    public partial class Menu : Form
    {
        Conection con = new Conection();
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label_busqueda.Text = "¡Solo se encuenta 1 agencia!";
      

            DataTable dt = con.consultar_Cliente("Cliente_info_02");

            llenarTablaClienteInfo();
            llenarTablaAgencia();
            llenarTablaPlan();
        }

        public void llenarTablaClienteInfo()
        {
            this.dataGridView_Cliente.Rows.Clear();
            DataTable dt = con.consultar_Cliente("V_Cliente_info");

            foreach (DataRow row in dt.Rows)
            {
                // dgvClientes
                this.dataGridView_Cliente.Rows.Add(row["Column_idCliente"], row["Column_idAgenciaCliente"],
                    row["Column_CC"], row["Column_NombreCliente"], row["Column_ApellidoCliente"], row["Column_Celular"],
                    row["Column_email"]);
            }
        }

        public void llenarTablaAgencia()
        {
            this.dataGridView_Agencia.Rows.Clear();
            DataTable dt = con.consultar_Agencia("V_Agencia");

            foreach (DataRow row in dt.Rows)
            {
                // dgvClientes
                this.dataGridView_Agencia.Rows.Add(row["Column_idAgencia"], row["Column_Direccion"],
                    row["Column_Ciudad"]);
            }
        }

        public void llenarTablaPlan()
        {
            this.dataGridView_Plan.Rows.Clear();
            DataTable dt = con.consultar_Plan("Plan_M");

            foreach (DataRow row in dt.Rows)
            {
                // dgvClientes
                this.dataGridView_Plan.Rows.Add(row["Column_idPlan"], row["Column_nombrePlan"],
                    row["Column_cantMegas"], row["Column_Precio"]);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Menu menu =  new Menu();
            this.Close();

            menu.Show();
        }

        private void dataGridView_Agencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Agencia.Columns[e.ColumnIndex].Name == "Column_editar_Agencia" && e.RowIndex >= 0)
            {
                Editar_Agencia ea = new Editar_Agencia();
                ea.StartPosition = FormStartPosition.CenterParent;
                ea.ShowDialog();
            }

            if (dataGridView_Agencia.Columns[e.ColumnIndex].Name == "Column_eliminar_Agencia" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView_Plan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Plan.Columns[e.ColumnIndex].Name == "Column_editar_Plan" && e.RowIndex >= 0)
            {
                Editar_Plan ep = new Editar_Plan();
                ep.StartPosition = FormStartPosition.CenterParent;
                ep.ShowDialog();
            }

            if (dataGridView_Plan.Columns[e.ColumnIndex].Name == "Column_eliminar_Plan" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Cliente.Columns[e.ColumnIndex].Name == "Column_editar_Cliente" && e.RowIndex >= 0)
            {
                Editar_Cliente ec = new Editar_Cliente();
                ec.StartPosition = FormStartPosition.CenterParent;
                ec.ShowDialog();
            }

            if (dataGridView_Cliente.Columns[e.ColumnIndex].Name == "Column_eliminar_Cliente" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView_Contrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Contrato.Columns[e.ColumnIndex].Name == "Column_editar_Contrato" && e.RowIndex >= 0)
            {
                Editar_Contrato econ = new Editar_Contrato();
                econ.StartPosition = FormStartPosition.CenterParent;
                econ.ShowDialog();
            }

            if (dataGridView_Contrato.Columns[e.ColumnIndex].Name == "Column_eliminar_Contrato" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView_Empleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Empleado.Columns[e.ColumnIndex].Name == "Column_editar_Empleado" && e.RowIndex >= 0)
            {
                Editar_Empleado eemp = new Editar_Empleado();
                eemp.StartPosition = FormStartPosition.CenterParent;
                eemp.ShowDialog();
            }

            if (dataGridView_Empleado.Columns[e.ColumnIndex].Name == "Column_eliminar_Empleado" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            switch (tabControl_Tablas_i.SelectedIndex)
            {
                case 0:
                    Agregar_Agencia aa = new Agregar_Agencia();
                    aa.StartPosition = FormStartPosition.CenterParent;
                    aa.ShowDialog();
                    break;
                case 1:
                    Agregar_Plan ap = new Agregar_Plan();
                    ap.StartPosition = FormStartPosition.CenterParent;
                    ap.ShowDialog();
                    break;
                case 2:
                    Agregar_Cliente ac = new Agregar_Cliente();
                    ac.StartPosition = FormStartPosition.CenterParent;
                    ac.ShowDialog();
                    break;
                case 3:
                    Agregar_Contrato acon = new Agregar_Contrato();
                    acon.StartPosition = FormStartPosition.CenterParent;
                    acon.ShowDialog();
                    break;
                case 4:
                    Agregar_Empleado aemp = new Agregar_Empleado();
                    aemp.ShowDialog();
                    aemp.StartPosition = FormStartPosition.CenterParent;
                    break;
                case 5:
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Agregue un cliente desde la pestaña \"Cliente\"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void tabControl_Tablas_i_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl_Tablas_i.SelectedIndex) {
                case 0:
                    label_busqueda.Text = "¡Solo se encuenta 1 agencia!";
                    break;
                case 1:
                    label_busqueda.Text = "Ingrese un nombre de plan: ";
                    break;
                case 2:
                    label_busqueda.Text = "Ingrese una cédula de cliente: ";
                    break;
                case 3:
                    label_busqueda.Text = "Ingrese un id de contrato: ";
                    break;
                case 4:
                    label_busqueda.Text = "Ingrese un apellido de empleado: ";
                    break;
                case 5:
                    label_busqueda.Text = "Ingrese un id de cliente: ";
                    break;
                default:
                    break;
            }
        }

        private void textBox_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabControl_Tablas_i.SelectedIndex)
            {
                case 0:
                    
                    break;
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                default:
                    break;
            }
        }
    }
}
