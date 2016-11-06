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
    public partial class FormVendedor : Form
    {
        public XDocument xmldoc = XDocument.Load(Application.StartupPath + "\\archivos\\vendedores.xml");
        public string tempurl = Application.StartupPath + "\\archivos\\vendedores.xml";
        public string[,] ciu_com = new string[6, 3];

        public FormVendedor()
        {
            InitializeComponent();
        }

        public void llenarLista()
        {
            this.lstVendedores.DataSource = XDocument.Load(Application.StartupPath + "\\archivos\\vendedores.xml").Descendants().Where(ven => ven.Name == "id").Select(ven => ven.Value).ToList();
        }

        private void Bloquear()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtRutVendedor.Enabled = false;
            txtNombreVendedor.Enabled = false;
            txtDireccion.Enabled = false;
            cboCiudad.Enabled = false;
            cboComuna.Enabled = false;
            txtContraseña.Enabled = false;
        }

        private void habilitar()
        {
            txtRutVendedor.Enabled = true;
            txtNombreVendedor.Enabled = true;
            txtDireccion.Enabled = true;
            cboCiudad.Enabled = true;
            cboComuna.Enabled = true;
            cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtContraseña.Enabled = true;
        }

        private void limpia()
        {
            txtRutVendedor.Clear();
            txtNombreVendedor.Clear();
            txtDireccion.Clear();
            txtContraseña.Clear();
            cboCiudad.SelectedIndex = -1;
            cboComuna.SelectedIndex = -1;
            cboComuna.Text = "";
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            #region Almacenar Ciudades y Comunas
            //Se almacenan las Ciudades y sus respectivas Comunas en la matriz ciu_com
            ciu_com[0, 0] = "Santiago";
            ciu_com[0, 1] = "Rancagua";
            ciu_com[0, 2] = "Talca";
            ciu_com[1, 0] = "La Florida";
            ciu_com[2, 0] = "La Cisterna";
            ciu_com[3, 0] = "Nuñoa";
            ciu_com[4, 0] = "Peñalolen";
            ciu_com[5, 0] = "San Bernardo";
            ciu_com[1, 1] = "Doñigue";
            ciu_com[2, 1] = "Machali";
            ciu_com[3, 1] = "Lo miranda";
            ciu_com[4, 1] = "Las Cabras";
            ciu_com[5, 1] = "Graneros";
            ciu_com[1, 2] = "San Clemente";
            ciu_com[2, 2] = "Pelarco";
            ciu_com[3, 2] = "Pencahue";
            ciu_com[4, 2] = "Curepto";
            ciu_com[5, 2] = "Rio Claro";

            //Se recorre la matriz ciu_com para llenar el combobox Ciudad
            for (int i = 0; i < 3; i++)
            {
                cboCiudad.Items.Add(ciu_com[0, i]);


            }
            #endregion

            //Se llena el listbox clientes a partir de un DataSource generado con la información del archivo clientes.xml
            this.lstVendedores.DataSource = XDocument.Load(Application.StartupPath + "\\archivos\\vendedores.xml").Descendants().Where(ven => ven.Name == "id").Select(ven => ven.Value).ToList();
            limpia();
            Bloquear();
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboComuna.Items.Clear();
            cboComuna.Text = "";
            cboComuna.SelectedIndex = -1;

            for (int i = 0; i < 3; i++)
            {
                if (cboCiudad.SelectedItem == ciu_com[0, i])
                {
                    for (int j = 1; j < 6; j++)
                    {
                        cboComuna.Items.Add(ciu_com[j, i]);
                    }

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habilitar();
            try
            {

                string nombreVendedor = txtNombreVendedor.Text;
                string rutVendedor = txtRutVendedor.Text;
                string direccionVendedor = txtDireccion.Text;
                string ciudad = String.Empty;
                string comuna = String.Empty;
                string contraseña = txtContraseña.Text;



                if (cboCiudad.SelectedItem != null)
                {
                    ciudad = cboCiudad.SelectedItem.ToString();
                    comuna = cboComuna.SelectedItem.ToString();
                }


                if (btnAgregar.Text == "Agregar")
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnAgregar.Text = "Guardar";
                    lstVendedores.Enabled = false;
                    gprDatos.Enabled = true;
                    txtRutVendedor.Focus();
                    limpia();
                }
                else
                {
                    if (!(txtRutVendedor.Text.Equals(String.Empty)))
                    {
                        XElement ven = new XElement("Vendedor",
                        new XElement("id", rutVendedor),
                        new XElement("nombre", nombreVendedor),
                        new XElement("direccion", direccionVendedor),
                        new XElement("ciudad", ciudad),
                        new XElement("comuna", comuna),
                        new XElement("contrasena", contraseña));
                        xmldoc.Root.Add(ven);
                        xmldoc.Save(tempurl);
                        btnAgregar.Text = "Agregar";
                        MessageBox.Show("se guardo el registro");
                        limpia();
                        lstVendedores.Enabled = true;
                        llenarLista();
                        Bloquear();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lstVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;


                XElement ven = xmldoc.Descendants("Vendedor").FirstOrDefault(p => p.Element("id").Value == lstVendedores.SelectedItem.ToString());
                if (ven != null)
                {
                    txtRutVendedor.Text = ven.Element("id").Value;
                    txtNombreVendedor.Text = ven.Element("nombre").Value;
                    txtDireccion.Text = ven.Element("direccion").Value;
                    txtContraseña.Text = ven.Element("contrasena").Value;
                    cboCiudad.SelectedItem = ven.Element("ciudad").Value;
                    cboComuna.SelectedItem = ven.Element("comuna").Value;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un código de la lista para cargar la información.");
            }
        }
    }
}