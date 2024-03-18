namespace gsbRapports
{
    partial class ajouterRapports
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
            this.cmbvisiteur = new System.Windows.Forms.ComboBox();
            this.bdgrapport = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmedicament = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmedecin = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmotif = new System.Windows.Forms.TextBox();
            this.txtbilan = new System.Windows.Forms.TextBox();
            this.btnvalider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgrapport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbvisiteur
            // 
            this.cmbvisiteur.FormattingEnabled = true;
            this.cmbvisiteur.Location = new System.Drawing.Point(283, 49);
            this.cmbvisiteur.Name = "cmbvisiteur";
            this.cmbvisiteur.Size = new System.Drawing.Size(121, 24);
            this.cmbvisiteur.TabIndex = 0;
            // 
            // bdgrapport
            // 
            this.bdgrapport.DataSource = typeof(gsbRapports.gsb2021Entities);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visiteur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medicament";
            // 
            // cmbmedicament
            // 
            this.cmbmedicament.FormattingEnabled = true;
            this.cmbmedicament.Location = new System.Drawing.Point(283, 150);
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.Size = new System.Drawing.Size(121, 24);
            this.cmbmedicament.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medecin";
            // 
            // cmbmedecin
            // 
            this.cmbmedecin.FormattingEnabled = true;
            this.cmbmedecin.Location = new System.Drawing.Point(283, 97);
            this.cmbmedecin.Name = "cmbmedecin";
            this.cmbmedecin.Size = new System.Drawing.Size(121, 24);
            this.cmbmedecin.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(148, 206);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 16);
            this.Date.TabIndex = 6;
            this.Date.Text = "Date";
            // 
            // dtdate
            // 
            this.dtdate.Location = new System.Drawing.Point(283, 200);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(200, 22);
            this.dtdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Motif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bilan";
            // 
            // txtmotif
            // 
            this.txtmotif.Location = new System.Drawing.Point(283, 246);
            this.txtmotif.Name = "txtmotif";
            this.txtmotif.Size = new System.Drawing.Size(100, 22);
            this.txtmotif.TabIndex = 10;
            // 
            // txtbilan
            // 
            this.txtbilan.Location = new System.Drawing.Point(283, 293);
            this.txtbilan.Name = "txtbilan";
            this.txtbilan.Size = new System.Drawing.Size(100, 22);
            this.txtbilan.TabIndex = 11;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(226, 360);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(75, 23);
            this.btnvalider.TabIndex = 12;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            // 
            // ajouterRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.txtbilan);
            this.Controls.Add(this.txtmotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbmedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbmedicament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbvisiteur);
            this.Name = "ajouterRapports";
            this.Text = "ajouterRapports";
            this.Load += new System.EventHandler(this.ajouterRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgrapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbvisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmedicament;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmedecin;
        private System.Windows.Forms.BindingSource bdgrapport;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmotif;
        private System.Windows.Forms.TextBox txtbilan;
        private System.Windows.Forms.Button btnvalider;
    }
}