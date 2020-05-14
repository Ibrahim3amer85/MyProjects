namespace SalesWithLinq.AppForms
{
    partial class AppMainForm
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.basicDataAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.storeGroupAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.storesAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.storesListAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.categoriesAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addProductAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addCategoryAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.drawersAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addDrawerAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.drawersListAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.companyInfoAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.customerVendorsAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addCustomerAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addVendorAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(291, 126);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(999, 630);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.basicDataAccordionControlElement,
            this.customerVendorsAccordionControlElement});
            this.accordionControl1.Location = new System.Drawing.Point(0, 126);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(291, 630);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // basicDataAccordionControlElement
            // 
            this.basicDataAccordionControlElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.storeGroupAccordionControlElement,
            this.drawersAccordionControlElement,
            this.companyInfoAccordionControlElement});
            this.basicDataAccordionControlElement.Expanded = true;
            this.basicDataAccordionControlElement.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text)});
            this.basicDataAccordionControlElement.Name = "basicDataAccordionControlElement";
            this.basicDataAccordionControlElement.Text = "تعريف البيانات";
            // 
            // storeGroupAccordionControlElement
            // 
            this.storeGroupAccordionControlElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.storesAccordionControlElement,
            this.storesListAccordionControlElement,
            this.categoriesAccordionControlElement});
            this.storeGroupAccordionControlElement.Expanded = true;
            this.storeGroupAccordionControlElement.Name = "storeGroupAccordionControlElement";
            this.storeGroupAccordionControlElement.Text = "الأفرع والمخازن";
            // 
            // storesAccordionControlElement
            // 
            this.storesAccordionControlElement.Expanded = true;
            this.storesAccordionControlElement.Name = "storesAccordionControlElement";
            this.storesAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.storesAccordionControlElement.Tag = "AppStoresForm";
            this.storesAccordionControlElement.Text = "إضافة فرع/مخزن";
            // 
            // storesListAccordionControlElement
            // 
            this.storesListAccordionControlElement.Name = "storesListAccordionControlElement";
            this.storesListAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.storesListAccordionControlElement.Tag = "StoresListForm";
            this.storesListAccordionControlElement.Text = "قائمة الأفرع والمخازن";
            // 
            // categoriesAccordionControlElement
            // 
            this.categoriesAccordionControlElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.addProductAccordionControlElement,
            this.addCategoryAccordionControlElement});
            this.categoriesAccordionControlElement.Expanded = true;
            this.categoriesAccordionControlElement.Name = "categoriesAccordionControlElement";
            this.categoriesAccordionControlElement.Text = "الأصناف والمجموعات";
            // 
            // addProductAccordionControlElement
            // 
            this.addProductAccordionControlElement.Name = "addProductAccordionControlElement";
            this.addProductAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addProductAccordionControlElement.Tag = "AppProductForm";
            this.addProductAccordionControlElement.Text = "إضافة صنف";
            // 
            // addCategoryAccordionControlElement
            // 
            this.addCategoryAccordionControlElement.Name = "addCategoryAccordionControlElement";
            this.addCategoryAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addCategoryAccordionControlElement.Tag = "AppProductCategoryForm";
            this.addCategoryAccordionControlElement.Text = "اضافة مجموعة";
            // 
            // drawersAccordionControlElement
            // 
            this.drawersAccordionControlElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.addDrawerAccordionControlElement,
            this.drawersListAccordionControlElement});
            this.drawersAccordionControlElement.Expanded = true;
            this.drawersAccordionControlElement.Name = "drawersAccordionControlElement";
            this.drawersAccordionControlElement.Text = "الخزائن";
            // 
            // addDrawerAccordionControlElement
            // 
            this.addDrawerAccordionControlElement.Name = "addDrawerAccordionControlElement";
            this.addDrawerAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addDrawerAccordionControlElement.Tag = "AppDrawerForm";
            this.addDrawerAccordionControlElement.Text = "إضافة خزينة";
            // 
            // drawersListAccordionControlElement
            // 
            this.drawersListAccordionControlElement.Name = "drawersListAccordionControlElement";
            this.drawersListAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.drawersListAccordionControlElement.Text = "قائمة الخزائن";
            // 
            // companyInfoAccordionControlElement
            // 
            this.companyInfoAccordionControlElement.Expanded = true;
            this.companyInfoAccordionControlElement.Name = "companyInfoAccordionControlElement";
            this.companyInfoAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.companyInfoAccordionControlElement.Text = "بيانات الشركة";
            // 
            // customerVendorsAccordionControlElement
            // 
            this.customerVendorsAccordionControlElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.addCustomerAccordionControlElement,
            this.addVendorAccordionControlElement});
            this.customerVendorsAccordionControlElement.Expanded = true;
            this.customerVendorsAccordionControlElement.Name = "customerVendorsAccordionControlElement";
            this.customerVendorsAccordionControlElement.Text = "العملاء والموردين";
            // 
            // addCustomerAccordionControlElement
            // 
            this.addCustomerAccordionControlElement.Name = "addCustomerAccordionControlElement";
            this.addCustomerAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addCustomerAccordionControlElement.Tag = "AppCustomerForm";
            this.addCustomerAccordionControlElement.Text = "إضافة عميل";
            // 
            // addVendorAccordionControlElement
            // 
            this.addVendorAccordionControlElement.Name = "addVendorAccordionControlElement";
            this.addVendorAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addVendorAccordionControlElement.Tag = "AppVendorForm";
            this.addVendorAccordionControlElement.Text = "إضافة مورد";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 88);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1290, 38);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(1290, 88);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 3;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 88);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1290, 668);
            this.tabFormContentContainer1.TabIndex = 4;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 756);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "AppMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "AppMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement companyInfoAccordionControlElement;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement storesAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement drawersAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement storesListAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement storeGroupAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement basicDataAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addDrawerAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement drawersListAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement customerVendorsAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addCustomerAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addVendorAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addProductAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement categoriesAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addCategoryAccordionControlElement;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
    }
}