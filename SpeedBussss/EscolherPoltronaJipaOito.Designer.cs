namespace SpeedBussss
{
    partial class EscolherPoltronaJipaOito
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
            this.bt_verificaPoltronaJipaOito = new System.Windows.Forms.Button();
            this.cb_escolherPoltronaJipaOito = new System.Windows.Forms.ComboBox();
            this.bt_closepoltrona = new System.Windows.Forms.Button();
            this.bt_PROX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_verificaPoltronaJipaOito
            // 
            this.bt_verificaPoltronaJipaOito.Location = new System.Drawing.Point(546, 580);
            this.bt_verificaPoltronaJipaOito.Name = "bt_verificaPoltronaJipaOito";
            this.bt_verificaPoltronaJipaOito.Size = new System.Drawing.Size(184, 69);
            this.bt_verificaPoltronaJipaOito.TabIndex = 0;
            this.bt_verificaPoltronaJipaOito.UseVisualStyleBackColor = true;
            this.bt_verificaPoltronaJipaOito.Click += new System.EventHandler(this.bt_verificaPoltronaJipaOito_Click);
            // 
            // cb_escolherPoltronaJipaOito
            // 
            this.cb_escolherPoltronaJipaOito.FormattingEnabled = true;
            this.cb_escolherPoltronaJipaOito.Location = new System.Drawing.Point(320, 615);
            this.cb_escolherPoltronaJipaOito.Name = "cb_escolherPoltronaJipaOito";
            this.cb_escolherPoltronaJipaOito.Size = new System.Drawing.Size(121, 21);
            this.cb_escolherPoltronaJipaOito.TabIndex = 1;
            // 
            // bt_closepoltrona
            // 
            this.bt_closepoltrona.Location = new System.Drawing.Point(61, 686);
            this.bt_closepoltrona.Name = "bt_closepoltrona";
            this.bt_closepoltrona.Size = new System.Drawing.Size(162, 59);
            this.bt_closepoltrona.TabIndex = 2;
            this.bt_closepoltrona.UseVisualStyleBackColor = true;
            this.bt_closepoltrona.Click += new System.EventHandler(this.bt_closepoltrona_Click);
            // 
            // bt_PROX
            // 
            this.bt_PROX.Location = new System.Drawing.Point(887, 591);
            this.bt_PROX.Name = "bt_PROX";
            this.bt_PROX.Size = new System.Drawing.Size(172, 67);
            this.bt_PROX.TabIndex = 3;
            this.bt_PROX.UseVisualStyleBackColor = true;
            this.bt_PROX.Click += new System.EventHandler(this.bt_PROX_Click);
            // 
            // EscolherPoltronaJipaOito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__17_3;
            this.ClientSize = new System.Drawing.Size(1117, 788);
            this.Controls.Add(this.bt_PROX);
            this.Controls.Add(this.bt_closepoltrona);
            this.Controls.Add(this.cb_escolherPoltronaJipaOito);
            this.Controls.Add(this.bt_verificaPoltronaJipaOito);
            this.Name = "EscolherPoltronaJipaOito";
            this.Text = "EscolherPoltronaJipaOito";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_verificaPoltronaJipaOito;
        private System.Windows.Forms.ComboBox cb_escolherPoltronaJipaOito;
        private System.Windows.Forms.Button bt_closepoltrona;
        private System.Windows.Forms.Button bt_PROX;
    }
}