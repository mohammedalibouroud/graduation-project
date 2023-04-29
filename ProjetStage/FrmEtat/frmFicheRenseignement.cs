using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrejetStage_Library;
namespace ProjetStage.FrmEtat
{
    public partial class frmFicheRenseignement : MetroFramework.Forms.MetroForm
    {
        public frmFicheRenseignement()
        {
            InitializeComponent();
        }

        private void frmFicheRenseignement_Load(object sender, EventArgs e)
        {
            Fiche_RenseignementDataTableBindingSource.DataSource = MyDataBase.fiche_renseignement(Program.ppr);
            this.reportViewer1.RefreshReport();
        }

        private void Fiche_RenseignementDataTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
