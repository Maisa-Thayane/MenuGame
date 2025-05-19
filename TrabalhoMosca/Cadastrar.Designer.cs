namespace TrabalhoMosca
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImagem = new System.Windows.Forms.Label();
            this.txtImagemPath = new System.Windows.Forms.TextBox();
            this.nudNivel = new System.Windows.Forms.NumericUpDown();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.BtnAleatorio = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(457, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnEscolherImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherImagem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEscolherImagem.Location = new System.Drawing.Point(480, 262);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(75, 23);
            this.btnEscolherImagem.TabIndex = 10;
            this.btnEscolherImagem.Text = "Imagem";
            this.btnEscolherImagem.UseVisualStyleBackColor = false;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(457, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.BackColor = System.Drawing.Color.Transparent;
            this.lblRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRaca.Location = new System.Drawing.Point(458, 128);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(36, 13);
            this.lblRaca.TabIndex = 2;
            this.lblRaca.Text = "Raça:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(458, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel:";
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.BackColor = System.Drawing.Color.Transparent;
            this.lblImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.ForeColor = System.Drawing.SystemColors.Control;
            this.lblImagem.Location = new System.Drawing.Point(458, 222);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(47, 13);
            this.lblImagem.TabIndex = 4;
            this.lblImagem.Text = "Imagem:";
            // 
            // txtImagemPath
            // 
            this.txtImagemPath.Location = new System.Drawing.Point(459, 238);
            this.txtImagemPath.Name = "txtImagemPath";
            this.txtImagemPath.Size = new System.Drawing.Size(121, 20);
            this.txtImagemPath.TabIndex = 9;
            // 
            // nudNivel
            // 
            this.nudNivel.Location = new System.Drawing.Point(460, 192);
            this.nudNivel.Name = "nudNivel";
            this.nudNivel.Size = new System.Drawing.Size(120, 20);
            this.nudNivel.TabIndex = 11;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(460, 94);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 14;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(459, 145);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(121, 21);
            this.cbRaca.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(701, 369);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(701, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(461, 51);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(121, 21);
            this.cbNome.TabIndex = 18;
            // 
            // BtnAleatorio
            // 
            this.BtnAleatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BtnAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAleatorio.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAleatorio.Location = new System.Drawing.Point(336, 145);
            this.BtnAleatorio.Name = "BtnAleatorio";
            this.BtnAleatorio.Size = new System.Drawing.Size(75, 23);
            this.BtnAleatorio.TabIndex = 19;
            this.BtnAleatorio.Text = "Random";
            this.BtnAleatorio.UseVisualStyleBackColor = false;
            this.BtnAleatorio.Click += new System.EventHandler(this.BtnAleatorio_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImagem.Location = new System.Drawing.Point(38, 8);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(238, 181);
            this.pbImagem.TabIndex = 27;
            this.pbImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(772, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.BtnAleatorio);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.nudNivel);
            this.Controls.Add(this.btnEscolherImagem);
            this.Controls.Add(this.txtImagemPath);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.TextBox txtImagemPath;
        private System.Windows.Forms.NumericUpDown nudNivel;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Button BtnAleatorio;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label label1;
    }
}