namespace SpeedBussss
{
    partial class EscolhePagamento
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
            this.bt_continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_continuar
            // 
            this.bt_continuar.Location = new System.Drawing.Point(470, 659);
            this.bt_continuar.Name = "bt_continuar";
            this.bt_continuar.Size = new System.Drawing.Size(181, 60);
            this.bt_continuar.TabIndex = 0;
            this.bt_continuar.UseVisualStyleBackColor = true;
            this.bt_continuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // EscolhePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__20_;
            this.ClientSize = new System.Drawing.Size(1123, 745);
            this.Controls.Add(this.bt_continuar);
            this.Name = "EscolhePagamento";
            this.Text = "EscolhePagamento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_continuar;
    }
}