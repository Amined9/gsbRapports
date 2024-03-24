namespace gsbRapports
{
    partial class FrmRechercher
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
            this.components = new System.ComponentModel.Container();
            this.labelvisiteur = new System.Windows.Forms.Label();
            this.cmbvisiteur = new System.Windows.Forms.ComboBox();
            this.bdgvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.labeldate = new System.Windows.Forms.Label();
            this.cmbdate = new System.Windows.Forms.ComboBox();
            this.bdgdate = new System.Windows.Forms.BindingSource(this.components);
            this.dgvrapport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgrapport = new System.Windows.Forms.BindingSource(this.components);
            this.btnfiltrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgrapport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelvisiteur
            // 
            this.labelvisiteur.AutoSize = true;
            this.labelvisiteur.Location = new System.Drawing.Point(92, 54);
            this.labelvisiteur.Name = "labelvisiteur";
            this.labelvisiteur.Size = new System.Drawing.Size(41, 13);
            this.labelvisiteur.TabIndex = 0;
            this.labelvisiteur.Text = "Visiteur";
            // 
            // cmbvisiteur
            // 
            this.cmbvisiteur.DataSource = this.bdgvisiteur;
            this.cmbvisiteur.DisplayMember = "nom";
            this.cmbvisiteur.FormattingEnabled = true;
            this.cmbvisiteur.Location = new System.Drawing.Point(174, 51);
            this.cmbvisiteur.Name = "cmbvisiteur";
            this.cmbvisiteur.Size = new System.Drawing.Size(181, 21);
            this.cmbvisiteur.TabIndex = 1;
            // 
            // bdgvisiteur
            // 
            this.bdgvisiteur.DataSource = typeof(gsbRapports.visiteur);
            this.bdgvisiteur.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(92, 94);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(30, 13);
            this.labeldate.TabIndex = 2;
            this.labeldate.Text = "Date";
            // 
            // cmbdate
            // 
            this.cmbdate.DataSource = this.bdgdate;
            this.cmbdate.DisplayMember = "date";
            this.cmbdate.FormattingEnabled = true;
            this.cmbdate.Location = new System.Drawing.Point(174, 91);
            this.cmbdate.Name = "cmbdate";
            this.cmbdate.Size = new System.Drawing.Size(181, 21);
            this.cmbdate.TabIndex = 3;
            // 
            // bdgdate
            // 
            this.bdgdate.DataSource = typeof(gsbRapports.rapport);
            // 
            // dgvrapport
            // 
            this.dgvrapport.AutoGenerateColumns = false;
            this.dgvrapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn,
            this.medecinDataGridViewTextBoxColumn,
            this.offrirDataGridViewTextBoxColumn,
            this.visiteurDataGridViewTextBoxColumn});
            this.dgvrapport.DataSource = this.bdgrapport;
            this.dgvrapport.Location = new System.Drawing.Point(95, 152);
            this.dgvrapport.Name = "dgvrapport";
            this.dgvrapport.RowHeadersWidth = 51;
            this.dgvrapport.Size = new System.Drawing.Size(643, 150);
            this.dgvrapport.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.Width = 125;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            this.bilanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            this.idVisiteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.Width = 125;
            // 
            // medecinDataGridViewTextBoxColumn
            // 
            this.medecinDataGridViewTextBoxColumn.DataPropertyName = "medecin";
            this.medecinDataGridViewTextBoxColumn.HeaderText = "medecin";
            this.medecinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medecinDataGridViewTextBoxColumn.Name = "medecinDataGridViewTextBoxColumn";
            this.medecinDataGridViewTextBoxColumn.Width = 125;
            // 
            // offrirDataGridViewTextBoxColumn
            // 
            this.offrirDataGridViewTextBoxColumn.DataPropertyName = "offrir";
            this.offrirDataGridViewTextBoxColumn.HeaderText = "offrir";
            this.offrirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offrirDataGridViewTextBoxColumn.Name = "offrirDataGridViewTextBoxColumn";
            this.offrirDataGridViewTextBoxColumn.Width = 125;
            // 
            // visiteurDataGridViewTextBoxColumn
            // 
            this.visiteurDataGridViewTextBoxColumn.DataPropertyName = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.HeaderText = "visiteur";
            this.visiteurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visiteurDataGridViewTextBoxColumn.Name = "visiteurDataGridViewTextBoxColumn";
            this.visiteurDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdgrapport
            // 
            this.bdgrapport.DataSource = typeof(gsbRapports.rapport);
            // 
            // btnfiltrer
            // 
            this.btnfiltrer.Location = new System.Drawing.Point(406, 51);
            this.btnfiltrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnfiltrer.Name = "btnfiltrer";
            this.btnfiltrer.Size = new System.Drawing.Size(56, 19);
            this.btnfiltrer.TabIndex = 6;
            this.btnfiltrer.Text = "Filtrer";
            this.btnfiltrer.UseVisualStyleBackColor = true;
            this.btnfiltrer.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbvisiteur);
            this.Controls.Add(this.btnfiltrer);
            this.Controls.Add(this.labelvisiteur);
            this.Controls.Add(this.dgvrapport);
            this.Controls.Add(this.cmbdate);
            this.Controls.Add(this.labeldate);
            this.Name = "FrmRechercher";
            this.Text = "FrmRechercher";
            this.Load += new System.EventHandler(this.FrmRechercher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgrapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelvisiteur;
        private System.Windows.Forms.ComboBox cmbvisiteur;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.ComboBox cmbdate;
        private System.Windows.Forms.DataGridView dgvrapport;
        private System.Windows.Forms.BindingSource bdgvisiteur;
        private System.Windows.Forms.BindingSource bdgdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdgrapport;
        private System.Windows.Forms.Button btnfiltrer;
    }
}