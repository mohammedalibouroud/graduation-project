namespace ProjetStage
{
    partial class NoteService
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
            this.txtDecision = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDecision = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonExep = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.radioButtonEp = new System.Windows.Forms.RadioButton();
            this.radioButtonNL = new System.Windows.Forms.RadioButton();
            this.radioButtonE = new System.Windows.Forms.RadioButton();
            this.radioButtonNR = new System.Windows.Forms.RadioButton();
            this.radioButtonNn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAnneeMVT = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMute = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnneeMVT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDecision
            // 
            this.txtDecision.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtDecision.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtDecision.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtDecision.BorderThickness = 3;
            this.txtDecision.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDecision.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDecision.ForeColor = System.Drawing.Color.Black;
            this.txtDecision.isPassword = false;
            this.txtDecision.Location = new System.Drawing.Point(136, 64);
            this.txtDecision.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.Size = new System.Drawing.Size(170, 28);
            this.txtDecision.TabIndex = 134;
            this.txtDecision.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Numéro décision :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 136;
            this.label2.Text = "Date décision :";
            // 
            // dateDecision
            // 
            this.dateDecision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDecision.Location = new System.Drawing.Point(416, 67);
            this.dateDecision.Name = "dateDecision";
            this.dateDecision.Size = new System.Drawing.Size(210, 21);
            this.dateDecision.TabIndex = 137;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonM);
            this.groupBox1.Controls.Add(this.radioButtonR);
            this.groupBox1.Location = new System.Drawing.Point(22, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 46);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Note";
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(112, 21);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(67, 17);
            this.radioButtonM.TabIndex = 1;
            this.radioButtonM.Text = "Mutation";
            this.radioButtonM.UseVisualStyleBackColor = true;
            this.radioButtonM.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Checked = true;
            this.radioButtonR.Location = new System.Drawing.Point(6, 21);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(87, 17);
            this.radioButtonR.TabIndex = 0;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "Récrutement";
            this.radioButtonR.UseVisualStyleBackColor = true;
            this.radioButtonR.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonExep);
            this.groupBox2.Controls.Add(this.radioButtonZ);
            this.groupBox2.Controls.Add(this.radioButtonEp);
            this.groupBox2.Controls.Add(this.radioButtonNL);
            this.groupBox2.Controls.Add(this.radioButtonE);
            this.groupBox2.Controls.Add(this.radioButtonNR);
            this.groupBox2.Controls.Add(this.radioButtonNn);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(22, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 124);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type Mouvement";
            // 
            // radioButtonExep
            // 
            this.radioButtonExep.AutoSize = true;
            this.radioButtonExep.Location = new System.Drawing.Point(15, 20);
            this.radioButtonExep.Name = "radioButtonExep";
            this.radioButtonExep.Size = new System.Drawing.Size(196, 17);
            this.radioButtonExep.TabIndex = 7;
            this.radioButtonExep.Text = "Exceptionnel de réunion de conjoint";
            this.radioButtonExep.UseVisualStyleBackColor = true;
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.Location = new System.Drawing.Point(15, 90);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(248, 17);
            this.radioButtonZ.TabIndex = 6;
            this.radioButtonZ.Text = "Zones difficiles à doter en ressources humains ";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonEp
            // 
            this.radioButtonEp.AutoSize = true;
            this.radioButtonEp.Location = new System.Drawing.Point(399, 20);
            this.radioButtonEp.Name = "radioButtonEp";
            this.radioButtonEp.Size = new System.Drawing.Size(169, 17);
            this.radioButtonEp.TabIndex = 5;
            this.radioButtonEp.Text = "Exceptionnel ‹‹ permutation ››";
            this.radioButtonEp.UseVisualStyleBackColor = true;
            // 
            // radioButtonNL
            // 
            this.radioButtonNL.AutoSize = true;
            this.radioButtonNL.Checked = true;
            this.radioButtonNL.Location = new System.Drawing.Point(15, 54);
            this.radioButtonNL.Name = "radioButtonNL";
            this.radioButtonNL.Size = new System.Drawing.Size(82, 17);
            this.radioButtonNL.TabIndex = 4;
            this.radioButtonNL.TabStop = true;
            this.radioButtonNL.Text = "Normal local";
            this.radioButtonNL.UseVisualStyleBackColor = true;
            // 
            // radioButtonE
            // 
            this.radioButtonE.AutoSize = true;
            this.radioButtonE.Location = new System.Drawing.Point(256, 20);
            this.radioButtonE.Name = "radioButtonE";
            this.radioButtonE.Size = new System.Drawing.Size(86, 17);
            this.radioButtonE.TabIndex = 3;
            this.radioButtonE.Text = "Exceptionnel";
            this.radioButtonE.UseVisualStyleBackColor = true;
            // 
            // radioButtonNR
            // 
            this.radioButtonNR.AutoSize = true;
            this.radioButtonNR.Location = new System.Drawing.Point(399, 54);
            this.radioButtonNR.Name = "radioButtonNR";
            this.radioButtonNR.Size = new System.Drawing.Size(99, 17);
            this.radioButtonNR.TabIndex = 2;
            this.radioButtonNR.Text = "Normal régional";
            this.radioButtonNR.UseVisualStyleBackColor = true;
            // 
            // radioButtonNn
            // 
            this.radioButtonNn.AutoSize = true;
            this.radioButtonNn.Location = new System.Drawing.Point(256, 54);
            this.radioButtonNn.Name = "radioButtonNn";
            this.radioButtonNn.Size = new System.Drawing.Size(105, 17);
            this.radioButtonNn.TabIndex = 1;
            this.radioButtonNn.Text = "Normal nationale";
            this.radioButtonNn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAnneeMVT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMute);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(23, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 47);
            this.panel1.TabIndex = 144;
            // 
            // txtAnneeMVT
            // 
            this.txtAnneeMVT.Location = new System.Drawing.Point(499, 13);
            this.txtAnneeMVT.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.txtAnneeMVT.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.txtAnneeMVT.Name = "txtAnneeMVT";
            this.txtAnneeMVT.Size = new System.Drawing.Size(80, 21);
            this.txtAnneeMVT.TabIndex = 147;
            this.txtAnneeMVT.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 146;
            this.label3.Text = "Année MVT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 145;
            this.label4.Text = "Muté de :";
            // 
            // txtMute
            // 
            this.txtMute.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtMute.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtMute.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtMute.BorderThickness = 3;
            this.txtMute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMute.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMute.ForeColor = System.Drawing.Color.Black;
            this.txtMute.isPassword = false;
            this.txtMute.Location = new System.Drawing.Point(66, 9);
            this.txtMute.Margin = new System.Windows.Forms.Padding(4);
            this.txtMute.Name = "txtMute";
            this.txtMute.Size = new System.Drawing.Size(352, 28);
            this.txtMute.TabIndex = 144;
            this.txtMute.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(389, 110);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 35);
            this.btnAjouter.TabIndex = 145;
            this.btnAjouter.Text = "Afficher";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(501, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 146;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoteService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateDecision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecision);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "NoteService";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Note Service";
            this.Load += new System.EventHandler(this.NoteService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnneeMVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtDecision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDecision;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonExep;
        private System.Windows.Forms.RadioButton radioButtonZ;
        private System.Windows.Forms.RadioButton radioButtonEp;
        private System.Windows.Forms.RadioButton radioButtonNL;
        private System.Windows.Forms.RadioButton radioButtonE;
        private System.Windows.Forms.RadioButton radioButtonNR;
        private System.Windows.Forms.RadioButton radioButtonNn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtAnneeMVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMute;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button button2;
    }
}