using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SalesWithLinq.AppForms
{
    public partial class AppMasterForm : DevExpress.XtraEditors.XtraForm
    {

         public string ErrorText { get 
            {
            return "هذا الحقل مطلوب";
            }
        }
        public AppMasterForm()
        {
            InitializeComponent();
        }
        public virtual void Save()
        {
            XtraMessageBox.Show("تم الحفظ بنجاح");
            RefreshData();
        }
        public virtual void New()
        {
            GetData();
        }
        public virtual void Delete()
        {

        }
        public virtual void GetData()
        {
           
        }
        public virtual void SetData()
        {

        }
        public virtual void RefreshData()
        {

        }
        private void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }
        
        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }
    }
}