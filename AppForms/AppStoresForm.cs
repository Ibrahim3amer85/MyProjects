using DevExpress.XtraEditors;
using SalesWithLinq.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWithLinq.AppForms
{
    public partial class AppStoresForm : XtraForm
    {
        Store _store;
        public AppStoresForm()
        {
            InitializeComponent();
            New();
        }
        public AppStoresForm(int id)
        {
            InitializeComponent();
            var db = new dbDataContext();
            _store = db.Stores.SingleOrDefault(p => p.ID == id);
            companyNameTextEdit.Text = _store.Name;
            //another Way
            //_store = db.Stores.Where(s => s.ID == id).FirstOrDefault();
        }
        void Save()
        {
            if (string.IsNullOrWhiteSpace(companyNameTextEdit.Text))
            {
                companyNameTextEdit.ErrorText = "برجاء إدخال اسم الفرع او المخزن";
                return;
            }
            var _db = new dbDataContext();
            if (_store.ID == 0)
                _db.Stores.InsertOnSubmit(_store);
            else
                _db.Stores.Attach(_store);

            SetData();
            _db.SubmitChanges();
        }
        void GetData()
        {
            companyNameTextEdit.Text = _store.Name;
        }
        void SetData()
        {
           _store.Name= companyNameTextEdit.Text;
        }
        void New()
        {
            _store = new Store();
            GetData();
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void barBtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _db = new dbDataContext();
            if(XtraMessageBox.Show(text:"هل تريد حذف المخزن",caption:"تأكيد الحذف",
                buttons: MessageBoxButtons.YesNo,icon:MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _db.Stores.Attach(_store);
                _db.Stores.DeleteOnSubmit(_store);
                _db.SubmitChanges();
                XtraMessageBox.Show("تم الحذف بنجاح");
                New();
            }
            
        }
    }
}
