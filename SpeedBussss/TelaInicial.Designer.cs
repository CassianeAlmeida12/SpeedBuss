namespace SpeedBussss
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_creditos = new System.Windows.Forms.Button();
            this.bt_encontrarPassagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_creditos
            // 
            this.bt_creditos.Location = new System.Drawing.Point(927, 48);
            this.bt_creditos.Name = "bt_creditos";
            this.bt_creditos.Size = new System.Drawing.Size(129, 25);
            this.bt_creditos.TabIndex = 0;
            this.bt_creditos.UseVisualStyleBackColor = true;
            this.bt_creditos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_encontrarPassagem
            // 
            this.bt_encontrarPassagem.FlatAppearance.BorderSize = 0;
            this.bt_encontrarPassagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_encontrarPassagem.ForeColor = System.Drawing.Color.Transparent;
            this.bt_encontrarPassagem.Location = new System.Drawing.Point(162, 426);
            this.bt_encontrarPassagem.Name = "bt_encontrarPassagem";
            this.bt_encontrarPassagem.Size = new System.Drawing.Size(181, 64);
            this.bt_encontrarPassagem.TabIndex = 1;
            this.bt_encontrarPassagem.UseVisualStyleBackColor = true;
            this.bt_encontrarPassagem.Click += new System.EventHandler(this.bt_encontrarPassagem_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.tela_inicial__4_;
            this.ClientSize = new System.Drawing.Size(1120, 792);
            this.Controls.Add(this.bt_encontrarPassagem);
            this.Controls.Add(this.bt_creditos);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_creditos;
        private System.Windows.Forms.Button bt_encontrarPassagem;
    }
}

