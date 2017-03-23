namespace SaleManager.App.GUI
{
    partial class frmDeliveries
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
            this.gcDeliveryNote = new DevExpress.XtraGrid.GridControl();
            this.gvDeliveryNote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).BeginInit();
            this.SuspendLayout();
            // 
            // ucActionButton
            // 
            this.ucActionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucActionButton.InvoiceState = SaleManager.App.GUI.UserControls.InvoiceState.Empty;
            this.ucActionButton.Location = new System.Drawing.Point(0, 0);
            this.ucActionButton.Name = "ucActionButton";
            this.ucActionButton.Size = new System.Drawing.Size(600, 20);
            this.ucActionButton.TabIndex = 0;
            // 
            // gcDeliveryNote
            // 
            this.gcDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDeliveryNote.Location = new System.Drawing.Point(0, 20);
            this.gcDeliveryNote.MainView = this.gvDeliveryNote;
            this.gcDeliveryNote.Name = "gcDeliveryNote";
            this.gcDeliveryNote.Size = new System.Drawing.Size(600, 333);
            this.gcDeliveryNote.TabIndex = 1;
            this.gcDeliveryNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDeliveryNote});
            // 
            // gvDeliveryNote
            // 
            this.gvDeliveryNote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvDeliveryNote.GridControl = this.gcDeliveryNote;
            this.gvDeliveryNote.Name = "gvDeliveryNote";
            this.gvDeliveryNote.OptionsBehavior.Editable = false;
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
            this.gridColumn2.Caption = "Ngày tháng";
            this.gridColumn2.FieldName = "Date";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên nhân viên";
            this.gridColumn3.FieldName = "Staff";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên khách hàng";
            this.gridColumn4.FieldName = "Customer";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên kho hàng";
            this.gridColumn5.FieldName = "Stock";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số sản phẩm xuất";
            this.gridColumn6.FieldName = "Produces";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // frmDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 353);
            this.Controls.Add(this.gcDeliveryNote);
            this.Controls.Add(this.ucActionButton);
            this.Name = "frmDeliveries";
            this.Text = "frmDeliveries";
            ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucActionButton ucActionButton;
        private DevExpress.XtraGrid.GridControl gcDeliveryNote;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDeliveryNote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}