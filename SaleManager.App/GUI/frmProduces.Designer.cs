namespace SaleManager.App.GUI
{
    partial class frmProduces
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
            this.gcProduce = new DevExpress.XtraGrid.GridControl();
            this.gvProduce = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduce)).BeginInit();
            this.SuspendLayout();
            // 
            // ucActionButton
            // 
            this.ucActionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucActionButton.InvoiceState = SaleManager.App.GUI.UserControls.InvoiceState.Empty;
            this.ucActionButton.Location = new System.Drawing.Point(0, 0);
            this.ucActionButton.Name = "ucActionButton";
            this.ucActionButton.Size = new System.Drawing.Size(497, 20);
            this.ucActionButton.TabIndex = 0;
            // 
            // gcProduce
            // 
            this.gcProduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduce.Location = new System.Drawing.Point(0, 20);
            this.gcProduce.MainView = this.gvProduce;
            this.gcProduce.Name = "gcProduce";
            this.gcProduce.Size = new System.Drawing.Size(497, 310);
            this.gcProduce.TabIndex = 1;
            this.gcProduce.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduce});
            // 
            // gvProduce
            // 
            this.gvProduce.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvProduce.GridControl = this.gcProduce;
            this.gvProduce.Name = "gvProduce";
            this.gvProduce.OptionsBehavior.Editable = false;
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
            this.gridColumn2.Caption = "Tên sản phẩm";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn vị tính";
            this.gridColumn3.FieldName = "Unit";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nhóm sản phẩm";
            this.gridColumn4.FieldName = "ProduceGroup";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // frmProduces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 330);
            this.Controls.Add(this.gcProduce);
            this.Controls.Add(this.ucActionButton);
            this.Name = "frmProduces";
            this.Text = "frmProduces";
            ((System.ComponentModel.ISupportInitialize)(this.gcProduce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucActionButton ucActionButton;
        private DevExpress.XtraGrid.GridControl gcProduce;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduce;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}