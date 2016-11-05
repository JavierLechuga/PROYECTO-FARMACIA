using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainMenu
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNombreUsuario.Text = Login.currentUser;
            lblRutUsuario.Text = Login.rutUser;
            int venta = 0;

        }
    }
}
