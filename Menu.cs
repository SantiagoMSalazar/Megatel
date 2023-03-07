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
            llenarTablaContrato();
            llenarTablaEmpleado();
            llenarTablaClienteEstad();
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

        public void llenarTablaContrato()
        {
            this.dataGridView_Contrato.Rows.Clear();
            DataTable dt = con.consultar_Cliente("Contrato_02");

            foreach (DataRow row in dt.Rows)
            {
                // dgvClientes
                this.dataGridView_Cliente.Rows.Add(row["Column_idContrato"], row["Column_idCliente"],
                    row["Column_idPLan"], row["Column_fechaEmision"], row["Column_minPermanencia"], row["Column_idAgencia"]);
            }
        }

        public void llenarTablaEmpleado()
        {
            this.dataGridView_Contrato.Rows.Clear();
            DataTable dt = con.consultar_Cliente("Cliente_estadisticas");

            foreach (DataRow row in dt.Rows)
            {
                // dgvClientes
                this.dataGridView_Cliente.Rows.Add(row["Column_idEmpleado"], row["Column_idAgencia"],
                    row["Column_Nombre"], row["Column_Apellido"], row["Column_Direcion"], row["Column_fechaIngreso"],
                    row["Column_Titulo"], row["Column_Tipo"], row["Column_Salario"]);
            }
        }

        public void llenarTablaClienteEstad()
        {
            this.dataGridView_Contrato.Rows.Clear();
            DataTable dt = con.consultar_Cliente("Cliente_estadisticas");

            foreach (DataRow row in dt.Rows)
            {
                // dgvClientes
                this.dataGridView_Cliente.Rows.Add(row["Column_idCliente"], row["Column_direccion"]);
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
                    int idAgencia = Int32.Parse(this.dataGridView_Agencia.Rows[e.RowIndex].Cells["Column_idAgencia"].Value.ToString());

                    con.eliminar_Agencia("V_Agencia", idAgencia);

                    if (con.agencia_existe("V_Agencia", idAgencia))
                    {
                        MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
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
                    int idPlan = Int32.Parse(this.dataGridView_Agencia.Rows[e.RowIndex].Cells["Column_IdPlan"].Value.ToString());

                    con.eliminar_Agencia("Plan_M", idPlan);

                    if (con.agencia_existe("Plan_M", idPlan))
                    {
                        MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
                if (dataGridView_Plan.Columns[e.ColumnIndex].Name == "Column_eliminar_Plan" && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idCliente = Int32.Parse(this.dataGridView_Agencia.Rows[e.RowIndex].Cells["Column_idCliente"].Value.ToString());

                        con.eliminar_Agencia("Cliente_info_02", idCliente);

                        if (con.agencia_existe("Cliente_info_02", idCliente))
                        {
                            MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido eliminar el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
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
                    int idContrato = Int32.Parse(this.dataGridView_Agencia.Rows[e.RowIndex].Cells["Column_idContrato"].Value.ToString());

                    con.eliminar_Agencia("Contrato_02", idContrato);

                    if (con.agencia_existe("Contrato_02", idContrato))
                    {
                        MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
                    int idEmpleado = Int32.Parse(this.dataGridView_Agencia.Rows[e.RowIndex].Cells["Column_idEmpleado"].Value.ToString());

                    con.eliminar_Agencia("Empleado_02", idEmpleado);

                    if (con.agencia_existe("Empleado_02", idEmpleado))
                    {
                        MessageBox.Show("Registro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el registro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
