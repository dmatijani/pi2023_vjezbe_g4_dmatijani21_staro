namespace FrmEvaulation
{
    partial class FrmEvaluation
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
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.lblAktivnost = new System.Windows.Forms.Label();
            this.lblUvjet = new System.Windows.Forms.Label();
            this.lblUvjet2 = new System.Windows.Forms.Label();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.lblOcjenjivac = new System.Windows.Forms.Label();
            this.lblDatEval = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(22, 65);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(313, 21);
            this.cboActivities.TabIndex = 0;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(382, 66);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(120, 20);
            this.txtMinForSignature.TabIndex = 1;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(553, 66);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(120, 20);
            this.txtMinForGrade.TabIndex = 2;
            // 
            // lblAktivnost
            // 
            this.lblAktivnost.AutoSize = true;
            this.lblAktivnost.Location = new System.Drawing.Point(19, 49);
            this.lblAktivnost.Name = "lblAktivnost";
            this.lblAktivnost.Size = new System.Drawing.Size(54, 13);
            this.lblAktivnost.TabIndex = 3;
            this.lblAktivnost.Text = "Aktivnost:";
            this.lblAktivnost.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUvjet
            // 
            this.lblUvjet.AutoSize = true;
            this.lblUvjet.Location = new System.Drawing.Point(379, 49);
            this.lblUvjet.Name = "lblUvjet";
            this.lblUvjet.Size = new System.Drawing.Size(80, 13);
            this.lblUvjet.TabIndex = 4;
            this.lblUvjet.Text = "Uvjet za potpis:";
            this.lblUvjet.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblUvjet2
            // 
            this.lblUvjet2.AutoSize = true;
            this.lblUvjet2.Location = new System.Drawing.Point(550, 49);
            this.lblUvjet2.Name = "lblUvjet2";
            this.lblUvjet2.Size = new System.Drawing.Size(84, 13);
            this.lblUvjet2.TabIndex = 5;
            this.lblUvjet2.Text = "Uvjet za ocjenu:";
            this.lblUvjet2.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(22, 102);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(651, 158);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(262, 306);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(120, 20);
            this.txtTeacher.TabIndex = 7;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(427, 306);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(120, 20);
            this.txtEvaluationDate.TabIndex = 8;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(587, 306);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(86, 20);
            this.numPoints.TabIndex = 9;
            this.numPoints.ValueChanged += new System.EventHandler(this.numPoints_ValueChanged);
            // 
            // lblOcjenjivac
            // 
            this.lblOcjenjivac.AutoSize = true;
            this.lblOcjenjivac.Location = new System.Drawing.Point(259, 290);
            this.lblOcjenjivac.Name = "lblOcjenjivac";
            this.lblOcjenjivac.Size = new System.Drawing.Size(60, 13);
            this.lblOcjenjivac.TabIndex = 10;
            this.lblOcjenjivac.Text = "Ocjenjivač:";
            // 
            // lblDatEval
            // 
            this.lblDatEval.AutoSize = true;
            this.lblDatEval.Location = new System.Drawing.Point(424, 290);
            this.lblDatEval.Name = "lblDatEval";
            this.lblDatEval.Size = new System.Drawing.Size(92, 13);
            this.lblDatEval.TabIndex = 11;
            this.lblDatEval.Text = "Datum evaluacije:";
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(584, 290);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(43, 13);
            this.lblBodovi.TabIndex = 12;
            this.lblBodovi.Text = "Bodovi:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(598, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 399);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.lblDatEval);
            this.Controls.Add(this.lblOcjenjivac);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.lblUvjet2);
            this.Controls.Add(this.lblUvjet);
            this.Controls.Add(this.lblAktivnost);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.Label lblAktivnost;
        private System.Windows.Forms.Label lblUvjet;
        private System.Windows.Forms.Label lblUvjet2;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label lblOcjenjivac;
        private System.Windows.Forms.Label lblDatEval;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

