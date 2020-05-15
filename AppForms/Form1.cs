using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TabFormExample
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        public DevExpress.XtraBars.TabFormControl tabFormControl;
        public DevExpress.XtraBars.TabFormPage tabFormPage;
        public DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer;
        public Form1()
        {
            InitializeComponent();
            accordionControl1.ElementClick += AccordionControl1_ElementClick;
        }

        private void AccordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            var tag = e.Element.Tag as string;
            if (tag != string.Empty)
            {
                OpenFormByName(tag);
            }

        }
        public void OpenFormByName(string name)
        {
            var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
            if (ins != null)
            {
                var frm = Activator.CreateInstance(ins) as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                if (Application.OpenForms[frm.Name] != null)
                {
                    frm = Application.OpenForms[frm.Name];
                }
                else
                {
                    #region
                    //    container.Controls.Add(frm);
                    //     frm.Show();
                    #endregion
                    frm.FormBorderStyle = FormBorderStyle.None;
                    HandleTabFrom(frm);
                }
            }
        }
        private void HandleTabFrom(Form form)
        {
            this.tabFormControl = new DevExpress.XtraBars.TabFormControl();
            this.tabFormContentContainer = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage = new DevExpress.XtraBars.TabFormPage();
            #region
            //((System.ComponentModel.ISupportInitialize)(this.tabFormControl)).BeginInit();
            //this.SuspendLayout();
            #endregion
            this.TabFormControl.Location = new System.Drawing.Point(0, 0);
            this.TabFormControl.Name = "tabFormControl";
            this.TabFormControl.Pages.Add(this.tabFormPage);
            this.TabFormControl.SelectedPage = this.tabFormPage;
            this.TabFormControl.Size = new System.Drawing.Size(284, 50);
            this.TabFormControl.TabForm = this;
            this.TabFormControl.TabIndex = 0;
            this.TabFormControl.TabStop = false;

            this.tabFormContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer.Name = "tabFormContentContainer";
            this.tabFormContentContainer.Size = new System.Drawing.Size(284, 50);
            this.tabFormContentContainer.TabIndex = 1;

            this.tabFormPage.ContentContainer = this.tabFormContentContainer;
            this.tabFormPage.Name = form.Name;
            this.tabFormPage.Text = form.Text;
            this.tabFormContentContainer.Controls.Add(form);
            #region
            //((System.ComponentModel.ISupportInitialize)(this.tabFormControl)).EndInit();
            //this.ResumeLayout(false);
            #endregion
            form.Show();
        }



    }
}
