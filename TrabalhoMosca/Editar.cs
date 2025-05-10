using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            cbTipo.Items.AddRange(new string[] {
                "teste1","teste2","teste3","teste4","teste5"});
            cbRaca.Items.AddRange(new string[] {
                "teste6","teste7","teste8","teste9","teste10"});

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
            CarregarNosCamposPorÍndice();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            indiceEditando = lstPersonagens.SelectedIndex;
            if (indiceEditando < 0)
            {
                MessageBox.Show("Selecione um personagem antes de clicar em Editar.");
                return;
            }
            CarregarNosCamposPorÍndice();
        }

        private void CarregarNosCamposPorÍndice()
        {
            if (indiceEditando < 0) return;

            var pers = PersonagemLista.ObterTodos()[indiceEditando];
            txtNome.Text = pers.Nome;
            cbTipo.Text = pers.Tipo;
            cbRaca.Text = pers.Raca;
            nudNivel.Value = pers.Nivel;
            txtImagemPath.Text = pers.ImagemPath;
            try { pbImagem.Image = Image.FromFile(pers.ImagemPath); }
            catch { pbImagem.Image = null; }
        }

        private void btnEscolherImagem_Click_1(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtImagemPath.Text = dlg.FileName;
                    try { pbImagem.Image = Image.FromFile(dlg.FileName); }
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
                !File.Exists(txtImagemPath.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente e selecione uma imagem válida.");
                return;
            }
            var atualizado = new Personagem(
                txtNome.Text.Trim(),
                cbTipo.Text.Trim(),
                cbRaca.Text.Trim(),
                (int)nudNivel.Value,
                txtImagemPath.Text.Trim()
            );

            PersonagemLista.Update(indiceEditando, atualizado);
            MessageBox.Show("Personagem atualizado com sucesso!");

            AtualizarLista();
        }



        private void LimparCampos()
        {
            txtNome.Clear();
            cbTipo.Text = "";
            cbRaca.Text = "";
            nudNivel.Value = nudNivel.Minimum;
            txtImagemPath.Clear();
            pbImagem.Image = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPrincipal.Show();
        }
    }
}
