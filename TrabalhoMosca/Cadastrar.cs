using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrabalhoMosca
{
    public partial class Cadastrar : Form
    {
        private Form1 formPrincipal;
        private bool estouEditando;
        private int indiceEditando;

        public Cadastrar(Form1 form, Personagem personagem = null, int indice = -1)
        {
            InitializeComponent();
            formPrincipal = form;
            estouEditando = personagem != null;
            indiceEditando = indice;
            cbTipo.Items.AddRange(new string[] {
    "teste1", "teste2", "teste3", "teste4", "teste5"});

            cbRaca.Items.AddRange(new string[] {
    "teste6", "teste7", "teste8", "teste9", "teste10"});
            AtualizarLista();

            if (estouEditando)
            {
                CarregarNosCampos(personagem);
            }
        }

        private void AtualizarLista()
        {
            lstPersonagens.Items.Clear();
            foreach (var p in PersonagemLista.ObterTodos())
                lstPersonagens.Items.Add(p.Nome);
        }

        private void CarregarNosCampos(Personagem p)
        {
            txtNome.Text = p.Nome;
            cbTipo.Text = p.Tipo;
            cbRaca.Text = p.Raca;
            nudNivel.Value = p.Nivel;
            txtImagemPath.Text = p.ImagemPath;
            try { pbImagem.Image = Image.FromFile(p.ImagemPath); }
            catch { pbImagem.Image = null; }
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtImagemPath.Text = dlg.FileName;
                    try { pbImagem.Image = Image.FromFile(dlg.FileName); }
                    catch { MessageBox.Show("Não foi possível carregar a imagem."); }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(cbTipo.Text) ||
                string.IsNullOrWhiteSpace(cbRaca.Text) ||
                !File.Exists(txtImagemPath.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            var p = new Personagem(
                txtNome.Text.Trim(),
                cbTipo.Text.Trim(),
                cbRaca.Text.Trim(),
                (int)nudNivel.Value,
                txtImagemPath.Text.Trim()
            );

            if (estouEditando)
            {
                PersonagemLista.Update(indiceEditando, p);
                MessageBox.Show("Personagem atualizado!");
            }
            else
            {
                PersonagemLista.Add(p);
                MessageBox.Show("Personagem cadastrado!");
            }

            formPrincipal.AtualizarLista();
            this.Hide();
            formPrincipal.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int indice = lstPersonagens.SelectedIndex;
            if (indice < 0)
            {
                MessageBox.Show("Selecione um personagem para editar.");
                return;
            }

            var p = PersonagemLista.ObterTodos()[indice];
            estouEditando = true;
            indiceEditando = indice;

            CarregarNosCampos(p);
        }
    }
}
