namespace Megatel
{
    partial class Agregar_Contrato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6_idCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5_idPlan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4_idContrato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Cancelar_agregar_Contrato = new System.Windows.Forms.Button();
            this.button_agregar_Contrato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.com_Agencia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(214, 154);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Min. Permanencia";
            // 
            // textBox6_idCliente
            // 
            this.textBox6_idCliente.Location = new System.Drawing.Point(214, 80);
            this.textBox6_idCliente.Name = "textBox6_idCliente";
            this.textBox6_idCliente.Size = new System.Drawing.Size(100, 20);
            this.textBox6_idCliente.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "id Cliente";
            // 
            // textBox5_idPlan
            // 
            this.textBox5_idPlan.Location = new System.Drawing.Point(214, 119);
            this.textBox5_idPlan.Name = "textBox5_idPlan";
            this.textBox5_idPlan.Size = new System.Drawing.Size(100, 20);
            this.textBox5_idPlan.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "id Plan";
            // 
            // textBox4_idContrato
            // 
            this.textBox4_idContrato.Location = new System.Drawing.Point(214, 40);
            this.textBox4_idContrato.Name = "textBox4_idContrato";
            this.textBox4_idContrato.Size = new System.Drawing.Size(100, 20);
            this.textBox4_idContrato.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "id Contrato";
            // 
            // button_Cancelar_agregar_Contrato
            // 
            this.button_Cancelar_agregar_Contrato.Location = new System.Drawing.Point(214, 282);
            this.button_Cancelar_agregar_Contrato.Name = "button_Cancelar_agregar_Contrato";
            this.button_Cancelar_agregar_Contrato.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar_agregar_Contrato.TabIndex = 49;
            this.button_Cancelar_agregar_Contrato.Text = "Cancelar";
            this.button_Cancelar_agregar_Contrato.UseVisualStyleBackColor = true;
            this.button_Cancelar_agregar_Contrato.Click += new System.EventHandler(this.button_Cancelar_agregar_Contrato_Click);
            // 
            // button_agregar_Contrato
            // 
            this.button_agregar_Contrato.Location = new System.Drawing.Point(109, 282);
            this.button_agregar_Contrato.Name = "button_agregar_Contrato";
            this.button_agregar_Contrato.Size = new System.Drawing.Size(75, 23);
            this.button_agregar_Contrato.TabIndex = 48;
            this.button_agregar_Contrato.Text = "Agregar";
            this.button_agregar_Contrato.UseVisualStyleBackColor = true;
            this.button_agregar_Contrato.Click += new System.EventHandler(this.button_agregar_Contrato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Agencia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // com_Agencia
            // 
            this.com_Agencia.FormattingEnabled = true;
            this.com_Agencia.Items.AddRange(new object[] {
            "El Ángel",
            "Tulcán"});
            this.com_Agencia.Location = new System.Drawing.Point(214, 218);
            this.com_Agencia.Name = "com_Agencia";
            this.com_Agencia.Size = new System.Drawing.Size(121, 21);
            this.com_Agencia.TabIndex = 59;
            this.com_Agencia.Text = "Seleccione...";
            // 
            // Agregar_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 393);
            this.Controls.Add(this.com_Agencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6_idCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5_idPlan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4_idContrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Cancelar_agregar_Contrato);
            this.Controls.Add(this.button_agregar_Contrato);
            this.Name = "Agregar_Contrato";
            this.Text = "Agregar Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6_idCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5_idPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4_idContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Cancelar_agregar_Contrato;
        private System.Windows.Forms.Button button_agregar_Contrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_Agencia;
    }
}