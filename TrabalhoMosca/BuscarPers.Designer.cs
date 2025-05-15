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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPers));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.txtImagemPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(468, 185);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(183, 22);
            this.txtBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.btnBuscar.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(507, 215);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Salvar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lstResultados
            // 
            this.lstResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(107, 295);
            this.lstResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(205, 116);
            this.lstResultados.TabIndex = 2;
            this.lstResultados.SelectedIndexChanged += new System.EventHandler(this.lstResultados_SelectedIndexChanged_1);
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.BackColor = System.Drawing.Color.Transparent;
            this.lblResumo.Font = new System.Drawing.Font("Trajan Pro", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResumo.Location = new System.Drawing.Point(465, 165);
            this.lblResumo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(156, 16);
            this.lblResumo.TabIndex = 3;
            this.lblResumo.Text = "Buscar personagem:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.btnVoltar.Font = new System.Drawing.Font("Trajan Pro", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(935, 513);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 28);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagem.Location = new System.Drawing.Point(107, 43);
            this.pbImagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(207, 123);
            this.pbImagem.TabIndex = 4;
            this.pbImagem.TabStop = false;
            // 
            // txtImagemPath
            // 
            this.txtImagemPath.Location = new System.Drawing.Point(120, 174);
            this.txtImagemPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImagemPath.Name = "txtImagemPath";
            this.txtImagemPath.Size = new System.Drawing.Size(176, 22);
            this.txtImagemPath.TabIndex = 24;
            this.txtImagemPath.TextChanged += new System.EventHandler(this.txtImagemPath_TextChanged);
            // 
            // BuscarPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtImagemPath);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}