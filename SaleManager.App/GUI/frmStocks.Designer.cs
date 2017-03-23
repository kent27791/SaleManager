namespace SaleManager.App.GUI
{
    partial class frmStocks
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
            this.ucActionButton = new SaleManager.App.GUI.UserControls.ucActionButton();
            this.gcStock = new DevExpress.XtraGrid.GridControl();
            this.gvStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // ucActionButton
            // 
            this.ucActionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucActionButton.InvoiceState = SaleManager.App.GUI.UserControls.InvoiceState.Empty;
            this.ucActionButton.Location = new System.Drawing.Point(0, 0);
            this.ucActionButton.Name = "ucActionButton";
            this.ucActionButton.Size = new System.Drawing.Size(513, 20);
            this.ucActionButton.TabIndex = 0;
            // 
            // gcStock
            // 
            this.gcStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStock.Location = new System.Drawing.Point(0, 20);
            this.gcStock.MainView = this.gvStock;
            this.gcStock.Name = "gcStock";
            this.gcStock.Size = new System.Drawing.Size(513, 317);
            this.gcStock.TabIndex = 1;
            this.gcStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStock});
            // 
            // gvStock
            // 
            this.gvStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvStock.GridControl = this.gcStock;
            this.gvStock.Name = "gvStock";
            this.gvStock.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "#";
            this.gridColumn1.FieldName = "ComputedId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên kho";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ kho";
            this.gridColumn3.FieldName = "Address";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 337);
            this.Controls.Add(this.gcStock);
            this.Controls.Add(this.ucActionButton);
            this.Name = "frmStocks";
            this.Text = "frmStocks";
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucActionButton ucActionButton;
        private DevExpress.XtraGrid.GridControl gcStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}