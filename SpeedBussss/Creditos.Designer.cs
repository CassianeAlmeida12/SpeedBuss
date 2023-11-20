namespace SpeedBussss
{
    partial class Creditos
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
            this.bt_voltarCred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_voltarCred
            // 
            this.bt_voltarCred.Location = new System.Drawing.Point(855, 677);
            this.bt_voltarCred.Name = "bt_voltarCred";
            this.bt_voltarCred.Size = new System.Drawing.Size(152, 53);
            this.bt_voltarCred.TabIndex = 0;
            this.bt_voltarCred.UseVisualStyleBackColor = true;
            this.bt_voltarCred.Click += new System.EventHandler(this.bt_voltarCred_Click);
            // 
            // Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedBussss.Properties.Resources.Orange_Bus_Tour_Online_Service_Poster__15_;
            this.ClientSize = new System.Drawing.Size(1115, 791);
            this.Controls.Add(this.bt_voltarCred);
            this.Name = "Creditos";
            this.Text = "Creditos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_voltarCred;
    }
}