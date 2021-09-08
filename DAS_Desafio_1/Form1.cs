using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Desafio_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string[] users = { "Diego", "Antonio" };
        string[] password =  { "123", "321" };

        //Definimos variable de acesos
        int type = 0; //1 peliculas, 2 Libros, 3 Lenguajes de programación

        private void btnEntrar_Login_Click(object sender, EventArgs e)
        {
            int intentos = 0;
            string name = txtName_Login.Text;
            string pass = txtPass_Login.Text;

            int nameElement = Array.IndexOf(users, name);
            int passElement = Array.IndexOf(password, pass);

            if (nameElement == -1)
            {
                MessageBox.Show("Usuario Incorrecto");
                intentos += 1;
            }
            else if(passElement == -1)
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
            else if (name == users[nameElement] && pass == password[passElement])
            {
                this.Hide(); //Ocultamos la ventana de login
                Dentro dentro = new Dentro();  //Instaciamos la ventana de "Dentro"
                dentro.Show(); //Mostramos la nueva ventana
                type = 1;
            }
            else
            {
                MessageBox.Show("Error inesperado");
                Application.Exit();
            }

        }
    }
}
