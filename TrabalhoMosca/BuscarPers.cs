using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
            lblResumo.Text = string.Empty;
            pbImagem.Image = null;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string termo = txtBusca.Text.Trim().ToLower();
            IEnumerable<Personagem> encontrados = PersonagemLista
                .ObterTodos()
                .Where(p => p.Nome.ToLower().Contains(termo));

            AtualizarLista(encontrados);
            LimparDetalhes();
        }

        private void lstResultados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int idx = lstResultados.SelectedIndex;
            if (idx < 0) return;

            var filtrados = PersonagemLista
                .ObterTodos()
                .Where(p => p.Nome.ToLower().Contains(txtBusca.Text.Trim().ToLower()))
                .ToList();
            var selecionado = filtrados[idx];

            lblResumo.Text = selecionado.ExibirResumo();

            string projectDir = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            string resourcesSpritesDir = Path.Combine(projectDir, "Resources", "Sprites");
            string fullPath = Path.Combine(resourcesSpritesDir, selecionado.ImagemPath);
            txtImagemPath.Text = fullPath; 
            try { pbImagem.Image = Image.FromFile(fullPath); }
            catch { pbImagem.Image = null; }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal.Show();
        }

        private void txtImagemPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
