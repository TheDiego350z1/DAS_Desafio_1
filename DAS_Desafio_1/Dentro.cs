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
    public partial class Dentro : Form
    {
        public Dentro()
        {
            InitializeComponent();
        }

        private void Dentro_Load(object sender, EventArgs e)
        {
            
        }

        private void textVar_Dentro_TextChanged(object sender, EventArgs e)
        {
            textVar_Dentro.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number;
            number = textVar_Dentro.Text;

            MessageBox.Show(number);
            label1.Text = number;
        }
    }
}
