namespace FormMantenedorMedicamento
{
    partial class FormMedicamento
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoMedicamento = new System.Windows.Forms.TextBox();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.checkReceta = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.btnModificarMedicamento = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarMedicamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Receta retenida";
            // 
            // txtCodigoMedicamento
            // 
            this.txtCodigoMedicamento.Location = new System.Drawing.Point(68, 35);
            this.txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            this.txtCodigoMedicamento.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoMedicamento.TabIndex = 1;
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(68, 77);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(120, 20);
            this.txtNombreMedicamento.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(68, 121);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(68, 170);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 20);
            this.txtStock.TabIndex = 1;
            // 
            // checkReceta
            // 
            this.checkReceta.AutoSize = true;
            this.checkReceta.Location = new System.Drawing.Point(111, 226);
            this.checkReceta.Name = "checkReceta";
            this.checkReceta.Size = new System.Drawing.Size(15, 14);
            this.checkReceta.TabIndex = 2;
            this.checkReceta.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(261, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 3;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(25, 296);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMedicamento.TabIndex = 4;
            this.btnAgregarMedicamento.Text = "AGREGAR";
            this.btnAgregarMedicamento.UseVisualStyleBackColor = true;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // btnModificarMedicamento
            // 
            this.btnModificarMedicamento.Location = new System.Drawing.Point(122, 296);
            this.btnModificarMedicamento.Name = "btnModificarMedicamento";
            this.btnModificarMedicamento.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMedicamento.TabIndex = 4;
            this.btnModificarMedicamento.Text = "MODIFICAR";
            this.btnModificarMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(306, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.Location = new System.Drawing.Point(216, 296);
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMedicamento.TabIndex = 4;
            this.btnEliminarMedicamento.Text = "ELIMINAR";
            this.btnEliminarMedicamento.UseVisualStyleBackColor = true;
            // 
            // FormMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 344);
            this.Controls.Add(this.btnEliminarMedicamento);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarMedicamento);
            this.Controls.Add(this.btnAgregarMedicamento);
            this.Controls.Add(this.listBox1);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMedicamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoMedicamento;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.CheckBox checkReceta;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.Button btnModificarMedicamento;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminarMedicamento;
    }
}

