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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(458, 171);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(100, 20);
            this.txtBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(472, 197);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(318, 80);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(120, 95);
            this.lstResultados.TabIndex = 2;
            this.lstResultados.SelectedIndexChanged += new System.EventHandler(this.lstResultados_SelectedIndexChanged_1);
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Location = new System.Drawing.Point(606, 279);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(35, 13);
            this.lblResumo.TabIndex = 3;
            this.lblResumo.Text = "label1";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(151, 310);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "button1";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagem.Location = new System.Drawing.Point(151, 233);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(100, 50);
            this.pbImagem.TabIndex = 4;
            this.pbImagem.TabStop = false;
            // 
            // BuscarPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}