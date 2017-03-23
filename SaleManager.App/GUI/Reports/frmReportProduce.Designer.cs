namespace SaleManager.App.GUI.Reports
{
    partial class frmReportProduce
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
            this.ucDateTime = new SaleManager.App.GUI.UserControls.ucDateTime();
            this.ucReport = new SaleManager.App.GUI.UserControls.ucReport();
            this.SuspendLayout();
            // 
            // ucDateTime
            // 
            this.ucDateTime.DateTimeFrom = new System.DateTime(((long)(0)));
            this.ucDateTime.DateTimeTo = new System.DateTime(((long)(0)));
            this.ucDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDateTime.Location = new System.Drawing.Point(0, 0);
            this.ucDateTime.Name = "ucDateTime";
            this.ucDateTime.Size = new System.Drawing.Size(566, 44);
            this.ucDateTime.TabIndex = 0;
            // 
            // ucReport
            // 
            this.ucReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReport.Location = new System.Drawing.Point(0, 44);
            this.ucReport.Name = "ucReport";
            this.ucReport.Size = new System.Drawing.Size(566, 303);
            this.ucReport.TabIndex = 1;
            // 
            // frmReportProduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 347);
            this.Controls.Add(this.ucReport);
            this.Controls.Add(this.ucDateTime);
            this.Name = "frmReportProduce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportProduce";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucDateTime ucDateTime;
        private UserControls.ucReport ucReport;
    }
}