namespace SpeedBussss
{
    partial class EscolherPoltronaJipaOnzemeia
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
            this.cb_escolherPoltronaJipaOnzemeia = new System.Windows.Forms.ComboBox();
            this.bt_verificapoltronaJipaOnzemeia = new System.Windows.Forms.Button();
            this.bt_prox = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_escolherPoltronaJipaOnzemeia
            // 
            this.cb_escolherPoltronaJipaOnzemeia.FormattingEnabled = true;
            this.cb_escolherPoltronaJipaOnzemeia.Location = new System.Drawing.Point(326, 613);
            this.cb_escolherPoltronaJipaOnzemeia.Name = "cb_escolherPoltronaJipaOnzemeia";
            this.cb_escolherPoltronaJipaOnzemeia.Size = new System.Drawing.Size(121, 21);
            this.cb_escolherPoltronaJipaOnzemeia.TabIndex = 0;
            // 
            // bt_verificapoltronaJipaOnzemeia
            // 
            this.bt_verificapoltronaJipaOnzemeia.Location = new System.Drawing.Point(554, 586);
            this.bt_verificapoltronaJipaOnzemeia.Name = "bt_verificapoltronaJipaOnzemeia";
            this.bt_verificapoltronaJipaOnzemeia.Size = new System.Drawing.Size(160, 59);
            this.bt_verificapoltronaJipaOnzemeia.TabIndex = 1;
            this.bt_verificapoltronaJipaOnzemeia.UseVisualStyleBackColor = true;
            this.bt_verificapoltronaJipaOnzemeia.Click += new System.EventHandler(this.bt_verificapoltronaJipaOnzemeia_Click);
            // 
            // bt_prox
            // 
            this.bt_prox.Location = new System.Drawing.Point(880, 589);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(174, 66);
            this.bt_prox.TabIndex = 2;
            this.bt_prox.UseVisualStyleBackColor = true;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(61, 688);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(159, 60);
            this.bt_close.TabIndex = 3;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // EscolherPoltronaJipaOnzemeia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__17_2;
            this.ClientSize = new System.Drawing.Size(1112, 793);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.bt_verificapoltronaJipaOnzemeia);
            this.Controls.Add(this.cb_escolherPoltronaJipaOnzemeia);
            this.Name = "EscolherPoltronaJipaOnzemeia";
            this.Text = "EscolherPoltronaJipaOnzemeia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_escolherPoltronaJipaOnzemeia;
        private System.Windows.Forms.Button bt_verificapoltronaJipaOnzemeia;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Button bt_close;
    }
}