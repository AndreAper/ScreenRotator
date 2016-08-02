namespace ScreenRotator
{
    partial class frmMain
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
            this.btnPortrait = new System.Windows.Forms.Button();
            this.btnLandscape = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPortrait
            // 
            this.btnPortrait.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPortrait.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPortrait.FlatAppearance.BorderSize = 5;
            this.btnPortrait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortrait.Location = new System.Drawing.Point(227, 21);
            this.btnPortrait.Name = "btnPortrait";
            this.btnPortrait.Size = new System.Drawing.Size(135, 185);
            this.btnPortrait.TabIndex = 0;
            this.btnPortrait.Text = "Portrait";
            this.btnPortrait.UseVisualStyleBackColor = false;
            this.btnPortrait.Click += new System.EventHandler(this.btnPortrait_Click);
            // 
            // btnLandscape
            // 
            this.btnLandscape.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLandscape.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLandscape.FlatAppearance.BorderSize = 5;
            this.btnLandscape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLandscape.Location = new System.Drawing.Point(21, 46);
            this.btnLandscape.Name = "btnLandscape";
            this.btnLandscape.Size = new System.Drawing.Size(185, 135);
            this.btnLandscape.TabIndex = 0;
            this.btnLandscape.Text = "Landscape";
            this.btnLandscape.UseVisualStyleBackColor = false;
            this.btnLandscape.Click += new System.EventHandler(this.btnLandscape_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(341, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 303);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLandscape);
            this.Controls.Add(this.btnPortrait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "SwitchOrientation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPortrait;
        private System.Windows.Forms.Button btnLandscape;
        private System.Windows.Forms.Button btnClose;
    }
}

