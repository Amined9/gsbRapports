﻿using System;
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
        private gsb2021Entities mesDonnees;
        public FrmRechercher(gsb2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
        }
    }
}
