using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.bdgrapport.DataSource = mesDonnees.rapport.ToList();
            this.bdgvisiteur.DataSource = mesDonnees.visiteur.ToList().Distinct();
            //this.cmbdate.DataSource = mesDonnees.rapport.ToList();
            //this.InitializeComboBoxVisiteur();
            this.InitializeComboBoxDates();
            this.dgvrapport.CellEndEdit += new DataGridViewCellEventHandler(bdgrapport_CellEndEdit);

        }
        private void FrmRechercher_Load(object sender, EventArgs e)
        {

        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void cmbdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltersDate();
        }
        private void cmbvisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltersVisiteur();
        }
        private void InitializeComboBoxDates()
        {
            var dates = mesDonnees.rapport.Select(r => r.date).Distinct().ToList();
            this.cmbdate.DataSource = dates;
        }

        private void ApplyFilters()
        {
            var query = mesDonnees.rapport.AsQueryable();
            if (cmbdate.SelectedItem != null)
            {
                DateTime selectedDate = (DateTime)cmbdate.SelectedItem;
                query = query.Where(r => r.date == selectedDate);
            }
            if (cmbvisiteur.SelectedItem != null)
            {
                var selectedVisitor = (visiteur)cmbvisiteur.SelectedItem;
                query = query.Where(r => r.idVisiteur == selectedVisitor.id);
            }
            bdgrapport.DataSource = query.ToList();
        }
        public void FiltersDate()
        {
            if (cmbdate.SelectedItem != null)
            {
                DateTime selectedDate = (DateTime)cmbdate.SelectedItem;
                var filteredReports = mesDonnees.rapport.Where(r => r.date == selectedDate).ToList();
                bdgrapport.DataSource = filteredReports;
            }
        }
        public void FiltersVisiteur()
        {
            if (cmbvisiteur.SelectedItem != null)
            {
                visiteur selectedVisiteur = (visiteur)cmbvisiteur.SelectedItem;
                var filteredReports = mesDonnees.rapport.Where(r => r.idVisiteur == selectedVisiteur.id).ToList();
                bdgrapport.DataSource = filteredReports;
            }
        }

        private void bdgrapport_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid != null)
            {
                var row = grid.Rows[e.RowIndex];
                var updatedRapport = row.DataBoundItem as rapport;

                if (updatedRapport != null)
                {
                    var originalRapport = mesDonnees.rapport.Find(updatedRapport.id);
                    if (originalRapport != null)
                    {
                        mesDonnees.Entry(originalRapport).CurrentValues.SetValues(updatedRapport);
                        mesDonnees.SaveChanges();
                    }
                }
            }
        }

        private void btngenerer_Click(object sender, EventArgs e)
        {
            var dataTable = DataGridViewToDataTable(dgvrapport);
            SerializeDataTableToXml(dataTable);
        }

        private void SerializeDataTableToXml(DataTable dataTable)
        {
            string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            string filePath = Path.Combine(downloadsFolderPath, "Rapports.xml");
            var dataSet = new DataSet();

            dataSet.Tables.Add(dataTable);
            dataSet.WriteXml(filePath);

            MessageBox.Show($"Fichier enregitrer dans les telechargements : {filePath}");
        }

        private DataTable DataGridViewToDataTable(DataGridView dgv)
        {
            var dt = new DataTable();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                Type columnType = column.ValueType;
                if (columnType.IsGenericType && columnType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    columnType = Nullable.GetUnderlyingType(columnType);
                }
                dt.Columns.Add(column.Name, columnType);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var rowValues = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value ?? DBNull.Value).ToArray();
                    dt.Rows.Add(rowValues);
                }
            }

            return dt;
        }



    }
}
