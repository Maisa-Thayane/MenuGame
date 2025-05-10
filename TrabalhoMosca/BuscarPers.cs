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
    public partial class BuscarPers : Form
    {
        private Form1 formPrincipal;

        public BuscarPers(Form1 form)
        {
            InitializeComponent();
            formPrincipal = form;
            AtualizarLista(PersonagemLista.ObterTodos());
        }

        private void AtualizarLista(IEnumerable<Personagem> listaPers)
        {
            lstResultados.Items.Clear();
            foreach (var pers in listaPers)
                lstResultados.Items.Add(pers.Nome);
        }
        private void LimparDetalhes()
        {
            lblResumo.Text = "";
            pbImagem.Image = null;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string termo = txtBusca.Text.Trim().ToLower();
            var encontrados = PersonagemLista
                .ObterTodos()
                .Where(personagem => personagem.Nome.ToLower().Contains(termo));

            AtualizarLista(encontrados);
            LimparDetalhes();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal.Show();
        }

        private void lstResultados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int idx = lstResultados.SelectedIndex;
            if (idx < 0) return;

            string termo = txtBusca.Text.Trim().ToLower();
            var filtrados = PersonagemLista
                .ObterTodos()
                .Where(personagem => personagem.Nome.ToLower().Contains(termo))
                .ToList();

            var selecionado = filtrados[idx];

            lblResumo.Text = selecionado.ExibirResumo();
            try
            {
                pbImagem.Image = Image.FromFile(selecionado.ImagemPath);
            }
            catch
            {
                pbImagem.Image = null;
            }
        }
    }
}