namespace ProjetStage.Congé
{
    partial class Modifier_un_conge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier_un_conge));
            this.btnCalendar = new Bunifu.Framework.UI.BunifuImageButton();
            this.LabelJour = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtobservation = new System.Windows.Forms.TextBox();
            this.txtDisponibilite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateretour = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtduree = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.datedepart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelReporterConge = new System.Windows.Forms.Panel();
            this.radioButtonNon = new System.Windows.Forms.RadioButton();
            this.radioButtonOui = new System.Windows.Forms.RadioButton();
            this.btnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).BeginInit();
            this.panelReporterConge.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.White;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageActive = null;
            this.btnCalendar.Location = new System.Drawing.Point(305, 99);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(46, 46);
            this.btnCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCalendar.TabIndex = 175;
            this.btnCalendar.TabStop = false;
            this.btnCalendar.Zoom = 10;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // LabelJour
            // 
            this.LabelJour.AutoSize = true;
            this.LabelJour.Location = new System.Drawing.Point(210, 118);
            this.LabelJour.Name = "LabelJour";
            this.LabelJour.Size = new System.Drawing.Size(0, 13);
            this.LabelJour.TabIndex = 173;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(236, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 172;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtobservation
            // 
            this.txtobservation.Location = new System.Drawing.Point(151, 303);
            this.txtobservation.Multiline = true;
            this.txtobservation.Name = "txtobservation";
            this.txtobservation.Size = new System.Drawing.Size(200, 54);
            this.txtobservation.TabIndex = 171;
            this.txtobservation.Text = "Rien à signaler";
            // 
            // txtDisponibilite
            // 
            this.txtDisponibilite.Location = new System.Drawing.Point(151, 234);
            this.txtDisponibilite.Multiline = true;
            this.txtDisponibilite.Name = "txtDisponibilite";
            this.txtDisponibilite.Size = new System.Drawing.Size(200, 54);
            this.txtDisponibilite.TabIndex = 170;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 169;
            this.label5.Text = "Observations :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 168;
            this.label4.Text = "Disponibilité\r\nen cas de besoin :";
            // 
            // dateretour
            // 
            this.dateretour.Enabled = false;
            this.dateretour.Location = new System.Drawing.Point(151, 155);
            this.dateretour.Name = "dateretour";
            this.dateretour.Size = new System.Drawing.Size(200, 20);
            this.dateretour.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 166;
            this.label3.Text = "Date prévu de retour :";
            // 
            // txtduree
            // 
            this.txtduree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtduree.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtduree.ForeColor = System.Drawing.Color.Black;
            this.txtduree.HintForeColor = System.Drawing.Color.Empty;
            this.txtduree.HintText = "";
            this.txtduree.isPassword = false;
            this.txtduree.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtduree.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtduree.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtduree.LineThickness = 3;
            this.txtduree.Location = new System.Drawing.Point(151, 100);
            this.txtduree.Margin = new System.Windows.Forms.Padding(4);
            this.txtduree.Name = "txtduree";
            this.txtduree.Size = new System.Drawing.Size(52, 31);
            this.txtduree.TabIndex = 165;
            this.txtduree.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 164;
            this.label2.Text = "Durée :";
            // 
            // datedepart
            // 
            this.datedepart.Enabled = false;
            this.datedepart.Location = new System.Drawing.Point(151, 73);
            this.datedepart.Name = "datedepart";
            this.datedepart.Size = new System.Drawing.Size(200, 20);
            this.datedepart.TabIndex = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 162;
            this.label1.Text = "Date départ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 176;
            this.label6.Text = "congé à l\'étranger :";
            // 
            // panelReporterConge
            // 
            this.panelReporterConge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReporterConge.Controls.Add(this.radioButtonNon);
            this.panelReporterConge.Controls.Add(this.radioButtonOui);
            this.panelReporterConge.Location = new System.Drawing.Point(151, 189);
            this.panelReporterConge.Name = "panelReporterConge";
            this.panelReporterConge.Size = new System.Drawing.Size(142, 33);
            this.panelReporterConge.TabIndex = 177;
            // 
            // radioButtonNon
            // 
            this.radioButtonNon.AutoSize = true;
            this.radioButtonNon.Checked = true;
            this.radioButtonNon.Location = new System.Drawing.Point(91, 8);
            this.radioButtonNon.Name = "radioButtonNon";
            this.radioButtonNon.Size = new System.Drawing.Size(44, 17);
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
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(43, 376);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 29);
            this.btnModifier.TabIndex = 178;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // Modifier_un_conge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 422);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.panelReporterConge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalendar);
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
            this.Name = "Modifier_un_conge";
            this.Text = "Modifier_un_conge";
            this.Load += new System.EventHandler(this.Modifier_un_conge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendar)).EndInit();
            this.panelReporterConge.ResumeLayout(false);
            this.panelReporterConge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnCalendar;
        public System.Windows.Forms.Label LabelJour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtobservation;
        private System.Windows.Forms.TextBox txtDisponibilite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateretour;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtduree;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker datedepart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelReporterConge;
        private System.Windows.Forms.RadioButton radioButtonNon;
        private System.Windows.Forms.RadioButton radioButtonOui;
        private System.Windows.Forms.Button btnModifier;
    }
}