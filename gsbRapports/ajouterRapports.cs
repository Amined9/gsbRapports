using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.SqlServer.Types;

namespace gsbRapports
{
    public partial class ajouterRapports : Form
    {
        private gsbrapportsEntities mesDonnees;
        public ajouterRapports(gsbrapportsEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgrapport.DataSource = mesDonnees.rapport.ToList();
            this.bdgrapport.DataSource = mesDonnees.visiteur.ToList();
            this.bdgrapport.DataSource = mesDonnees.medecin.ToList();
            this.bdgrapport.DataSource = mesDonnees.famille.ToList();
        }

        private void ajouterRapports_Load(object sender, EventArgs e)
        {
            // Charger les données des visiteurs dans la ComboBox cmbvisiteur
            cmbvisiteur.DataSource = mesDonnees.visiteur.ToList();
            cmbvisiteur.DisplayMember = "nom"; // Remplacer "NomComplet" par le nom de la propriété à afficher dans la ComboBox
            cmbvisiteur.ValueMember = "id"; // Remplacer "Id" par le nom de la propriété qui représente la valeur sélectionnée dans la ComboBox
            // Charger les données des médicaments dans la ComboBox cmbmedicament
            cmbmedicament.DataSource = mesDonnees.medicament.ToList();
            cmbmedicament.DisplayMember = "nomCommercial"; // Remplacer "NomMedicament" par le nom de la propriété à afficher dans la ComboBox
            cmbmedicament.ValueMember = "id"; // Remplacer "Id" par le nom de la propriété qui représente la valeur sélectionnée dans la ComboBox
            // Charger les données des médecins dans la ComboBox cmbmedecin
            cmbmedecin.DataSource = mesDonnees.medecin.ToList();
            cmbmedecin.DisplayMember = "nom"; // Remplacer "NomComplet" par le nom de la propriété à afficher dans la ComboBox
            cmbmedecin.ValueMember = "id";
        }


        private int getNumRapport()
        {
            var reqDernier = (from rapport in this.mesDonnees.rapport
                              orderby rapport.id descending
                              select rapport);
            rapport dernierRapport = reqDernier.FirstOrDefault();
            int n = dernierRapport.id + 1;
            return n;
        }

        private rapport newRapport()
        {
            rapport newrapport = new rapport();
            newrapport.id = getNumRapport();
            newrapport.date = dtdate.Value;
            newrapport.motif = txtmotif.Text;
            newrapport.bilan = txtbilan.Text;
            newrapport.idVisiteur = cmbvisiteur.SelectedValue.ToString();
            newrapport.idMedecin = int.Parse(cmbmedecin.SelectedValue.ToString()); // Assurez-vous que ceci renvoie l'ID correct du médecin
            return newrapport;
        }



        private void btnvalider_Click(object sender, EventArgs e)
        {
            try
            {
                this.mesDonnees.rapport.Add(newRapport());
                this.mesDonnees.SaveChanges();
                MessageBox.Show("Enregistrer");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement: {ex.Message.ToUpper()}");                 
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bdgrapport_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
