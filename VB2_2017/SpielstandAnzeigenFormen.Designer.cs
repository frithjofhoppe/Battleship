namespace VB2_2017
{
    partial class SpielstandAnzeigenFormen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpielstandAnzeigenFormen));
            this.lblBestenliste = new System.Windows.Forms.Label();
            this.txtBestenliste = new System.Windows.Forms.TextBox();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBestenliste
            // 
            this.lblBestenliste.AutoSize = true;
            this.lblBestenliste.Location = new System.Drawing.Point(9, 15);
            this.lblBestenliste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBestenliste.Name = "lblBestenliste";
            this.lblBestenliste.Size = new System.Drawing.Size(96, 13);
            this.lblBestenliste.TabIndex = 0;
            this.lblBestenliste.Text = "Unsere Champions";
            // 
            // txtBestenliste
            // 
            this.txtBestenliste.Location = new System.Drawing.Point(11, 59);
            this.txtBestenliste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBestenliste.Multiline = true;
            this.txtBestenliste.Name = "txtBestenliste";
            this.txtBestenliste.ReadOnly = true;
            this.txtBestenliste.Size = new System.Drawing.Size(240, 118);
            this.txtBestenliste.TabIndex = 1;
            this.txtBestenliste.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(11, 198);
            this.btnSchliessen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(94, 30);
            this.btnSchliessen.TabIndex = 2;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // SpielstandAnzeigenFormen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 249);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.txtBestenliste);
            this.Controls.Add(this.lblBestenliste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpielstandAnzeigenFormen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestenliste";
            this.Load += new System.EventHandler(this.SpielstandAnzeigenFormen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBestenliste;
        private System.Windows.Forms.TextBox txtBestenliste;
        private System.Windows.Forms.Button btnSchliessen;
    }
}