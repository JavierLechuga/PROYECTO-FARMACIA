using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace FormMainMenu
{
    public partial class Venta : Form
    {
        public XDocument xmldoc = XDocument.Load(Application.StartupPath + "\\archivos\\numeroventa.xml");
        public string numeroventas = Application.StartupPath + "\\archivos\\numeroventa.xml";

        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNombreUsuario.Text = Login.currentUser;
            lblRutUsuario.Text = Login.rutUser;
            int numeroventaint = 0;

            XElement numeroventa = xmldoc.Descendants("NumeroVenta").FirstOrDefault(p => p.Element("numero").Value == numeroventaint.ToString());
            if (numeroventa != null)
            {
                lblNumeroVenta.Text = numeroventa.Element("numero").Value;
            }


        }
    }
}
