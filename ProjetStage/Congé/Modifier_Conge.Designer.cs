namespace ProjetStage.Congé
{
    partial class Modifier_Conge
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
            this.txtAnnee = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtPPR = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNbrjour = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelReporterConge = new System.Windows.Forms.Panel();
            this.radioButtonNon = new System.Windows.Forms.RadioButton();
            this.radioButtonOui = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnnee)).BeginInit();
            this.panelReporterConge.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAnnee
            // 
            this.txtAnnee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnnee.Location = new System.Drawing.Point(144, 154);
            this.txtAnnee.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtAnnee.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(86, 20);
            this.txtAnnee.TabIndex = 125;
            this.txtAnnee.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(234, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 124;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 123;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNom
            // 
            this.txtNom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtNom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtNom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtNom.BorderThickness = 3;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNom.ForeColor = System.Drawing.Color.Black;
            this.txtNom.isPassword = false;
            this.txtNom.Location = new System.Drawing.Point(141, 111);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(225, 28);
            this.txtNom.TabIndex = 121;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(17, 117);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(106, 16);
            this.label48.TabIndex = 116;
            this.label48.Text = "Nom et Prenom :";
            // 
            // txtPPR
            // 
            this.txtPPR.BackColor = System.Drawing.Color.White;
            this.txtPPR.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtPPR.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtPPR.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtPPR.BorderThickness = 3;
            this.txtPPR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPPR.Enabled = false;
            this.txtPPR.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPPR.ForeColor = System.Drawing.Color.Black;
            this.txtPPR.isPassword = false;
            this.txtPPR.Location = new System.Drawing.Point(141, 75);
            this.txtPPR.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPR.Name = "txtPPR";
            this.txtPPR.Size = new System.Drawing.Size(225, 28);
            this.txtPPR.TabIndex = 120;
            this.txtPPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 118;
            this.label4.Text = "Année :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "PPR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 126;
            this.label5.Text = "Congé reporter ?";
            // 
            // txtNbrjour
            // 
            this.txtNbrjour.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtNbrjour.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtNbrjour.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtNbrjour.BorderThickness = 3;
            this.txtNbrjour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNbrjour.Enabled = false;
            this.txtNbrjour.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNbrjour.ForeColor = System.Drawing.Color.Black;
            this.txtNbrjour.isPassword = false;
            this.txtNbrjour.Location = new System.Drawing.Point(141, 181);
            this.txtNbrjour.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbrjour.Name = "txtNbrjour";
            this.txtNbrjour.Size = new System.Drawing.Size(89, 28);
            this.txtNbrjour.TabIndex = 129;
            this.txtNbrjour.Text = "22";
            this.txtNbrjour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Nombre de jour :";
            // 
            // panelReporterConge
            // 
            this.panelReporterConge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReporterConge.Controls.Add(this.radioButtonNon);
            this.panelReporterConge.Controls.Add(this.radioButtonOui);
            this.panelReporterConge.Enabled = false;
            this.panelReporterConge.Location = new System.Drawing.Point(144, 218);
            this.panelReporterConge.Name = "panelReporterConge";
            this.panelReporterConge.Size = new System.Drawing.Size(142, 33);
            this.panelReporterConge.TabIndex = 130;
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
            // Modifier_Conge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 315);
            this.Controls.Add(this.panelReporterConge);
            this.Controls.Add(this.txtNbrjour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.txtPPR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Modifier_Conge";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Modifier Conge";
            this.Load += new System.EventHandler(this.Modifier_Conge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAnnee)).EndInit();
            this.panelReporterConge.ResumeLayout(false);
            this.panelReporterConge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtAnnee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNom;
        private System.Windows.Forms.Label label48;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPPR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNbrjour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelReporterConge;
        private System.Windows.Forms.RadioButton radioButtonNon;
        private System.Windows.Forms.RadioButton radioButtonOui;
    }
}