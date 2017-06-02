namespace VB2_2017
{
    partial class SchiffeVersenkenForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchiffeVersenkenForm));
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.btnRadar = new System.Windows.Forms.Button();
            this.btnBestenliste = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblVersuche = new System.Windows.Forms.Label();
            this.lblVersucheEff = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblZeitEff = new System.Windows.Forms.Label();
            this.ckbZufaelligesSpiel = new System.Windows.Forms.CheckBox();
            this.lblGeloest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 1000;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // btnRadar
            // 
            this.btnRadar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRadar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRadar.Location = new System.Drawing.Point(11, 158);
            this.btnRadar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRadar.Name = "btnRadar";
            this.btnRadar.Size = new System.Drawing.Size(100, 28);
            this.btnRadar.TabIndex = 110;
            this.btnRadar.Text = "Radar";
            this.btnRadar.UseVisualStyleBackColor = false;
            this.btnRadar.Click += new System.EventHandler(this.btnRadar_Click);
            this.btnRadar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRadar_MouseDown);
            this.btnRadar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRadar_MouseUp);
            // 
            // btnBestenliste
            // 
            this.btnBestenliste.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBestenliste.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBestenliste.Location = new System.Drawing.Point(11, 194);
            this.btnBestenliste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBestenliste.Name = "btnBestenliste";
            this.btnBestenliste.Size = new System.Drawing.Size(100, 28);
            this.btnBestenliste.TabIndex = 111;
            this.btnBestenliste.TabStop = false;
            this.btnBestenliste.Text = "Bestenliste";
            this.btnBestenliste.UseVisualStyleBackColor = false;
            this.btnBestenliste.Click += new System.EventHandler(this.btnBestenliste_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Location = new System.Drawing.Point(116, 158);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 112;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // lblVersuche
            // 
            this.lblVersuche.AutoSize = true;
            this.lblVersuche.Location = new System.Drawing.Point(8, 41);
            this.lblVersuche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersuche.Name = "lblVersuche";
            this.lblVersuche.Size = new System.Drawing.Size(72, 17);
            this.lblVersuche.TabIndex = 113;
            this.lblVersuche.Text = "Versuche:";
            // 
            // lblVersucheEff
            // 
            this.lblVersucheEff.AutoSize = true;
            this.lblVersucheEff.Location = new System.Drawing.Point(115, 41);
            this.lblVersucheEff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersucheEff.Name = "lblVersucheEff";
            this.lblVersucheEff.Size = new System.Drawing.Size(16, 17);
            this.lblVersucheEff.TabIndex = 114;
            this.lblVersucheEff.Text = "0";
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(8, 68);
            this.lblZeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(36, 17);
            this.lblZeit.TabIndex = 115;
            this.lblZeit.Text = "Zeit:";
            // 
            // lblZeitEff
            // 
            this.lblZeitEff.AutoSize = true;
            this.lblZeitEff.Location = new System.Drawing.Point(115, 68);
            this.lblZeitEff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZeitEff.Name = "lblZeitEff";
            this.lblZeitEff.Size = new System.Drawing.Size(16, 17);
            this.lblZeitEff.TabIndex = 116;
            this.lblZeitEff.Text = "0";
            // 
            // ckbZufaelligesSpiel
            // 
            this.ckbZufaelligesSpiel.AutoSize = true;
            this.ckbZufaelligesSpiel.BackColor = System.Drawing.Color.White;
            this.ckbZufaelligesSpiel.Location = new System.Drawing.Point(12, 121);
            this.ckbZufaelligesSpiel.Margin = new System.Windows.Forms.Padding(2);
            this.ckbZufaelligesSpiel.Name = "ckbZufaelligesSpiel";
            this.ckbZufaelligesSpiel.Size = new System.Drawing.Size(124, 21);
            this.ckbZufaelligesSpiel.TabIndex = 117;
            this.ckbZufaelligesSpiel.Text = "zufälliges Spiel";
            this.ckbZufaelligesSpiel.UseVisualStyleBackColor = false;
            this.ckbZufaelligesSpiel.CheckedChanged += new System.EventHandler(this.ckbZufaelligesSpiel_CheckedChanged);
            // 
            // lblGeloest
            // 
            this.lblGeloest.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGeloest.Font = new System.Drawing.Font("Segoe UI Semilight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeloest.Location = new System.Drawing.Point(12, 9);
            this.lblGeloest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGeloest.Name = "lblGeloest";
            this.lblGeloest.Size = new System.Drawing.Size(575, 499);
            this.lblGeloest.TabIndex = 118;
            this.lblGeloest.Text = "Gelöst";
            this.lblGeloest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblVersuche);
            this.groupBox1.Controls.Add(this.btnRadar);
            this.groupBox1.Controls.Add(this.ckbZufaelligesSpiel);
            this.groupBox1.Controls.Add(this.btnBestenliste);
            this.groupBox1.Controls.Add(this.lblZeitEff);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lblZeit);
            this.groupBox1.Controls.Add(this.lblVersucheEff);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(599, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(221, 316);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 241);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // SchiffeVersenkenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(832, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGeloest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SchiffeVersenkenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schiffe versenken";
            this.Load += new System.EventHandler(this.SchiffeVersenkenForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Button btnRadar;
        private System.Windows.Forms.Button btnBestenliste;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblVersuche;
        private System.Windows.Forms.Label lblVersucheEff;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label lblZeitEff;
        private System.Windows.Forms.CheckBox ckbZufaelligesSpiel;
        private System.Windows.Forms.Label lblGeloest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

