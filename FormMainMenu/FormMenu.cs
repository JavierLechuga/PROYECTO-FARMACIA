using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace FormMainMenu
{
    public partial class FormMenu : Form
    {
        #region Arrays
        public static Medicamento[] medicamentos = new Medicamento[1000];
        
        
        #endregion

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            label1.Text = "Usuario: " + Login.currentUser;
        }

        #region Estructuras de Almacenamiento
		 
	
        public struct Medicamento {
            public int codigo_medicamento;
            public string nombre_medicamento;
            public int precio_medicamento;
            public int stock_medicamento;
            public string receta;
        }

        #endregion 

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicamento FormMedicamento = new FormMedicamento();
            FormMedicamento.Show();
          
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.Show();
        }



    }
}
