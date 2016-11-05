using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMantenedorMedicamento
{
    public partial class FormMedicamento : Form
    {
        public FormMedicamento()
        {
            InitializeComponent();
        }

        private void FormMedicamento_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (FormMenu   .alumnos[i].rut == 0)
                    {
                        Form1.alumnos[i].rut = Convert.ToInt32(txtRut.Text);
                        Form1.alumnos[i].nom = txtNombre.Text;
                        Form1.alumnos[i].tel = txtTelefono.Text;
                        break;
                    }
                }
                txtNombre.Clear();
                txtRut.Clear();
                txtTelefono.Clear();
                llenarLista();
                MessageBox.Show("El registro del alumno ha sido ingresado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, por favor revisa la información");
            }
        }


    }
}
