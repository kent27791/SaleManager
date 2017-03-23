namespace SaleManager.App.GUI
{
    partial class frmDelivery
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ucActionResultButton = new SaleManager.App.GUI.UserControls.ucActionResultButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCustomerAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnStaffAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gcDeliveryNoteDetails = new DevExpress.XtraGrid.GridControl();
            this.gvDeliveryNoteDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditProduce = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtComputedId = new DevExpress.XtraEditors.TextEdit();
            this.bsDeliveryNote = new System.Windows.Forms.BindingSource(this.components);
            this.cbxStaff = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxStock = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNoteDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNoteDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProduce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputedId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStaff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ucActionResultButton);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 444);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(634, 95);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Action";
            // 
            // ucActionResultButton
            // 
            this.ucActionResultButton.Location = new System.Drawing.Point(215, 35);
            this.ucActionResultButton.Name = "ucActionResultButton";
            this.ucActionResultButton.Size = new System.Drawing.Size(195, 39);
            this.ucActionResultButton.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCustomerAdd);
            this.layoutControl1.Controls.Add(this.btnStaffAdd);
            this.layoutControl1.Controls.Add(this.gcDeliveryNoteDetails);
            this.layoutControl1.Controls.Add(this.txtComputedId);
            this.layoutControl1.Controls.Add(this.cbxStaff);
            this.layoutControl1.Controls.Add(this.cbxStock);
            this.layoutControl1.Controls.Add(this.cbxCustomer);
            this.layoutControl1.Controls.Add(this.txtDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(414, 246, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(634, 444);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerAdd.Image")));
            this.btnCustomerAdd.Location = new System.Drawing.Point(554, 116);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(56, 22);
            this.btnCustomerAdd.StyleController = this.layoutControl1;
            this.btnCustomerAdd.TabIndex = 14;
            this.btnCustomerAdd.Text = "Thêm";
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffAdd.Image")));
            this.btnStaffAdd.Location = new System.Drawing.Point(554, 66);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(56, 22);
            this.btnStaffAdd.StyleController = this.layoutControl1;
            this.btnStaffAdd.TabIndex = 13;
            this.btnStaffAdd.Text = "Thêm";
            // 
            // gcDeliveryNoteDetails
            // 
            this.gcDeliveryNoteDetails.Location = new System.Drawing.Point(36, 196);
            this.gcDeliveryNoteDetails.MainView = this.gvDeliveryNoteDetails;
            this.gcDeliveryNoteDetails.Name = "gcDeliveryNoteDetails";
            this.gcDeliveryNoteDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditProduce});
            this.gcDeliveryNoteDetails.Size = new System.Drawing.Size(562, 212);
            this.gcDeliveryNoteDetails.TabIndex = 9;
            this.gcDeliveryNoteDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDeliveryNoteDetails});
            // 
            // gvDeliveryNoteDetails
            // 
            this.gvDeliveryNoteDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvDeliveryNoteDetails.GridControl = this.gcDeliveryNoteDetails;
            this.gvDeliveryNoteDetails.Name = "gvDeliveryNoteDetails";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sản phẩm";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpEditProduce;
            this.gridColumn1.FieldName = "ProduceId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEditProduce
            // 
            this.repositoryItemLookUpEditProduce.AutoHeight = false;
            this.repositoryItemLookUpEditProduce.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditProduce.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ComputedId", 100, "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 200, "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inventory", 100, "Tồn kho")});
            this.repositoryItemLookUpEditProduce.Name = "repositoryItemLookUpEditProduce";
            this.repositoryItemLookUpEditProduce.PopupFormMinSize = new System.Drawing.Size(400, 0);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng";
            this.gridColumn2.FieldName = "Quantity";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn giá xuất";
            this.gridColumn3.DisplayFormat.FormatString = "{0:C0}";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // txtComputedId
            // 
            this.txtComputedId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDeliveryNote, "ComputedId", true));
            this.txtComputedId.Enabled = false;
            this.txtComputedId.Location = new System.Drawing.Point(108, 42);
            this.txtComputedId.Name = "txtComputedId";
            this.txtComputedId.Size = new System.Drawing.Size(502, 20);
            this.txtComputedId.StyleController = this.layoutControl1;
            this.txtComputedId.TabIndex = 4;
            // 
            // bsDeliveryNote
            // 
            this.bsDeliveryNote.DataSource = typeof(SaleManager.Data.Models.DeliveryNote);
            // 
            // cbxStaff
            // 
            this.cbxStaff.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDeliveryNote, "StaffId", true));
            this.cbxStaff.Location = new System.Drawing.Point(108, 66);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxStaff.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ComputedId", 100, "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", 100, "Tên nhân viên")});
            this.cbxStaff.Properties.NullText = "";
            this.cbxStaff.Size = new System.Drawing.Size(442, 20);
            this.cbxStaff.StyleController = this.layoutControl1;
            this.cbxStaff.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Hãy chọn nhân viên xuất";
            conditionValidationRule1.Value1 = "0";
            this.dxValidationProvider.SetValidationRule(this.cbxStaff, conditionValidationRule1);
            // 
            // cbxStock
            // 
            this.cbxStock.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDeliveryNote, "StockId", true));
            this.cbxStock.Location = new System.Drawing.Point(108, 92);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ComputedId", 100, "Mã kho hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 100, "Tên kho hàng")});
            this.cbxStock.Properties.NullText = "";
            this.cbxStock.Size = new System.Drawing.Size(502, 20);
            this.cbxStock.StyleController = this.layoutControl1;
            this.cbxStock.TabIndex = 6;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Hãy chọn kho hàng xuất";
            conditionValidationRule2.Value1 = "0";
            this.dxValidationProvider.SetValidationRule(this.cbxStock, conditionValidationRule2);
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDeliveryNote, "CustomerId", true));
            this.cbxCustomer.Location = new System.Drawing.Point(108, 116);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ComputedId", 100, "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", 100, "Tên khách hàng")});
            this.cbxCustomer.Properties.NullText = "";
            this.cbxCustomer.Size = new System.Drawing.Size(442, 20);
            this.cbxCustomer.StyleController = this.layoutControl1;
            this.cbxCustomer.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Hãy chọn khách hàng";
            conditionValidationRule3.Value1 = "0";
            this.dxValidationProvider.SetValidationRule(this.cbxCustomer, conditionValidationRule3);
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDeliveryNote, "Date", true));
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(108, 142);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.Mask.EditMask = "";
            this.txtDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDate.Size = new System.Drawing.Size(502, 20);
            this.txtDate.StyleController = this.layoutControl1;
            this.txtDate.TabIndex = 8;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Hãy chọn ngày tháng hóa đơn xuất";
            this.dxValidationProvider.SetValidationRule(this.txtDate, conditionValidationRule4);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(634, 444);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Thông tin hóa đơn xuất";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlGroup3,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(614, 424);
            this.layoutControlGroup2.Text = "Thông tin hóa đơn xuất";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDate;
            this.layoutControlItem5.CustomizationFormText = "Ngày tháng";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(590, 24);
            this.layoutControlItem5.Text = "Ngày tháng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbxCustomer;
            this.layoutControlItem4.CustomizationFormText = "Khách hàng";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(530, 26);
            this.layoutControlItem4.Text = "Khách hàng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbxStock;
            this.layoutControlItem3.CustomizationFormText = "Kho hàng";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(590, 24);
            this.layoutControlItem3.Text = "Kho hàng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbxStaff;
            this.layoutControlItem2.CustomizationFormText = "Nhân viên xuất";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(530, 26);
            this.layoutControlItem2.Text = "Nhân viên xuất";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtComputedId;
            this.layoutControlItem1.CustomizationFormText = "Mã hóa đơn xuất";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(590, 24);
            this.layoutControlItem1.Text = "Mã hóa đơn xuất";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Chi tiết sản phẩm xuất";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 124);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(590, 258);
            this.layoutControlGroup3.Text = "Chi tiết sản phẩm xuất";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcDeliveryNoteDetails;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(566, 216);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnStaffAdd;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(530, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnCustomerAdd;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(530, 74);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 539);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNoteDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNoteDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProduce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputedId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStaff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ucActionResultButton ucActionResultButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcDeliveryNoteDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDeliveryNoteDetails;
        private DevExpress.XtraEditors.TextEdit txtComputedId;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private System.Windows.Forms.BindingSource bsDeliveryNote;
        private DevExpress.XtraEditors.LookUpEdit cbxStaff;
        private DevExpress.XtraEditors.LookUpEdit cbxStock;
        private DevExpress.XtraEditors.LookUpEdit cbxCustomer;
        private DevExpress.XtraEditors.SimpleButton btnStaffAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditProduce;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnCustomerAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}