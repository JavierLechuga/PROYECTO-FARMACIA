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
    public partial class FormCliente : Form
    {
        public XDocument xmldoc = XDocument.Load(Application.StartupPath + "\\archivos\\clientes.xml");
        public string tempurl = Application.StartupPath + "\\archivos\\clientes.xml";
        public string[,] ciu_com = new string[6, 3];

        public FormCliente()
        {
            InitializeComponent();
        }

        public void llenarLista()
        {
            this.lstClientes.DataSource = XDocument.Load(Application.StartupPath + "\\archivos\\clientes.xml").Descendants().Where(cli => cli.Name == "id").Select(cli => cli.Value).ToList();
        }

        private void habilitar()
        {
            txtRutCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            txtDireccionCliente.Enabled = true;
            cboCiudad.Enabled = true;
            cboComuna.Enabled = true;
            cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; 
        }

        private void limpia()
        {
            txtRutCliente.Clear();
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            cboCiudad.SelectedIndex = -1;
            cboComuna.SelectedIndex = -1;
            cboComuna.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habilitar();
            try
            {

                string nombreCliente = txtNombreCliente.Text;
                string rutCliente = txtRutCliente.Text;
                string direccionCliente = txtDireccionCliente.Text;
                string ciudad = String.Empty;
                string comuna = String.Empty;



                if (cboCiudad.SelectedItem != null) {
                  ciudad = cboCiudad.SelectedItem.ToString();
                  comuna = cboComuna.SelectedItem.ToString();
                }
                

                if (btnAgregar.Text == "Agregar")
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnAgregar.Text = "Guardar";
                    lstClientes.Enabled = false;
                    gprDatos.Enabled = true;
                    txtRutCliente.Focus();
                    limpia();
                }
                else
                {
                    if (!(txtRutCliente.Text.Equals(String.Empty)))
                    {
                        XElement cli = new XElement("Cliente",
                        new XElement("id", rutCliente),
                        new XElement("nombre", nombreCliente),
                        new XElement("direccion", direccionCliente),
                        new XElement("ciudad", ciudad),
                        new XElement("comuna", comuna));
                        xmldoc.Root.Add(cli);
                        xmldoc.Save(Application.StartupPath + "\\archivos\\clientes.xml");
                        btnAgregar.Text = "Agregar";
                        MessageBox.Show("se guardo el registro");
                        limpia();
                        lstClientes.Enabled = true;
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                

                XElement cli = xmldoc.Descendants("Cliente").FirstOrDefault(p => p.Element("id").Value == lstClientes.SelectedItem.ToString());
                if (cli != null)
                {
                    txtRutCliente.Text = cli.Element("id").Value;
                    txtNombreCliente.Text = cli.Element("nombre").Value;
                    txtDireccionCliente.Text = cli.Element("direccion").Value;
                    cboCiudad.SelectedItem = cli.Element("ciudad").Value;
                    cboComuna.SelectedItem = cli.Element("comuna").Value;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un código de la lista para cargar la información.");
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
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
            this.lstClientes.DataSource = XDocument.Load(Application.StartupPath + "\\archivos\\clientes.xml").Descendants().Where(cli => cli.Name == "id").Select(cli => cli.Value).ToList();
            limpia();
            Bloquear();

        }

        private void Bloquear() {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtRutCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtDireccionCliente.Enabled = false;
            cboCiudad.Enabled = false;
            cboComuna.Enabled = false;            
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text;
            string rutCliente = txtRutCliente.Text;
            string direccionCliente = txtDireccionCliente.Text;
            string ciudad = cboCiudad.SelectedItem.ToString();
            string comuna = cboComuna.SelectedItem.ToString();

            try
            {
                if (btnModificar.Text == "Modificar")
                {
                    btnModificar.Text = "Actualizar";
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = false;
                    lstClientes.Enabled = false;
                    gprDatos.Enabled = true;
                    txtRutCliente.Focus();
                    habilitar();
                }
                else
                {
                    XElement emp = xmldoc.Descendants("Cliente").FirstOrDefault(p => p.Element("id").Value == txtRutCliente.Text);
                    if (emp != null)
                    {
                        emp.Remove();
                        emp.Element("id").Value = txtRutCliente.Text;
                        emp.Element("nombre").Value = txtNombreCliente.Text;
                        emp.Element("direccion").Value = txtDireccionCliente.Text;
                        emp.Element("ciudad").Value = cboCiudad.SelectedItem.ToString();
                        emp.Element("comuna").Value = cboComuna.SelectedItem.ToString();
                        xmldoc.Root.Add(emp);
                        xmldoc.Save(tempurl);
                        MessageBox.Show("se modificó el registro");
                        limpia();
                        Bloquear();
                        lstClientes.Enabled = true;
                        llenarLista();
                    }
                    Bloquear();
                    btnAgregar.Enabled = true;
                    btnModificar.Text = "Modificar";
                    lstClientes.Enabled = true;                 
                    gprDatos.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema." + Convert.ToString(ex));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                XElement cli = xmldoc.Descendants("Cliente").FirstOrDefault(p => p.Element("id").Value == txtRutCliente.Text);
                if (cli != null)
                {
                    cli.Remove();
                    xmldoc.Save(tempurl);
                    llenarLista();
                    limpia();
                    habilitar();
                }
                Bloquear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema." + Convert.ToString(ex));
            }
        }


        

       
    }
}
