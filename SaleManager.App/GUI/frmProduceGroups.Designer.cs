namespace SaleManager.App.GUI
{
    partial class frmProduceGroups
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
            this.gcProduceGroup = new DevExpress.XtraGrid.GridControl();
            this.gvProduceGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduceGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduceGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // ucActionButton
            // 
            this.ucActionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucActionButton.InvoiceState = SaleManager.App.GUI.UserControls.InvoiceState.Empty;
            this.ucActionButton.Location = new System.Drawing.Point(0, 0);
            this.ucActionButton.Name = "ucActionButton";
            this.ucActionButton.Size = new System.Drawing.Size(477, 20);
            this.ucActionButton.TabIndex = 0;
            // 
            // gcProduceGroup
            // 
            this.gcProduceGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduceGroup.Location = new System.Drawing.Point(0, 20);
            this.gcProduceGroup.MainView = this.gvProduceGroup;
            this.gcProduceGroup.Name = "gcProduceGroup";
            this.gcProduceGroup.Size = new System.Drawing.Size(477, 280);
            this.gcProduceGroup.TabIndex = 1;
            this.gcProduceGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduceGroup});
            // 
            // gvProduceGroup
            // 
            this.gvProduceGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvProduceGroup.GridControl = this.gcProduceGroup;
            this.gvProduceGroup.Name = "gvProduceGroup";
            this.gvProduceGroup.OptionsBehavior.Editable = false;
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
            this.gridColumn2.Caption = "Tên nhóm sản phẩm";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ghi chú";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // frmProduceGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 300);
            this.Controls.Add(this.gcProduceGroup);
            this.Controls.Add(this.ucActionButton);
            this.Name = "frmProduceGroups";
            this.Text = "frmProduceGroups";
            ((System.ComponentModel.ISupportInitialize)(this.gcProduceGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduceGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucActionButton ucActionButton;
        private DevExpress.XtraGrid.GridControl gcProduceGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduceGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}