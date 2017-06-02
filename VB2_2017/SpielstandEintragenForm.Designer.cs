namespace VB2_2017
{
    partial class SpielstandEintragenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpielstandEintragenForm));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(212, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Geben sie bitte Ihren Namen ein";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(15, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 47);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameKey);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(15, 144);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(117, 37);
            this.btnAbbrechen.TabIndex = 2;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(139, 144);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(117, 37);
            this.btnSpeichern.TabIndex = 3;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // lblPunkte
            // 
            this.lblPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunkte.Location = new System.Drawing.Point(261, 71);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(53, 47);
            this.lblPunkte.TabIndex = 4;
            this.lblPunkte.Text = "label1";
            this.lblPunkte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZeit
            // 
            this.lblZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeit.Location = new System.Drawing.Point(320, 71);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(53, 47);
            this.lblZeit.TabIndex = 5;
            this.lblZeit.Text = "label2";
            this.lblZeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Punkte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zeit";
            // 
            // SpielstandEintragenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpielstandEintragenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spielstand eintragen";
            this.Load += new System.EventHandler(this.SpielstandEintragenForm_Load);
            this.Shown += new System.EventHandler(this.SpielstandEintragenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}