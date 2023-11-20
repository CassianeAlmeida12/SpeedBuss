namespace SpeedBussss
{
    partial class EscolherPoltronaOpoOnzemeia
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
            this.bt_verpoltronaOnzemeia = new System.Windows.Forms.Button();
            this.bt_prox = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.cb_escolherpoltronaopoonzemeia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_verpoltronaOnzemeia
            // 
            this.bt_verpoltronaOnzemeia.Location = new System.Drawing.Point(549, 591);
            this.bt_verpoltronaOnzemeia.Name = "bt_verpoltronaOnzemeia";
            this.bt_verpoltronaOnzemeia.Size = new System.Drawing.Size(178, 53);
            this.bt_verpoltronaOnzemeia.TabIndex = 0;
            this.bt_verpoltronaOnzemeia.UseVisualStyleBackColor = true;
            this.bt_verpoltronaOnzemeia.Click += new System.EventHandler(this.bt_verpoltronaOnzemeia_Click);
            // 
            // bt_prox
            // 
            this.bt_prox.Location = new System.Drawing.Point(876, 591);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(182, 53);
            this.bt_prox.TabIndex = 1;
            this.bt_prox.UseVisualStyleBackColor = true;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(55, 683);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(179, 67);
            this.bt_close.TabIndex = 2;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // cb_escolherpoltronaopoonzemeia
            // 
            this.cb_escolherpoltronaopoonzemeia.FormattingEnabled = true;
            this.cb_escolherpoltronaopoonzemeia.Location = new System.Drawing.Point(317, 608);
            this.cb_escolherpoltronaopoonzemeia.Name = "cb_escolherpoltronaopoonzemeia";
            this.cb_escolherpoltronaopoonzemeia.Size = new System.Drawing.Size(121, 21);
            this.cb_escolherpoltronaopoonzemeia.TabIndex = 3;
            // 
            // EscolherPoltronaOpoOnzemeia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__17_4;
            this.ClientSize = new System.Drawing.Size(1123, 794);
            this.Controls.Add(this.cb_escolherpoltronaopoonzemeia);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.bt_verpoltronaOnzemeia);
            this.Name = "EscolherPoltronaOpoOnzemeia";
            this.Text = "EscolherPoltronaOpoOnzemeia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_verpoltronaOnzemeia;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.ComboBox cb_escolherpoltronaopoonzemeia;
    }
}