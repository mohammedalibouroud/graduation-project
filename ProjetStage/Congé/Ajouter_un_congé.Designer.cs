namespace ProjetStage.Congé
{
    partial class Ajouter_un_congé
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_un_congé));
            this.label1 = new System.Windows.Forms.Label();
            this.datedepart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtduree = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dateretour = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDisponibilite = new System.Windows.Forms.TextBox();
            this.txtobservation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelJour = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnCalendar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelReporterConge = new System.Windows.Forms.Panel();
            this.radioButtonNon = new System.Windows.Forms.RadioButton();
            this.radioButtonOui = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).BeginInit();
            this.panelReporterConge.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date départ :";
            // 
            // datedepart
            // 
            this.datedepart.Enabled = false;
            this.datedepart.Location = new System.Drawing.Point(142, 60);
            this.datedepart.Name = "datedepart";
            this.datedepart.Size = new System.Drawing.Size(200, 20);
            this.datedepart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Durée :";
            // 
            // txtduree
            // 
            this.txtduree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtduree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtduree.ForeColor = System.Drawing.Color.Black;
            this.txtduree.HintForeColor = System.Drawing.Color.Empty;
            this.txtduree.HintText = "";
            this.txtduree.isPassword = false;
            this.txtduree.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtduree.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtduree.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtduree.LineThickness = 3;
            this.txtduree.Location = new System.Drawing.Point(142, 87);
            this.txtduree.Margin = new System.Windows.Forms.Padding(4);
            this.txtduree.Name = "txtduree";
            this.txtduree.Size = new System.Drawing.Size(52, 31);
            this.txtduree.TabIndex = 4;
            this.txtduree.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateretour
            // 
            this.dateretour.Enabled = false;
            this.dateretour.Location = new System.Drawing.Point(142, 142);
            this.dateretour.Name = "dateretour";
            this.dateretour.Size = new System.Drawing.Size(200, 20);
            this.dateretour.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date prévu de retour :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Disponibilité\r\nen cas de besoin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observations :";
            // 
            // txtDisponibilite
            // 
            this.txtDisponibilite.Location = new System.Drawing.Point(142, 226);
            this.txtDisponibilite.Multiline = true;
            this.txtDisponibilite.Name = "txtDisponibilite";
            this.txtDisponibilite.Size = new System.Drawing.Size(200, 54);
            this.txtDisponibilite.TabIndex = 9;
            this.txtDisponibilite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtobservation
            // 
            this.txtobservation.Location = new System.Drawing.Point(142, 295);
            this.txtobservation.Multiline = true;
            this.txtobservation.Name = "txtobservation";
            this.txtobservation.Size = new System.Drawing.Size(200, 54);
            this.txtobservation.TabIndex = 10;
            this.txtobservation.Text = "Rien à signaler";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(227, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 158;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelJour
            // 
            this.LabelJour.AutoSize = true;
            this.LabelJour.Location = new System.Drawing.Point(201, 105);
            this.LabelJour.Name = "LabelJour";
            this.LabelJour.Size = new System.Drawing.Size(0, 13);
            this.LabelJour.TabIndex = 159;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Location = new System.Drawing.Point(47, 368);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 29);
            this.btnAjouter.TabIndex = 160;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.White;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageActive = null;
            this.btnCalendar.Location = new System.Drawing.Point(296, 86);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(46, 46);
            this.btnCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCalendar.TabIndex = 161;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.Zoom = 10;
            this.btnCalendar.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panelReporterConge
            // 
            this.panelReporterConge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReporterConge.Controls.Add(this.radioButtonNon);
            this.panelReporterConge.Controls.Add(this.radioButtonOui);
            this.panelReporterConge.Location = new System.Drawing.Point(142, 177);
            this.panelReporterConge.Name = "panelReporterConge";
            this.panelReporterConge.Size = new System.Drawing.Size(142, 33);
            this.panelReporterConge.TabIndex = 179;
            // 
            // radioButtonNon
            // 
            this.radioButtonNon.AutoSize = true;
            this.radioButtonNon.Checked = true;
            this.radioButtonNon.Location = new System.Drawing.Point(91, 8);
            this.radioButtonNon.Name = "radioButtonNon";
            this.radioButtonNon.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNon.TabIndex = 3;
            this.radioButtonNon.TabStop = true;
            this.radioButtonNon.Text = "Non";
            this.radioButtonNon.UseVisualStyleBackColor = true;
            // 
            // radioButtonOui
            // 
            this.radioButtonOui.AutoSize = true;
            this.radioButtonOui.Location = new System.Drawing.Point(10, 8);
            this.radioButtonOui.Name = "radioButtonOui";
            this.radioButtonOui.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOui.TabIndex = 2;
            this.radioButtonOui.Text = "Oui";
            this.radioButtonOui.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 178;
            this.label6.Text = "congé à l\'étranger :";
            // 
            // Ajouter_un_congé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 417);
            this.Controls.Add(this.panelReporterConge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.LabelJour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtobservation);
            this.Controls.Add(this.txtDisponibilite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateretour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtduree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datedepart);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter_un_congé";
            this.Resizable = false;
            this.Text = "Ajouter un congé";
            this.Load += new System.EventHandler(this.Ajouter_un_congé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
            this.panelReporterConge.ResumeLayout(false);
            this.panelReporterConge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDisponibilite;
        private System.Windows.Forms.TextBox txtobservation;
        private System.Windows.Forms.Button button1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtduree;
        public System.Windows.Forms.DateTimePicker datedepart;
        public System.Windows.Forms.DateTimePicker dateretour;
        public System.Windows.Forms.Label LabelJour;
        private System.Windows.Forms.Button btnAjouter;
        private Bunifu.Framework.UI.BunifuImageButton btnCalendar;
        private System.Windows.Forms.Panel panelReporterConge;
        private System.Windows.Forms.RadioButton radioButtonNon;
        private System.Windows.Forms.RadioButton radioButtonOui;
        private System.Windows.Forms.Label label6;
    }
}