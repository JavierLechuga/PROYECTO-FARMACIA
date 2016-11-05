using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormMainMenu
{
    public partial class Login : Form
    {
        public static string currentUser = String.Empty;
        public static string rutUser = String.Empty;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            string linea;
            string[] arr;
            string conectado = "no";
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            string tempurl = Application.StartupPath + "\\archivos\\usuarios\\usuarios.txt";

            if (File.Exists(tempurl))
            {
                StreamReader sr = new StreamReader(tempurl);

                while (sr.EndOfStream == false)
                {
                    linea = sr.ReadLine();
                    arr = linea.Split(';');
                    if (arr[0].Equals(user))
                    {
                        if (arr[5].Equals(password))
                        {
                            MessageBox.Show("Bienvenido" + " " + user);
                            currentUser = arr[1].ToString();
                            rutUser = arr[0].ToString();
                            FormMenu menu = new FormMenu();
                            menu.Show();
                            conectado = "si";
                            if (checkBox1.Checked == false)
                            {
                                txtPassword.Clear();
                                txtUsuario.Clear();
                                checkBox1.Checked = false;
                            }  
                        }
                        else
                        {
                            MessageBox.Show("Las credenciales ingresadas no coinciden con nuestros registros");
                        }
                    }
                }
                if (conectado.Equals("no"))
                {
                    MessageBox.Show("Las credenciales ingresadas no coinciden con nuestros registros");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
