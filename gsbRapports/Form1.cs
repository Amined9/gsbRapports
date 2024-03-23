using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class Form1 : Form
    {
        private gsbrapportsEntities mesDonnees;
        public Form1()
        {
            this.InitializeComponent();
            this.mesDonnees = new gsbrapportsEntities();

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void médicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ajouterRapports frm = new ajouterRapports(this.mesDonnees);
            frm.MdiParent = this;
            frm.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercher f = new FrmRechercher(this.mesDonnees);
            f.MdiParent= this;
            f.Show();
        }
    }
}
