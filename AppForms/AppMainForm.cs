using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SalesWithLinq.AppForms
{
    public partial class AppMainForm : DevExpress.XtraBars.TabForm
    {
        //public DevExpress.XtraBars.TabFormControl tabFormControl1;
        //public DevExpress.XtraBars.TabFormPage tabFormPage1;
        //public DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        public AppMainForm()
        {
            InitializeComponent();
            accordionControl1.ElementClick += AccordionControl1_ElementClick;
        }

        private void AccordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            var tag = e.Element.Tag as string;
            if (tag != string.Empty)
            {
                OpenFormByName(tag);
            }
        }

        public  void OpenFormByName(string name)
        {
            //Form frm = null;
            //if (name == "AppCustomerForm")
            //{
            //    frm = new AppCustomerVendorForm(true);
            //}
            //if (name == "AppVendorForm")
            //{
            //    frm = new AppCustomerVendorForm(false);
            //}
            //if (frm != null)
            //{
            //    frm.Show();
            //    return;
            //}
            //else
            //{
                var ins = Assembly.GetExecutingAssembly().GetTypes()
                                               .FirstOrDefault(f => f.Name == name);
                if (ins != null)
                {
                   var frm = Activator.CreateInstance(ins) as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                if (Application.OpenForms[frm.Name] != null)
                    {
                        frm = Application.OpenForms[frm.Name];
                        //frm.BringToFront();
                    }
                    else
                    {
                    frm.FormBorderStyle = FormBorderStyle.None;
                    HandleTabForm(frm);
                    //frm.Show();
                    }

                }
            //}
        }
       private  void HandleTabForm(Form form)
        {
            this.tabFormControl1 = new TabFormControl();
            this.tabFormContentContainer1 = new TabFormContentContainer();
            this.tabFormPage1 = new TabFormPage();
            //((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            //this.SuspendLayout();

            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(284, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;

            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(284, 50);
            this.tabFormContentContainer1.TabIndex = 1;

            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = form.Name;
            this.tabFormPage1.Text = form.Text;

            this.tabFormContentContainer1.Controls.Add(form);

            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(666, 630);
            //this.Controls.Add(this.tabFormContentContainer1);
            //this.Controls.Add(this.tabFormControl1);
            //this.Name = form.Name;
            //this.TabFormControl = this.tabFormControl1;
            //this.Text = form.Text;
            //((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            //this.ResumeLayout(false);
            form.Show();
        }
    }
}
