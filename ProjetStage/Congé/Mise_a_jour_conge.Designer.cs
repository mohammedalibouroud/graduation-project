namespace ProjetStage.Congé
{
    partial class Mise_a_jour_conge
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcumulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateretourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibiliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDecisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDecisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCessationSvcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRepriseSvcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congeEtrangerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cUMULCONGEDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUMULCONGEDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcumulDataGridViewTextBoxColumn,
            this.datedepartDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.dateretourDataGridViewTextBoxColumn,
            this.disponibiliteDataGridViewTextBoxColumn,
            this.observationDataGridViewTextBoxColumn,
            this.congeDataGridViewTextBoxColumn,
            this.numDecisionDataGridViewTextBoxColumn,
            this.dateDecisionDataGridViewTextBoxColumn,
            this.dateCessationSvcDataGridViewTextBoxColumn,
            this.dateRepriseSvcDataGridViewTextBoxColumn,
            this.congeEtrangerDataGridViewCheckBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.DataSource = this.cUMULCONGEDataTableBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(36, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(842, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idcumulDataGridViewTextBoxColumn
            // 
            this.idcumulDataGridViewTextBoxColumn.DataPropertyName = "Id_cumul";
            this.idcumulDataGridViewTextBoxColumn.HeaderText = "Id_cumul";
            this.idcumulDataGridViewTextBoxColumn.Name = "idcumulDataGridViewTextBoxColumn";
            this.idcumulDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcumulDataGridViewTextBoxColumn.Visible = false;
            // 
            // datedepartDataGridViewTextBoxColumn
            // 
            this.datedepartDataGridViewTextBoxColumn.DataPropertyName = "Date_depart";
            this.datedepartDataGridViewTextBoxColumn.HeaderText = "Date départ";
            this.datedepartDataGridViewTextBoxColumn.Name = "datedepartDataGridViewTextBoxColumn";
            this.datedepartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "Duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "Durée";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            this.dureeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateretourDataGridViewTextBoxColumn
            // 
            this.dateretourDataGridViewTextBoxColumn.DataPropertyName = "Date_retour";
            this.dateretourDataGridViewTextBoxColumn.HeaderText = "Date retour";
            this.dateretourDataGridViewTextBoxColumn.Name = "dateretourDataGridViewTextBoxColumn";
            this.dateretourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disponibiliteDataGridViewTextBoxColumn
            // 
            this.disponibiliteDataGridViewTextBoxColumn.DataPropertyName = "Disponibilite";
            this.disponibiliteDataGridViewTextBoxColumn.HeaderText = "Disponibilite";
            this.disponibiliteDataGridViewTextBoxColumn.Name = "disponibiliteDataGridViewTextBoxColumn";
            this.disponibiliteDataGridViewTextBoxColumn.ReadOnly = true;
            this.disponibiliteDataGridViewTextBoxColumn.Visible = false;
            // 
            // observationDataGridViewTextBoxColumn
            // 
            this.observationDataGridViewTextBoxColumn.DataPropertyName = "Observation";
            this.observationDataGridViewTextBoxColumn.HeaderText = "Observation";
            this.observationDataGridViewTextBoxColumn.Name = "observationDataGridViewTextBoxColumn";
            this.observationDataGridViewTextBoxColumn.ReadOnly = true;
            this.observationDataGridViewTextBoxColumn.Visible = false;
            // 
            // congeDataGridViewTextBoxColumn
            // 
            this.congeDataGridViewTextBoxColumn.DataPropertyName = "Conge";
            this.congeDataGridViewTextBoxColumn.HeaderText = "Conge";
            this.congeDataGridViewTextBoxColumn.Name = "congeDataGridViewTextBoxColumn";
            this.congeDataGridViewTextBoxColumn.ReadOnly = true;
            this.congeDataGridViewTextBoxColumn.Visible = false;
            // 
            // numDecisionDataGridViewTextBoxColumn
            // 
            this.numDecisionDataGridViewTextBoxColumn.DataPropertyName = "NumDecision";
            this.numDecisionDataGridViewTextBoxColumn.HeaderText = "NumDecision";
            this.numDecisionDataGridViewTextBoxColumn.Name = "numDecisionDataGridViewTextBoxColumn";
            this.numDecisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDecisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDecisionDataGridViewTextBoxColumn
            // 
            this.dateDecisionDataGridViewTextBoxColumn.DataPropertyName = "DateDecision";
            this.dateDecisionDataGridViewTextBoxColumn.HeaderText = "DateDecision";
            this.dateDecisionDataGridViewTextBoxColumn.Name = "dateDecisionDataGridViewTextBoxColumn";
            this.dateDecisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDecisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateCessationSvcDataGridViewTextBoxColumn
            // 
            this.dateCessationSvcDataGridViewTextBoxColumn.DataPropertyName = "DateCessationSvc";
            this.dateCessationSvcDataGridViewTextBoxColumn.HeaderText = "DateCessationSvc";
            this.dateCessationSvcDataGridViewTextBoxColumn.Name = "dateCessationSvcDataGridViewTextBoxColumn";
            this.dateCessationSvcDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateCessationSvcDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateRepriseSvcDataGridViewTextBoxColumn
            // 
            this.dateRepriseSvcDataGridViewTextBoxColumn.DataPropertyName = "DateRepriseSvc";
            this.dateRepriseSvcDataGridViewTextBoxColumn.HeaderText = "DateRepriseSvc";
            this.dateRepriseSvcDataGridViewTextBoxColumn.Name = "dateRepriseSvcDataGridViewTextBoxColumn";
            this.dateRepriseSvcDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateRepriseSvcDataGridViewTextBoxColumn.Visible = false;
            // 
            // congeEtrangerDataGridViewCheckBoxColumn
            // 
            this.congeEtrangerDataGridViewCheckBoxColumn.DataPropertyName = "CongeEtranger";
            this.congeEtrangerDataGridViewCheckBoxColumn.FillWeight = 300F;
            this.congeEtrangerDataGridViewCheckBoxColumn.HeaderText = "Conge à l\'étranger";
            this.congeEtrangerDataGridViewCheckBoxColumn.Name = "congeEtrangerDataGridViewCheckBoxColumn";
            this.congeEtrangerDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Modifier";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Supprimer";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Aperçu la décision";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "Cessation/Reprise";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // cUMULCONGEDataTableBindingSource
            // 
            this.cUMULCONGEDataTableBindingSource.DataSource = typeof(PrejetStage_Library.DsProjet.CUMUL_CONGEDataTable);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(432, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 126;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(199, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 125;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mise_a_jour_conge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mise_a_jour_conge";
            this.Text = "Mise à jour conge";
            this.Load += new System.EventHandler(this.Mise_a_jour_conge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUMULCONGEDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cUMULCONGEDataTableBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcumulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateretourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibiliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDecisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDecisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCessationSvcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRepriseSvcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn congeEtrangerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}