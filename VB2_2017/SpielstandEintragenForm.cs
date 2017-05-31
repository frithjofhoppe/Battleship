using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VB2_2017
{
    public partial class SpielstandEintragenForm : Form
    {
        public string punkte { get; set; }
        public string zeit { get; set; }
        public string pfad { get; set; }

        private List<String> daten = new List<string>();

        public SpielstandEintragenForm()
        {
            InitializeComponent();
        }

        private void SpielstandEintragenForm_Load(object sender, EventArgs e)
        {
            ausgeben();
        }

        private void ausgeben()
        {
            lblPunkte.Text = punkte;
            lblZeit.Text = zeit;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sie haben keinen Namen eingetragen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                daten.Add(txtName.Text + ";" + punkte + ";" + zeit);
                File.AppendAllLines(pfad,daten);
                daten.Clear();
                this.Close();
            }

            txtName.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSpeichern.PerformClick();
            }
        }
    }
}
