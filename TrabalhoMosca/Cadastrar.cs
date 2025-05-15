using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrabalhoMosca
{
    public partial class Cadastrar : Form
    {
        private Form1 formPrincipal;

        public Cadastrar(Form1 form)
        {
            InitializeComponent();
            formPrincipal = form;

            cbNome.Items.AddRange(new string[] { "Sly", "Iselda", "Nailsmith",
                "Mato", "Oro", "Sheo", "Cloth", "Cornifer", "Hornet", "Quirrel", "Zote",
            "Bretta","Seer", "Grimm"});
            cbTipo.Items.AddRange(new string[] { "Merchants", "Nailmasters", "Wanderers", "Quest NPCs", "Miscellaneous" });
            cbRaca.Items.AddRange(new string[] { "The Grimm Troupe", "Spider Tribe", "Void", "Moth Tribe" });
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            string projectDir = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            string resourcesSpritesDir = Path.Combine(projectDir, "Resources", "Sprites");

            if (!Directory.Exists(resourcesSpritesDir))
            {
                MessageBox.Show($"Pasta não encontrada: {resourcesSpritesDir}");
                return;
            }

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = resourcesSpritesDir;
                dlg.Filter = "Arquivos de Imagem (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                dlg.Title = "Escolher sprite do personagem";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = dlg.FileName;
                    string fileName = Path.GetFileName(fullPath);
                    txtImagemPath.Text = fileName;

                    try
                    {
                        pbImagem.Image = Image.FromFile(fullPath);
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível carregar a imagem selecionada.");
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbNome.Text) ||
                string.IsNullOrWhiteSpace(cbTipo.Text) ||
                string.IsNullOrWhiteSpace(cbRaca.Text) ||
                string.IsNullOrWhiteSpace(txtImagemPath.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            var p = new Personagem(
                cbNome.Text.Trim(),
                cbTipo.Text.Trim(),
                cbRaca.Text.Trim(),
                (int)nudNivel.Value,
                txtImagemPath.Text.Trim()
            );

            PersonagemLista.Add(p);
            MessageBox.Show("Personagem cadastrado com sucesso!");
            formPrincipal.AtualizarLista();
            this.Hide();
            formPrincipal.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal.Show();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
