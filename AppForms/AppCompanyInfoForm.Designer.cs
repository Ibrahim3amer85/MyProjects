namespace SalesWithLinq.AppForms
{
    partial class AppCompanyInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppCompanyInfoForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.saveDataBarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.saveDataBarButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(565, 69);
            // 
            // saveDataBarButtonItem1
            // 
            this.saveDataBarButtonItem1.Caption = "حفظ";
            this.saveDataBarButtonItem1.Id = 1;
            this.saveDataBarButtonItem1.ImageOptions.Image = global::SalesWithLinq.Properties.Resources.save_16x16;
            this.saveDataBarButtonItem1.ImageOptions.LargeImage = global::SalesWithLinq.Properties.Resources.save_32x32;
            this.saveDataBarButtonItem1.Name = "saveDataBarButtonItem1";
            this.saveDataBarButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveDataBarButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = ".";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.saveDataBarButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "......";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.addressTextEdit);
            this.layoutControl1.Controls.Add(this.mobileTextEdit);
            this.layoutControl1.Controls.Add(this.telephoneTextEdit);
            this.layoutControl1.Controls.Add(this.companyNameTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(565, 157);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.Location = new System.Drawing.Point(12, 90);
            this.addressTextEdit.MenuManager = this.ribbonControl1;
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(464, 22);
            this.addressTextEdit.StyleController = this.layoutControl1;
            this.addressTextEdit.TabIndex = 7;
            // 
            // mobileTextEdit
            // 
            this.mobileTextEdit.Location = new System.Drawing.Point(12, 64);
            this.mobileTextEdit.MenuManager = this.ribbonControl1;
            this.mobileTextEdit.Name = "mobileTextEdit";
            this.mobileTextEdit.Size = new System.Drawing.Size(464, 22);
            this.mobileTextEdit.StyleController = this.layoutControl1;
            this.mobileTextEdit.TabIndex = 6;
            // 
            // telephoneTextEdit
            // 
            this.telephoneTextEdit.Location = new System.Drawing.Point(12, 38);
            this.telephoneTextEdit.MenuManager = this.ribbonControl1;
            this.telephoneTextEdit.Name = "telephoneTextEdit";
            this.telephoneTextEdit.Size = new System.Drawing.Size(464, 22);
            this.telephoneTextEdit.StyleController = this.layoutControl1;
            this.telephoneTextEdit.TabIndex = 5;
            // 
            // companyNameTextEdit
            // 
            this.companyNameTextEdit.Location = new System.Drawing.Point(12, 12);
            this.companyNameTextEdit.MenuManager = this.ribbonControl1;
            this.companyNameTextEdit.Name = "companyNameTextEdit";
            this.companyNameTextEdit.Size = new System.Drawing.Size(464, 22);
            this.companyNameTextEdit.StyleController = this.layoutControl1;
            this.companyNameTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(565, 157);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.companyNameTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(545, 26);
            this.layoutControlItem1.Text = "اسم الشركة";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 104);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(545, 33);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.telephoneTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(545, 26);
            this.layoutControlItem2.Text = "رقم التليفون";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.mobileTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(545, 26);
            this.layoutControlItem3.Text = "الموبايل";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.addressTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(545, 26);
            this.layoutControlItem4.Text = "العنوان";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 17);
            // 
            // AppCompanyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 226);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppCompanyInfoForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem saveDataBarButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
        private DevExpress.XtraEditors.TextEdit mobileTextEdit;
        private DevExpress.XtraEditors.TextEdit telephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit companyNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}