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
        //string type; //1 peliculas, 2 Libros, 3 Lenguajes de programación
        int intentos = 0; // intentos

        string datos;

        private void btnEntrar_Login_Click(object sender, EventArgs e)
        {
            string name = txtName_Login.Text;
            string pass = txtPass_Login.Text;

            int nameElement = Array.IndexOf(users, name);
            int passElement = Array.IndexOf(password, pass);

            if (intentos == 3)
            {
                MessageBox.Show("Ha llegado al número de intentos maximos");
                Application.Exit();
            }
            else if (nameElement == -1)
            {
                MessageBox.Show("Usuario Incorrecto");
                MessageBox.Show("Intentos: " + intentos);
                intentos++;
                txtName_Login.Clear();
                txtPass_Login.Clear();
            }
            else if(passElement == -1)
            {   
                MessageBox.Show("Contraseña Incorrecta");
                MessageBox.Show("Intentos: " + intentos);
                intentos++;
                txtName_Login.Clear();
                txtPass_Login.Clear();
            }
            else if (name == users[nameElement] && pass == password[passElement])
            {
                this.Hide(); //Ocultamos la ventana de login
                //Logica para mostrar las ventanas


                Dentro dentro = new Dentro();  //Instaciamos la ventana de "Dentro"
                dentro.Show(); //Mostramos la nueva ventana
                
            }
            else
            {
                MessageBox.Show("Error inesperado");
                Application.Exit();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema se cerrara");
            Application.Exit();
        }
    }
}
