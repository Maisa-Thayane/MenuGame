namespace TrabalhoMosca
{
    partial class Editar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.nudNivel = new System.Windows.Forms.NumericUpDown();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.txtImagemPath = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPersonagens = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(636, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(645, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(459, 172);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(121, 21);
            this.cbRaca.TabIndex = 29;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(459, 107);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 28;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(457, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome";
            // 
            // nudNivel
            // 
            this.nudNivel.Location = new System.Drawing.Point(460, 240);
            this.nudNivel.Name = "nudNivel";
            this.nudNivel.Size = new System.Drawing.Size(120, 20);
            this.nudNivel.TabIndex = 25;
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.Location = new System.Drawing.Point(460, 332);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(75, 23);
            this.btnEscolherImagem.TabIndex = 24;
            this.btnEscolherImagem.Text = "Imagem";
            this.btnEscolherImagem.UseVisualStyleBackColor = true;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click_1);
            // 
            // txtImagemPath
            // 
            this.txtImagemPath.Location = new System.Drawing.Point(460, 306);
            this.txtImagemPath.Name = "txtImagemPath";
            this.txtImagemPath.Size = new System.Drawing.Size(100, 20);
            this.txtImagemPath.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(460, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 22;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(457, 281);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(44, 13);
            this.lblImagem.TabIndex = 21;
            this.lblImagem.Text = "Imagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nivel";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(461, 147);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 19;
            this.lblRaca.Text = "Raca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo";
            // 
            // lstPersonagens
            // 
            this.lstPersonagens.FormattingEnabled = true;
            this.lstPersonagens.Location = new System.Drawing.Point(115, 240);
            this.lstPersonagens.Name = "lstPersonagens";
            this.lstPersonagens.Size = new System.Drawing.Size(120, 95);
            this.lstPersonagens.TabIndex = 32;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(211, 355);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagem.Location = new System.Drawing.Point(80, 12);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(155, 100);
            this.pbImagem.TabIndex = 26;
            this.pbImagem.TabStop = false;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lstPersonagens);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.nudNivel);
            this.Controls.Add(this.btnEscolherImagem);
            this.Controls.Add(this.txtImagemPath);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.label2);
            this.Name = "Editar";
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.NumericUpDown nudNivel;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.TextBox txtImagemPath;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPersonagens;
        private System.Windows.Forms.Button btnEditar;
    }
}