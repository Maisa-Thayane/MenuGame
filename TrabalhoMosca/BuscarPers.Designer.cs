namespace TrabalhoMosca
{
    partial class BuscarPers
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.txtImagemPath = new System.Windows.Forms.TextBox();
            this.btnSalvarJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(351, 150);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(138, 20);
            this.txtBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(380, 175);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Salvar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lstResultados
            // 
            this.lstResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(80, 240);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(155, 95);
            this.lstResultados.TabIndex = 2;
            this.lstResultados.SelectedIndexChanged += new System.EventHandler(this.lstResultados_SelectedIndexChanged_1);
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.BackColor = System.Drawing.Color.Transparent;
            this.lblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResumo.Location = new System.Drawing.Point(349, 134);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(104, 13);
            this.lblResumo.TabIndex = 3;
            this.lblResumo.Text = "Buscar personagem:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(701, 417);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagem.Location = new System.Drawing.Point(80, 35);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(155, 100);
            this.pbImagem.TabIndex = 4;
            this.pbImagem.TabStop = false;
            // 
            // txtImagemPath
            // 
            this.txtImagemPath.Location = new System.Drawing.Point(122, 140);
            this.txtImagemPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtImagemPath.Name = "txtImagemPath";
            this.txtImagemPath.Size = new System.Drawing.Size(76, 20);
            this.txtImagemPath.TabIndex = 0;
            this.txtImagemPath.TextChanged += new System.EventHandler(this.txtImagemPath_TextChanged);
            // 
            // btnSalvarJson
            // 
            this.btnSalvarJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.btnSalvarJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarJson.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvarJson.Location = new System.Drawing.Point(263, 172);
            this.btnSalvarJson.Name = "btnSalvarJson";
            this.btnSalvarJson.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarJson.TabIndex = 6;
            this.btnSalvarJson.Text = "Salvar";
            this.btnSalvarJson.UseVisualStyleBackColor = false;
            this.btnSalvarJson.Click += new System.EventHandler(this.btnSalvarJson_Click);
            // 
            // BuscarPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSalvarJson);
            this.Controls.Add(this.txtImagemPath);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.Name = "BuscarPers";
            this.Text = "BuscarPers";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtImagemPath;
        private System.Windows.Forms.Button btnSalvarJson;
    }
}