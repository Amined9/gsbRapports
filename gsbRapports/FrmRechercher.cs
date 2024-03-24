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
            //this.cmbdate.DataSource = mesDonnees.rapport.ToList();
            this.bdgrapport.DataSource = mesDonnees.rapport.ToList();
            this.bdgvisiteur.DataSource = mesDonnees.visiteur.ToList();
            this.InitializeComboBoxDates();

        }

        private void FrmRechercher_Load(object sender, EventArgs e)
        {

        }
        private void FilterReportsByDate()
        {
            if (cmbdate.SelectedItem != null)
            {
                DateTime selectedDate = (DateTime)cmbdate.SelectedItem;
                var filteredReports = mesDonnees.rapport.Where(r => r.date == selectedDate).ToList();
                bdgrapport.DataSource = filteredReports;
            }
        }
        private void InitializeComboBoxDates()
        {
            // Assuming your 'rapport' table has a 'Date' field that you want to filter by
            var dates = mesDonnees.rapport.Select(r => r.date).Distinct().ToList();
            this.cmbdate.DataSource = dates;
            // Set relevant properties if needed, like DisplayMember and ValueMember
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
