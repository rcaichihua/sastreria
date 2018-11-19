namespace GUI_Sastreria
{
    partial class frmPrincipal
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
            this.ucDashBoard1 = new GUI_Sastreria.ucDashBoard();
            this.SuspendLayout();
            // 
            // ucDashBoard1
            // 
            this.ucDashBoard1.Location = new System.Drawing.Point(23, 63);
            this.ucDashBoard1.Name = "ucDashBoard1";
            this.ucDashBoard1.Size = new System.Drawing.Size(1227, 428);
            this.ucDashBoard1.TabIndex = 0;
            this.ucDashBoard1.UseSelectable = true;
            this.ucDashBoard1.Load += new System.EventHandler(this.ucDashBoard1_Load);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 592);
            this.Controls.Add(this.ucDashBoard1);
            this.Name = "frmPrincipal";
            this.Text = "...:::Sistema de gestión Sastreria:::...";
            this.ResumeLayout(false);

        }

        #endregion

        private ucDashBoard ucDashBoard1;
    }
}