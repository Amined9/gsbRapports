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
    public partial class ajouterRapports : Form
    {
        private gsb2021Entities mesDonnees;
        public ajouterRapports(gsb2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgrapport.DataSource = mesDonnees.rapports.ToList();
        }

        private void ajouterRapports_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
