namespace ProjetStage.FrmEtat
{
    partial class frmFicheRenseignement
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Fiche_RenseignementDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Fiche_RenseignementDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Fiche_RenseignementDataTableBindingSource
            // 
            this.Fiche_RenseignementDataTableBindingSource.DataSource = typeof(PrejetStage_Library.DataSetRensein.Fiche_RenseignementDataTable);
            this.Fiche_RenseignementDataTableBindingSource.CurrentChanged += new System.EventHandler(this.Fiche_RenseignementDataTableBindingSource_CurrentChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Fiche_RenseignementDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetStage.Etat.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(596, 527);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmFicheRenseignement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 607);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFicheRenseignement";
            this.Text = "Fiche de renseignement";
            this.Load += new System.EventHandler(this.frmFicheRenseignement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fiche_RenseignementDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Fiche_RenseignementDataTableBindingSource;
    }
}