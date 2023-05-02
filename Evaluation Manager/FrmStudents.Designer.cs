namespace Evaluation_Manager
{
    partial class FrmStudents
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
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudents
            // 
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(46, 36);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidth = 51;
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgwStudents.Size = new System.Drawing.Size(943, 428);
            this.dgwStudents.TabIndex = 0;
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgwStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStudents";
            this.Text = "FrmStudents";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudents;
    }
}