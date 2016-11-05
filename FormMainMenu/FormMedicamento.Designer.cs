namespace FormMainMenu
{
    partial class FormMedicamento
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
            this.lstMedicamentos = new System.Windows.Forms.ListBox();
            this.checkReceta = new System.Windows.Forms.CheckBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.txtCodigoMedicamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gprDatos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gprDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMedicamentos
            // 
            this.lstMedicamentos.FormattingEnabled = true;
            this.lstMedicamentos.Location = new System.Drawing.Point(256, 30);
            this.lstMedicamentos.Name = "lstMedicamentos";
            this.lstMedicamentos.Size = new System.Drawing.Size(120, 160);
            this.lstMedicamentos.TabIndex = 15;
            this.lstMedicamentos.SelectedIndexChanged += new System.EventHandler(this.lstMedicamentos_SelectedIndexChanged);
            // 
            // checkReceta
            // 
            this.checkReceta.AutoSize = true;
            this.checkReceta.Enabled = false;
            this.checkReceta.Location = new System.Drawing.Point(106, 221);
            this.checkReceta.Name = "checkReceta";
            this.checkReceta.Size = new System.Drawing.Size(15, 14);
            this.checkReceta.TabIndex = 14;
            this.checkReceta.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(63, 165);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 20);
            this.txtStock.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(63, 116);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Enabled = false;
            this.txtNombreMedicamento.Location = new System.Drawing.Point(63, 72);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(120, 20);
            this.txtNombreMedicamento.TabIndex = 12;
            // 
            // txtCodigoMedicamento
            // 
            this.txtCodigoMedicamento.Enabled = false;
            this.txtCodigoMedicamento.Location = new System.Drawing.Point(63, 30);
            this.txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            this.txtCodigoMedicamento.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoMedicamento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Receta retenida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código";
            // 
            // gprDatos
            // 
            this.gprDatos.Controls.Add(this.btnEliminar);
            this.gprDatos.Controls.Add(this.btnVolver);
            this.gprDatos.Controls.Add(this.btnModificar);
            this.gprDatos.Controls.Add(this.btnAgregar);
            this.gprDatos.Location = new System.Drawing.Point(3, 241);
            this.gprDatos.Name = "gprDatos";
            this.gprDatos.Size = new System.Drawing.Size(385, 100);
            this.gprDatos.TabIndex = 16;
            this.gprDatos.TabStop = false;
            this.gprDatos.Text = "groupBox1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(192, 54);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(297, 54);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(101, 54);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 344);
            this.Controls.Add(this.gprDatos);
            this.Controls.Add(this.lstMedicamentos);
            this.Controls.Add(this.checkReceta);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreMedicamento);
            this.Controls.Add(this.txtCodigoMedicamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMedicamento";
            this.Text = "FormMedicamento";
            this.Load += new System.EventHandler(this.FormMedicamento_Load);
            this.gprDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedicamentos;
        private System.Windows.Forms.CheckBox checkReceta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.TextBox txtCodigoMedicamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gprDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
    }
}