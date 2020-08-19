namespace USteuerbetrag
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.CmdAusgabe = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.LblSteuersatz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gehalt";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(64, 64);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 1;
            // 
            // CmdAusgabe
            // 
            this.CmdAusgabe.Location = new System.Drawing.Point(64, 107);
            this.CmdAusgabe.Name = "CmdAusgabe";
            this.CmdAusgabe.Size = new System.Drawing.Size(100, 23);
            this.CmdAusgabe.TabIndex = 2;
            this.CmdAusgabe.Text = "Berechnen";
            this.CmdAusgabe.UseVisualStyleBackColor = true;
            this.CmdAusgabe.Click += new System.EventHandler(this.CmdAusgabe_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(209, 70);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(74, 13);
            this.LblAusgabe.TabIndex = 3;
            this.LblAusgabe.Text = "Steuerbetrag: ";
            // 
            // LblSteuersatz
            // 
            this.LblSteuersatz.AutoSize = true;
            this.LblSteuersatz.Location = new System.Drawing.Point(209, 117);
            this.LblSteuersatz.Name = "LblSteuersatz";
            this.LblSteuersatz.Size = new System.Drawing.Size(60, 13);
            this.LblSteuersatz.TabIndex = 4;
            this.LblSteuersatz.Text = "Steuersatz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSteuersatz);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdAusgabe);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Button CmdAusgabe;
        private System.Windows.Forms.Label LblAusgabe;
        private System.Windows.Forms.Label LblSteuersatz;
    }
}

