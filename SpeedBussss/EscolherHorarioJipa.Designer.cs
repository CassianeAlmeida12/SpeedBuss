namespace SpeedBussss
{
    partial class EscolherHorarioJipa
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
            this.bt_setemeiaJipa = new System.Windows.Forms.Button();
            this.bt_onzemeiaJipa = new System.Windows.Forms.Button();
            this.bt_oitoJipa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_setemeiaJipa
            // 
            this.bt_setemeiaJipa.Location = new System.Drawing.Point(808, 233);
            this.bt_setemeiaJipa.Name = "bt_setemeiaJipa";
            this.bt_setemeiaJipa.Size = new System.Drawing.Size(159, 54);
            this.bt_setemeiaJipa.TabIndex = 0;
            this.bt_setemeiaJipa.UseVisualStyleBackColor = true;
            this.bt_setemeiaJipa.Click += new System.EventHandler(this.bt_setemeiaJipa_Click);
            // 
            // bt_onzemeiaJipa
            // 
            this.bt_onzemeiaJipa.Location = new System.Drawing.Point(818, 431);
            this.bt_onzemeiaJipa.Name = "bt_onzemeiaJipa";
            this.bt_onzemeiaJipa.Size = new System.Drawing.Size(149, 58);
            this.bt_onzemeiaJipa.TabIndex = 1;
            this.bt_onzemeiaJipa.UseVisualStyleBackColor = true;
            this.bt_onzemeiaJipa.Click += new System.EventHandler(this.bt_onzemeiaJipa_Click);
            // 
            // bt_oitoJipa
            // 
            this.bt_oitoJipa.Location = new System.Drawing.Point(810, 636);
            this.bt_oitoJipa.Name = "bt_oitoJipa";
            this.bt_oitoJipa.Size = new System.Drawing.Size(165, 54);
            this.bt_oitoJipa.TabIndex = 2;
            this.bt_oitoJipa.UseVisualStyleBackColor = true;
            this.bt_oitoJipa.Click += new System.EventHandler(this.bt_oitoJipa_Click);
            // 
            // EscolherHorarioJipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__16_1;
            this.ClientSize = new System.Drawing.Size(1123, 796);
            this.Controls.Add(this.bt_oitoJipa);
            this.Controls.Add(this.bt_onzemeiaJipa);
            this.Controls.Add(this.bt_setemeiaJipa);
            this.Name = "EscolherHorarioJipa";
            this.Text = "EscolherHorarioJipa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_setemeiaJipa;
        private System.Windows.Forms.Button bt_onzemeiaJipa;
        private System.Windows.Forms.Button bt_oitoJipa;
    }
}