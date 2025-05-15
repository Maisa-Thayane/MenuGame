using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrabalhoMosca
{
    public partial class Editar : Form
    {
        private Form1 formPrincipal;
        private int indiceEditando = -1;

        public Editar(Form1 form)
        {
            InitializeComponent();
            formPrincipal = form;

            cbTipo.Items.AddRange(new string[] { "teste1", "teste2", "teste3", "teste4", "teste5" });
            cbRaca.Items.AddRange(new string[] { "teste6", "teste7", "teste8", "teste9", "teste10" });

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lstPersonagens.Items.Clear();
            foreach (var pers in PersonagemLista.ObterTodos())
                lstPersonagens.Items.Add(pers.Nome);

            indiceEditando = -1;
            LimparCampos();
        }

        private void lstPersonagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceEditando = lstPersonagens.SelectedIndex;
            CarregarNosCamposPorIndice();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            indiceEditando = lstPersonagens.SelectedIndex;
            if (indiceEditando < 0)
            {
                MessageBox.Show("Selecione um personagem antes de clicar em Editar.");
                return;
            }
            CarregarNosCamposPorIndice();
        }

        private void CarregarNosCamposPorIndice()
        {
            if (indiceEditando < 0) return;

            var pers = PersonagemLista.ObterTodos()[indiceEditando];
            txtNome.Text = pers.Nome;
            cbTipo.Text = pers.Tipo;
            cbRaca.Text = pers.Raca;
            nudNivel.Value = pers.Nivel;

            string projectDir = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            string resourcesSpritesDir = Path.Combine(projectDir, "Resources", "Sprites");
            string fullPath = Path.Combine(resourcesSpritesDir, pers.ImagemPath);

            txtImagemPath.Text = fullPath;

            try
            {
                pbImagem.Image = Image.FromFile(fullPath);
            }
            catch
            {
                pbImagem.Image = null;
            }
        }

        private void btnEscolherImagem_Click_1(object sender, EventArgs e)
        {
            string projectDir = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            string resourcesSpritesDir = Path.Combine(projectDir, "Resources", "Sprites");

            if (!Directory.Exists(resourcesSpritesDir))
            {
                MessageBox.Show($"Pasta não encontrada: {resourcesSpritesDir}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = resourcesSpritesDir;
                dlg.Filter = "Imagens (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp";
                dlg.Title = "Escolher sprite do personagem";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fullSel = dlg.FileName;
                    txtImagemPath.Text = fullSel;
                    try { pbImagem.Image = Image.FromFile(fullSel); }
                    catch { MessageBox.Show("Não foi possível carregar a imagem."); }
                }
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (indiceEditando < 0)
            {
                MessageBox.Show("Antes de salvar, selecione e edite um personagem.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(cbTipo.Text) ||
                string.IsNullOrWhiteSpace(cbRaca.Text) ||
                string.IsNullOrWhiteSpace(txtImagemPath.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente e selecione uma imagem válida.");
                return;
            }

            var atualizado = new Personagem(
                txtNome.Text.Trim(), cbTipo.Text.Trim(), cbRaca.Text.Trim(), (int)nudNivel.Value, txtImagemPath.Text.Trim());

            PersonagemLista.Update(indiceEditando, atualizado);
            MessageBox.Show("Personagem atualizado com sucesso!");
            AtualizarLista();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            cbTipo.Text = string.Empty;
            cbRaca.Text = string.Empty;
            nudNivel.Value = nudNivel.Minimum;
            txtImagemPath.Clear();
            pbImagem.Image = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal.Show();
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int selecionado = lstPersonagens.SelectedIndex;
            if (selecionado < 0)
            {
                MessageBox.Show("Selecione um personagem antes de clicar em Excluir.");
                return;
            }

            var resultado = MessageBox.Show(
                $"Deseja realmente excluir “{lstPersonagens.Items[selecionado]}”?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            PersonagemLista.Remover(selecionado);
            MessageBox.Show("Personagem excluído com sucesso!");
            AtualizarLista();
        }
    }
}