using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMosca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AtualizarLista()
        {
            
        }
        private void label1_Click(object sender, EventArgs e)  
        {
            this.Hide();
            var cadastro = new Cadastrar(this);
            cadastro.Show();
        }

        private void label3_Click(object sender, EventArgs e)  
        {
            this.Hide();
            var editar = new Editar(this);
            editar.Show();
        }

        private void label2_Click(object sender, EventArgs e) 
        {
            this.Hide();
            var busca = new BuscarPers(this);
            busca.Show();
        }

        private void lblSaida_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}