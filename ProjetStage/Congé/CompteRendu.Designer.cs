namespace ProjetStage.Congé
{
    partial class CompteRendu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonCR = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumDec = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dateDecision = new System.Windows.Forms.DateTimePicker();
            this.DateCessation = new System.Windows.Forms.DateTimePicker();
            this.DateReprise = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonCR);
            this.panel1.Controls.Add(this.radioButtonR);
            this.panel1.Controls.Add(this.radioButtonC);
            this.panel1.Location = new System.Drawing.Point(63, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 25);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonCR
            // 
            this.radioButtonCR.AutoSize = true;
            this.radioButtonCR.Location = new System.Drawing.Point(173, 3);
            this.radioButtonCR.Name = "radioButtonCR";
            this.radioButtonCR.Size = new System.Drawing.Size(118, 17);
            this.radioButtonCR.TabIndex = 2;
            this.radioButtonCR.Text = "Cessation / Reprise";
            this.radioButtonCR.UseVisualStyleBackColor = true;
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(95, 4);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(61, 17);
            this.radioButtonR.TabIndex = 1;
            this.radioButtonR.Text = "Reprise";
            this.radioButtonR.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Checked = true;
            this.radioButtonC.Location = new System.Drawing.Point(3, 4);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(72, 17);
            this.radioButtonC.TabIndex = 0;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "Cessation";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro décision :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date décision :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date cessation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date reprise :";
            // 
            // txtNumDec
            // 
            this.txtNumDec.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtNumDec.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.txtNumDec.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.txtNumDec.BorderThickness = 3;
            this.txtNumDec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumDec.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumDec.ForeColor = System.Drawing.Color.Black;
            this.txtNumDec.isPassword = false;
            this.txtNumDec.Location = new System.Drawing.Point(123, 96);
            this.txtNumDec.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDec.Name = "txtNumDec";
            this.txtNumDec.Size = new System.Drawing.Size(126, 28);
            this.txtNumDec.TabIndex = 116;
            this.txtNumDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateDecision
            // 
            this.dateDecision.Location = new System.Drawing.Point(123, 132);
            this.dateDecision.Name = "dateDecision";
            this.dateDecision.Size = new System.Drawing.Size(200, 20);
            this.dateDecision.TabIndex = 117;
            // 
            // DateCessation
            // 
            this.DateCessation.Location = new System.Drawing.Point(123, 164);
            this.DateCessation.Name = "DateCessation";
            this.DateCessation.Size = new System.Drawing.Size(200, 20);
            this.DateCessation.TabIndex = 118;
            // 
            // DateReprise
            // 
            this.DateReprise.Location = new System.Drawing.Point(123, 196);
            this.DateReprise.Name = "DateReprise";
            this.DateReprise.Size = new System.Drawing.Size(200, 20);
            this.DateReprise.TabIndex = 119;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(325, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 125;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.Enabled = false;
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Location = new System.Drawing.Point(174, 256);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(106, 35);
            this.btnImprimer.TabIndex = 126;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(137)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(23, 256);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 35);
            this.btnAjouter.TabIndex = 127;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // CompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 314);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DateReprise);
            this.Controls.Add(this.DateCessation);
            this.Controls.Add(this.dateDecision);
            this.Controls.Add(this.txtNumDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CompteRendu";
            this.Text = "CompteRendu";
            this.Load += new System.EventHandler(this.CompteRendu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonCR;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNumDec;
        private System.Windows.Forms.DateTimePicker dateDecision;
        private System.Windows.Forms.DateTimePicker DateCessation;
        private System.Windows.Forms.DateTimePicker DateReprise;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnAjouter;
    }
}