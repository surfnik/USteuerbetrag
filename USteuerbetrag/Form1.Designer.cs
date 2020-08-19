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
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(363, 39);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeigen.TabIndex = 2;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(60, 39);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(35, 13);
            this.LblAusgabe.TabIndex = 3;
            this.LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdAnzeigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdAnzeigen;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

