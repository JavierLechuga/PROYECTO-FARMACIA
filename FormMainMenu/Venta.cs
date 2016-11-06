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
        public XDocument xmlcliente = XDocument.Load(Application.StartupPath + "\\archivos\\clientes.xml");
        public XDocument xmlmedicamento = XDocument.Load(Application.StartupPath + "\\archivos\\medicamentos.xml");
        public string numeroventas = Application.StartupPath + "\\archivos\\numeroventa.xml";
        public int numeroventaint = 5;

        public Venta()
        {
            InitializeComponent();
        }

        public void BindGrid()
        {
            try
            {
                XmlReader xmlFile;
                xmlFile = XmlReader.Create(Application.StartupPath + "\\archivos\\medicamentos.xml", new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
                dgvMedicamentos.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }  

        private void Venta_Load(object sender, EventArgs e)
        {
            BindGrid();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNombreUsuario.Text = Login.currentUser;
            lblRutUsuario.Text = Login.rutUser;

            XElement numeroventa = xmldoc.Descendants("NumeroVenta").FirstOrDefault();
            lblNumeroVenta.Text = numeroventa.Element("numero").Value;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            #region Numero Ventas
            try
            {
                XElement numeroventa = xmldoc.Descendants("NumeroVenta").FirstOrDefault();
                if (numeroventa != null)
                {
                    numeroventaint = Convert.ToInt32(numeroventa.Element("numero").Value);
                    numeroventa.Remove();
                    numeroventaint = numeroventaint + 1;                
                    numeroventa.Element("numero").Value = Convert.ToString(numeroventaint);
                    xmldoc.Root.Add(numeroventa);
                    xmldoc.Save(Application.StartupPath + "\\archivos\\numeroventa.xml");
                    MessageBox.Show("La venta se ha realizado con éxito.");

                    lblNumeroVenta.Text = numeroventaint.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema." + Convert.ToString(ex));
            }
            #endregion
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            XElement cli = xmlcliente.Descendants("Cliente").FirstOrDefault(p => p.Element("id").Value == txtRutCliente.Text);
            if (cli != null)
            {
                lblNombreCliente.Visible = true;
                lblNombreCliente.Text = Convert.ToString(cli.Element("nombre").Value);
            }
            else
            {
                MessageBox.Show("El cliente no se encuentra en los registros, revise el rut e intentelo de nuevo.");
            }
        }

        private void btnBuscarMedicamento_Click(object sender, EventArgs e)
        {
            if (txtCodigoMedicamento.Text != String.Empty)
            {
                XElement med = xmlmedicamento.Descendants("Medicamento").FirstOrDefault(p => p.Element("id").Value == txtCodigoMedicamento.Text);
            if (med != null)
            {
                txtNombreMedicamento.Text = Convert.ToString(med.Element("nombre").Value);
                lblPrecio.Visible = true;
                lblPrecio.Text = Convert.ToString(med.Element("precio").Value);
                lblReceta.Visible = true;
                lblReceta.Text = Convert.ToString(med.Element("receta").Value);
                lblStock.Visible = true;
                lblStock.Text = Convert.ToString(med.Element("stock").Value);
            }
            else
            {
                MessageBox.Show("El medicamento no se encuentra en los registros, revise el código e intentelo de nuevo.");
            }
            }
            else
            {
                if (txtNombreMedicamento.Text != String.Empty)
                {
                    XElement med = xmlmedicamento.Descendants("Medicamento").FirstOrDefault(p => p.Element("nombre").Value == txtNombreMedicamento.Text);
                    if (med != null)
                    {
                        txtCodigoMedicamento.Text = Convert.ToString(med.Element("id").Value);
                        lblPrecio.Visible = true;
                        lblPrecio.Text = Convert.ToString(med.Element("precio").Value);
                        lblReceta.Visible = true;
                        lblReceta.Text = Convert.ToString(med.Element("receta").Value);
                        lblStock.Visible = true;
                        lblStock.Text = Convert.ToString(med.Element("stock").Value);
                    }
                    else
                    {
                        MessageBox.Show("El medicamento no se encuentra en los registros, revise el código e intentelo de nuevo.");
                    }
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
