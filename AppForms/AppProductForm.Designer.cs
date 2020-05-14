namespace SalesWithLinq.AppForms
{
    partial class AppProductForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.productStatusCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.productCategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.productTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.productCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.productImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.productUnitsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUnitsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1098, 180);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.productUnitsGridControl);
            this.layoutControl1.Controls.Add(this.productStatusCheckEdit);
            this.layoutControl1.Controls.Add(this.productCategoryLookUpEdit);
            this.layoutControl1.Controls.Add(this.productTypeLookUpEdit);
            this.layoutControl1.Controls.Add(this.productCodeTextEdit);
            this.layoutControl1.Controls.Add(this.productNameTextEdit);
            this.layoutControl1.Controls.Add(this.descriptionMemoEdit);
            this.layoutControl1.Controls.Add(this.productImagePictureEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 180);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 348, 812, 500);
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1098, 588);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // productStatusCheckEdit
            // 
            this.productStatusCheckEdit.EditValue = true;
            this.productStatusCheckEdit.Location = new System.Drawing.Point(304, 12);
            this.productStatusCheckEdit.MenuManager = this.ribbonControl1;
            this.productStatusCheckEdit.Name = "productStatusCheckEdit";
            this.productStatusCheckEdit.Properties.Caption = "نشط";
            this.productStatusCheckEdit.Size = new System.Drawing.Size(470, 21);
            this.productStatusCheckEdit.StyleController = this.layoutControl1;
            this.productStatusCheckEdit.TabIndex = 10;
            // 
            // productCategoryLookUpEdit
            // 
            this.productCategoryLookUpEdit.Location = new System.Drawing.Point(304, 90);
            this.productCategoryLookUpEdit.MenuManager = this.ribbonControl1;
            this.productCategoryLookUpEdit.Name = "productCategoryLookUpEdit";
            this.productCategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productCategoryLookUpEdit.Properties.NullText = "اختيار فئة";
            this.productCategoryLookUpEdit.Size = new System.Drawing.Size(742, 22);
            this.productCategoryLookUpEdit.StyleController = this.layoutControl1;
            this.productCategoryLookUpEdit.TabIndex = 7;
            // 
            // productTypeLookUpEdit
            // 
            this.productTypeLookUpEdit.Location = new System.Drawing.Point(304, 64);
            this.productTypeLookUpEdit.MenuManager = this.ribbonControl1;
            this.productTypeLookUpEdit.Name = "productTypeLookUpEdit";
            this.productTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productTypeLookUpEdit.Properties.NullText = "";
            this.productTypeLookUpEdit.Size = new System.Drawing.Size(742, 22);
            this.productTypeLookUpEdit.StyleController = this.layoutControl1;
            this.productTypeLookUpEdit.TabIndex = 6;
            // 
            // productCodeTextEdit
            // 
            this.productCodeTextEdit.Location = new System.Drawing.Point(778, 12);
            this.productCodeTextEdit.MenuManager = this.ribbonControl1;
            this.productCodeTextEdit.Name = "productCodeTextEdit";
            this.productCodeTextEdit.Size = new System.Drawing.Size(268, 22);
            this.productCodeTextEdit.StyleController = this.layoutControl1;
            this.productCodeTextEdit.TabIndex = 4;
            // 
            // productNameTextEdit
            // 
            this.productNameTextEdit.Location = new System.Drawing.Point(304, 38);
            this.productNameTextEdit.MenuManager = this.ribbonControl1;
            this.productNameTextEdit.Name = "productNameTextEdit";
            this.productNameTextEdit.Size = new System.Drawing.Size(742, 22);
            this.productNameTextEdit.StyleController = this.layoutControl1;
            this.productNameTextEdit.TabIndex = 5;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.Location = new System.Drawing.Point(304, 116);
            this.descriptionMemoEdit.MenuManager = this.ribbonControl1;
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(742, 159);
            this.descriptionMemoEdit.StyleController = this.layoutControl1;
            this.descriptionMemoEdit.TabIndex = 8;
            // 
            // productImagePictureEdit
            // 
            this.productImagePictureEdit.Location = new System.Drawing.Point(24, 50);
            this.productImagePictureEdit.MenuManager = this.ribbonControl1;
            this.productImagePictureEdit.Name = "productImagePictureEdit";
            this.productImagePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.productImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.productImagePictureEdit.Size = new System.Drawing.Size(264, 213);
            this.productImagePictureEdit.StyleController = this.layoutControl1;
            this.productImagePictureEdit.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1098, 588);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.productCodeTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(766, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(312, 26);
            this.layoutControlItem1.Text = "كود";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(37, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.productNameTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(292, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(786, 26);
            this.layoutControlItem2.Text = "الإسم";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(37, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.productCategoryLookUpEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(292, 78);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(786, 26);
            this.layoutControlItem4.Text = "الفئة";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(37, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.productTypeLookUpEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(292, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(786, 26);
            this.layoutControlItem3.Text = "النوع";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(37, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.descriptionMemoEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(292, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(786, 163);
            this.layoutControlItem5.Text = "الوصف";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(37, 17);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(292, 267);
            this.layoutControlGroup1.Text = "الصورة";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.productImagePictureEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(268, 217);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.productStatusCheckEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(292, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(474, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // productUnitsGridControl
            // 
            this.productUnitsGridControl.Location = new System.Drawing.Point(24, 317);
            this.productUnitsGridControl.MainView = this.gridView1;
            this.productUnitsGridControl.MenuManager = this.ribbonControl1;
            this.productUnitsGridControl.Name = "productUnitsGridControl";
            this.productUnitsGridControl.Size = new System.Drawing.Size(1050, 247);
            this.productUnitsGridControl.TabIndex = 11;
            this.productUnitsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.productUnitsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.productUnitsGridControl;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1054, 251);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 267);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1078, 301);
            this.layoutControlGroup2.Text = "وحدات القياس";
            // 
            // AppProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 768);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AppProductForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة الأصناف";
            this.Load += new System.EventHandler(this.AppProductForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productStatusCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUnitsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit productCategoryLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit productTypeLookUpEdit;
        private DevExpress.XtraEditors.TextEdit productCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit productNameTextEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.PictureEdit productImagePictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.CheckEdit productStatusCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.GridControl productUnitsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}