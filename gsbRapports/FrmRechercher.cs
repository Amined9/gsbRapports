using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmRechercher : Form
    {
        private gsbrapportsEntities mesDonnees;
        public FrmRechercher(gsbrapportsEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.cmbdate.DataSource = mesDonnees.rapport.ToList();
            this.bdgrapport.DataSource = mesDonnees.rapport.ToList();
            this.bdgvisiteur.DataSource = mesDonnees.visiteur.ToList();

        }

        private void FrmRechercher_Load(object sender, EventArgs e)
        {
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
