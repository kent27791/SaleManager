﻿namespace SaleManager.App.GUI
{
    partial class frmStaff
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.bsStaff = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnStaffGroupAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtIdCard = new DevExpress.XtraEditors.TextEdit();
            this.txtFullname = new DevExpress.XtraEditors.TextEdit();
            this.txtComputedId = new DevExpress.XtraEditors.TextEdit();
            this.ckbIsWorking = new DevExpress.XtraEditors.CheckEdit();
            this.cbxStaffGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.ucActionResultButton = new SaleManager.App.GUI.UserControls.ucActionResultButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputedId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbIsWorking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStaffGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsStaff, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(92, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(271, 20);
            this.txtPhone.StyleController = this.layoutControl1;
            this.txtPhone.TabIndex = 9;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Hãy nhập vào số điện thoại";
            this.dxValidationProvider.SetValidationRule(this.txtPhone, conditionValidationRule5);
            // 
            // bsStaff
            // 
            this.bsStaff.DataSource = typeof(SaleManager.Data.Models.Staff);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnStaffGroupAdd);
            this.layoutControl1.Controls.Add(this.txtPhone);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Controls.Add(this.txtIdCard);
            this.layoutControl1.Controls.Add(this.txtFullname);
            this.layoutControl1.Controls.Add(this.txtComputedId);
            this.layoutControl1.Controls.Add(this.ckbIsWorking);
            this.layoutControl1.Controls.Add(this.cbxStaffGroup);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(375, 177);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnStaffGroupAdd
            // 
            this.btnStaffGroupAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffGroupAdd.Image")));
            this.btnStaffGroupAdd.Location = new System.Drawing.Point(307, 36);
            this.btnStaffGroupAdd.Name = "btnStaffGroupAdd";
            this.btnStaffGroupAdd.Size = new System.Drawing.Size(56, 22);
            this.btnStaffGroupAdd.StyleController = this.layoutControl1;
            this.btnStaffGroupAdd.TabIndex = 11;
            this.btnStaffGroupAdd.Text = "Thêm";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsStaff, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(92, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 20);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 8;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Hãy nhập vào địa chỉ của nhân viên";
            this.dxValidationProvider.SetValidationRule(this.txtAddress, conditionValidationRule1);
            // 
            // txtIdCard
            // 
            this.txtIdCard.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsStaff, "IdCard", true));
            this.txtIdCard.Location = new System.Drawing.Point(92, 86);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(271, 20);
            this.txtIdCard.StyleController = this.layoutControl1;
            this.txtIdCard.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Hãy nhập vào số chứng minh nhân dân";
            this.dxValidationProvider.SetValidationRule(this.txtIdCard, conditionValidationRule2);
            // 
            // txtFullname
            // 
            this.txtFullname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsStaff, "Fullname", true));
            this.txtFullname.Location = new System.Drawing.Point(92, 62);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(271, 20);
            this.txtFullname.StyleController = this.layoutControl1;
            this.txtFullname.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Hãy nhập vào tên nhân viên";
            this.dxValidationProvider.SetValidationRule(this.txtFullname, conditionValidationRule3);
            // 
            // txtComputedId
            // 
            this.txtComputedId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsStaff, "ComputedId", true));
            this.txtComputedId.Enabled = false;
            this.txtComputedId.Location = new System.Drawing.Point(92, 12);
            this.txtComputedId.Name = "txtComputedId";
            this.txtComputedId.Size = new System.Drawing.Size(154, 20);
            this.txtComputedId.StyleController = this.layoutControl1;
            this.txtComputedId.TabIndex = 4;
            // 
            // ckbIsWorking
            // 
            this.ckbIsWorking.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsStaff, "IsWorking", true));
            this.ckbIsWorking.EditValue = null;
            this.ckbIsWorking.Location = new System.Drawing.Point(250, 12);
            this.ckbIsWorking.Name = "ckbIsWorking";
            this.ckbIsWorking.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.ckbIsWorking.Properties.Caption = "Tình trạng làm việc";
            this.ckbIsWorking.Size = new System.Drawing.Size(113, 19);
            this.ckbIsWorking.StyleController = this.layoutControl1;
            this.ckbIsWorking.TabIndex = 10;
            // 
            // cbxStaffGroup
            // 
            this.cbxStaffGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsStaff, "StaffGroupId", true));
            this.cbxStaffGroup.Location = new System.Drawing.Point(92, 36);
            this.cbxStaffGroup.Name = "cbxStaffGroup";
            this.cbxStaffGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxStaffGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ComputedId", 100, "Mã nhóm nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 100, "Tên nhóm")});
            this.cbxStaffGroup.Properties.NullText = "";
            this.cbxStaffGroup.Size = new System.Drawing.Size(211, 20);
            this.cbxStaffGroup.StyleController = this.layoutControl1;
            this.cbxStaffGroup.TabIndex = 5;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "Hãy chọn nhóm nhân viên";
            conditionValidationRule4.Value1 = "0";
            this.dxValidationProvider.SetValidationRule(this.cbxStaffGroup, conditionValidationRule4);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(375, 177);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtComputedId;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem1.Text = "Mã nhân viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbxStaffGroup;
            this.layoutControlItem2.CustomizationFormText = "Nhóm nhân viên";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(295, 26);
            this.layoutControlItem2.Text = "Nhóm nhân viên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtFullname;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem3.Text = "Họ tên";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtIdCard;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem4.Text = "Số CMND";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtAddress;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem5.Text = "Địa chỉ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPhone;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(355, 24);
            this.layoutControlItem6.Text = "Số điện thoại";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ckbIsWorking;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(238, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(117, 24);
            this.layoutControlItem7.Text = "Tình trạng làm việc";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 146);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(355, 11);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnStaffGroupAdd;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(295, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.ucActionResultButton);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl.Location = new System.Drawing.Point(0, 177);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(375, 76);
            this.groupControl.TabIndex = 0;
            this.groupControl.Text = "Action";
            // 
            // ucActionResultButton
            // 
            this.ucActionResultButton.Location = new System.Drawing.Point(93, 29);
            this.ucActionResultButton.Name = "ucActionResultButton";
            this.ucActionResultButton.Size = new System.Drawing.Size(187, 39);
            this.ucActionResultButton.TabIndex = 0;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 253);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.groupControl);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputedId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbIsWorking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStaffGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private System.Windows.Forms.BindingSource bsStaff;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private UserControls.ucActionResultButton ucActionResultButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtIdCard;
        private DevExpress.XtraEditors.TextEdit txtFullname;
        private DevExpress.XtraEditors.TextEdit txtComputedId;
        private DevExpress.XtraEditors.CheckEdit ckbIsWorking;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit cbxStaffGroup;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnStaffGroupAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}