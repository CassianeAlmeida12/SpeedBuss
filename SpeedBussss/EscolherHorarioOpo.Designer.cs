namespace SpeedBussss
{
    partial class EscolherHorarioOpo
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
            this.bt_setemeiaOpo = new System.Windows.Forms.Button();
            this.bt_onzemeiaOpo = new System.Windows.Forms.Button();
            this.bt_oitoOpo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_setemeiaOpo
            // 
            this.bt_setemeiaOpo.Location = new System.Drawing.Point(807, 224);
            this.bt_setemeiaOpo.Name = "bt_setemeiaOpo";
            this.bt_setemeiaOpo.Size = new System.Drawing.Size(161, 62);
            this.bt_setemeiaOpo.TabIndex = 0;
            this.bt_setemeiaOpo.UseVisualStyleBackColor = true;
            this.bt_setemeiaOpo.Click += new System.EventHandler(this.bt_setemeiaOpo_Click);
            // 
            // bt_onzemeiaOpo
            // 
            this.bt_onzemeiaOpo.Location = new System.Drawing.Point(811, 424);
            this.bt_onzemeiaOpo.Name = "bt_onzemeiaOpo";
            this.bt_onzemeiaOpo.Size = new System.Drawing.Size(156, 66);
            this.bt_onzemeiaOpo.TabIndex = 1;
            this.bt_onzemeiaOpo.UseVisualStyleBackColor = true;
            this.bt_onzemeiaOpo.Click += new System.EventHandler(this.bt_onzemeiaOpo_Click);
            // 
            // bt_oitoOpo
            // 
            this.bt_oitoOpo.Location = new System.Drawing.Point(814, 635);
            this.bt_oitoOpo.Name = "bt_oitoOpo";
            this.bt_oitoOpo.Size = new System.Drawing.Size(153, 56);
            this.bt_oitoOpo.TabIndex = 2;
            this.bt_oitoOpo.UseVisualStyleBackColor = true;
            this.bt_oitoOpo.Click += new System.EventHandler(this.bt_oitoOpo_Click);
            // 
            // EscolherHorarioOpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__16_;
            this.ClientSize = new System.Drawing.Size(1120, 795);
            this.Controls.Add(this.bt_oitoOpo);
            this.Controls.Add(this.bt_onzemeiaOpo);
            this.Controls.Add(this.bt_setemeiaOpo);
            this.Name = "EscolherHorarioOpo";
            this.Text = "EscolherHorarioOpo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_setemeiaOpo;
        private System.Windows.Forms.Button bt_onzemeiaOpo;
        private System.Windows.Forms.Button bt_oitoOpo;
    }
}