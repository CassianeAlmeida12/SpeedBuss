namespace SpeedBussss
{
    partial class EncontrarPassagem
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
            this.cb_origem = new System.Windows.Forms.ComboBox();
            this.cb_destino = new System.Windows.Forms.ComboBox();
            this.dtp_passagem = new System.Windows.Forms.DateTimePicker();
            this.bt_escolherHorario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_origem
            // 
            this.cb_origem.FormattingEnabled = true;
            this.cb_origem.Items.AddRange(new object[] {
            "Ouro Preto do Oeste - RO",
            "Ji-Paraná  - RO"});
            this.cb_origem.Location = new System.Drawing.Point(71, 391);
            this.cb_origem.Name = "cb_origem";
            this.cb_origem.Size = new System.Drawing.Size(121, 21);
            this.cb_origem.TabIndex = 0;
            // 
            // cb_destino
            // 
            this.cb_destino.FormattingEnabled = true;
            this.cb_destino.Items.AddRange(new object[] {
            "Ouro Preto do Oeste - RO",
            "Ji-Paraná  - RO"});
            this.cb_destino.Location = new System.Drawing.Point(384, 391);
            this.cb_destino.Name = "cb_destino";
            this.cb_destino.Size = new System.Drawing.Size(121, 21);
            this.cb_destino.TabIndex = 1;
            // 
            // dtp_passagem
            // 
            this.dtp_passagem.Location = new System.Drawing.Point(810, 388);
            this.dtp_passagem.Name = "dtp_passagem";
            this.dtp_passagem.Size = new System.Drawing.Size(200, 20);
            this.dtp_passagem.TabIndex = 2;
            this.dtp_passagem.ValueChanged += new System.EventHandler(this.dtp_passagem_ValueChanged);
            // 
            // bt_escolherHorario
            // 
            this.bt_escolherHorario.Location = new System.Drawing.Point(473, 585);
            this.bt_escolherHorario.Name = "bt_escolherHorario";
            this.bt_escolherHorario.Size = new System.Drawing.Size(179, 59);
            this.bt_escolherHorario.TabIndex = 3;
            this.bt_escolherHorario.UseVisualStyleBackColor = true;
            this.bt_escolherHorario.Click += new System.EventHandler(this.bt_escolherHorario_Click);
            // 
            // EncontrarPassagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.tela_de_auto_atendimento__5_;
            this.ClientSize = new System.Drawing.Size(1121, 794);
            this.Controls.Add(this.bt_escolherHorario);
            this.Controls.Add(this.dtp_passagem);
            this.Controls.Add(this.cb_destino);
            this.Controls.Add(this.cb_origem);
            this.Name = "EncontrarPassagem";
            this.Text = "EncontrarPassagem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_origem;
        private System.Windows.Forms.ComboBox cb_destino;
        private System.Windows.Forms.DateTimePicker dtp_passagem;
        private System.Windows.Forms.Button bt_escolherHorario;
    }
}