namespace DLWMS.WinForms
{
    partial class frmPocetna
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
            this.lblKonekcijaInfo = new System.Windows.Forms.Label();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            this.lblKonekcijaInfo.AutoSize = true;
            this.lblKonekcijaInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKonekcijaInfo.Location = new System.Drawing.Point(133, 78);
            this.lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            this.lblKonekcijaInfo.Size = new System.Drawing.Size(0, 28);
            this.lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(361, 160);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjestaj.TabIndex = 1;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 239);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.lblKonekcijaInfo);
            this.Name = "frmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnIzvjestaj;
    }
}