namespace SpeedBussss
{
    partial class EscolherPoltronaJipaSeteMeia
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
            this.cb_escolherpoltronaJipa = new System.Windows.Forms.ComboBox();
            this.bt_verificapoltronaJipa = new System.Windows.Forms.Button();
            this.bt_prox = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_escolherpoltronaJipa
            // 
            this.cb_escolherpoltronaJipa.FormattingEnabled = true;
            this.cb_escolherpoltronaJipa.Location = new System.Drawing.Point(330, 616);
            this.cb_escolherpoltronaJipa.Name = "cb_escolherpoltronaJipa";
            this.cb_escolherpoltronaJipa.Size = new System.Drawing.Size(121, 21);
            this.cb_escolherpoltronaJipa.TabIndex = 0;
            // 
            // bt_verificapoltronaJipa
            // 
            this.bt_verificapoltronaJipa.Location = new System.Drawing.Point(540, 580);
            this.bt_verificapoltronaJipa.Name = "bt_verificapoltronaJipa";
            this.bt_verificapoltronaJipa.Size = new System.Drawing.Size(189, 71);
            this.bt_verificapoltronaJipa.TabIndex = 1;
            this.bt_verificapoltronaJipa.UseVisualStyleBackColor = true;
            this.bt_verificapoltronaJipa.Click += new System.EventHandler(this.bt_verificapoltronaJipa_Click);
            // 
            // bt_prox
            // 
            this.bt_prox.Location = new System.Drawing.Point(882, 591);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(178, 59);
            this.bt_prox.TabIndex = 2;
            this.bt_prox.UseVisualStyleBackColor = true;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(63, 686);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(159, 59);
            this.bt_close.TabIndex = 3;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // EscolherPoltronaJipaSeteMeia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__17_1;
            this.ClientSize = new System.Drawing.Size(1121, 791);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.bt_verificapoltronaJipa);
            this.Controls.Add(this.cb_escolherpoltronaJipa);
            this.Name = "EscolherPoltronaJipaSeteMeia";
            this.Text = "EscolherPoltronaJipa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_escolherpoltronaJipa;
        private System.Windows.Forms.Button bt_verificapoltronaJipa;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Button bt_close;
    }
}