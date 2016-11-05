﻿using System;
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
    public partial class FormMedicamento : Form
    {
        public XDocument xmldoc = XDocument.Load(Application.StartupPath + "\\archivos\\medicamentos.xml");
        public string tempurl = Application.StartupPath + "\\archivos\\medicamentos.xml";

        public FormMedicamento()
        {
            InitializeComponent();
        }

        public void llenarLista()
        {
            this.lstMedicamentos.DataSource = XDocument.Load(Application.StartupPath + "\\archivos\\medicamentos.xml").Descendants().Where(med => med.Name == "id").Select(med => med.Value).ToList();
        }

        private void limpia()
        {
            txtCodigoMedicamento.Clear();
            txtNombreMedicamento.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            checkReceta.Checked = false;

        }

        private void habilitar()
        {

            txtCodigoMedicamento.Enabled = true;
            txtNombreMedicamento.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            checkReceta.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lstMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                XElement emp = xmldoc.Descendants("Medicamento").FirstOrDefault(p => p.Element("id").Value == lstMedicamentos.SelectedItem.ToString());
                if (emp != null)
                {
                    txtCodigoMedicamento.Text = emp.Element("id").Value;
                    txtNombreMedicamento.Text = emp.Element("nombre").Value;
                    txtPrecio.Text = emp.Element("precio").Value;
                    txtStock.Text = emp.Element("stock").Value;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un código de la lista para cargar la información.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreMedicamento = txtNombreMedicamento.Text;
            string codigoMedicamento = txtCodigoMedicamento.Text;
            string precioMedicamento = txtPrecio.Text;
            string stockMedicamento = txtStock.Text;

            habilitar();
            try
            {

                if (btnAgregar.Text == "Agregar")
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnAgregar.Text = "Guardar";
                    lstMedicamentos.Enabled = false;
                    gprDatos.Enabled = true;
                    txtCodigoMedicamento.Focus();
                    limpia();
                }
                else
                {
                    if (!(txtCodigoMedicamento.Text.Equals(String.Empty)))
                    {
                        XElement med = new XElement("Medicamento",
                        new XElement("id", codigoMedicamento),
                        new XElement("nombre", nombreMedicamento),
                        new XElement("precio", stockMedicamento),
                        new XElement("stock", stockMedicamento));
                        xmldoc.Root.Add(med);
                        xmldoc.Save(Application.StartupPath + "\\archivos\\medicamentos.xml");
                        btnAgregar.Text = "Agregar";
                        MessageBox.Show("se guardo el registro");
                        limpia();
                        lstMedicamentos.Enabled = true;
                        llenarLista();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormMedicamento_Load(object sender, EventArgs e)
        {
            this.lstMedicamentos.DataSource = XDocument.Load(Application.StartupPath + "\\archivos\\medicamentos.xml").Descendants().Where(med => med.Name == "id").Select(med => med.Value).ToList();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreMedicamento = txtNombreMedicamento.Text;
            string codigoMedicamento = txtCodigoMedicamento.Text;
            string precioMedicamento = txtPrecio.Text;
            string stockMedicamento = txtStock.Text;

            habilitar();
            try
            {
                if (btnModificar.Text == "Modificar")
                {
                    btnModificar.Text = "Actualizar";
                    btnEliminar.Enabled = false;
                    btnAgregar.Enabled = false;
                    lstMedicamentos.Enabled = false;
                    gprDatos.Enabled = true;
                    txtCodigoMedicamento.Focus();
                }
                else
                {
                    XElement emp = xmldoc.Descendants("Medicamento").FirstOrDefault(p => p.Element("id").Value == txtCodigoMedicamento.Text);
                    if (emp != null)
                    {
                        emp.Remove();
                        emp.Element("id").Value = txtCodigoMedicamento.Text;
                        emp.Element("nombre").Value = txtNombreMedicamento.Text;
                        emp.Element("precio").Value = txtPrecio.Text;
                        emp.Element("stock").Value = txtStock.Text;
                        xmldoc.Root.Add(emp);
                        xmldoc.Save(tempurl);
                        MessageBox.Show("se modificó el registro");
                        limpia();
                        lstMedicamentos.Enabled = true;
                        llenarLista();
                    }
                    limpia();
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnModificar.Text = "Modificar";
                    lstMedicamentos.Enabled = true;
                    gprDatos.Enabled = true;
                    habilitar();
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
                XElement emp = xmldoc.Descendants("Medicamento").FirstOrDefault(p => p.Element("id").Value == txtCodigoMedicamento.Text);
                if (emp != null)
                {
                    emp.Remove();
                    xmldoc.Save(tempurl);
                    llenarLista();
                    limpia();
                    habilitar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema." + Convert.ToString(ex));
            }

        }
    }
}
