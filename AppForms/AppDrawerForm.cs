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
using SalesWithLinq.DAL;

namespace SalesWithLinq.AppForms
{
    public partial class AppDrawerForm : AppMasterForm
    {
        Drawer _drawer;
        Account _account;
        public AppDrawerForm()
        {
            InitializeComponent();
            New();
        }
        public override void Save()
        {
            if (string.IsNullOrWhiteSpace(drawerNameTextEdit.Text))
            {
                drawerNameTextEdit.ErrorText = "برجاء إدخال اسم الخزينة";
                return;
            }
            var _db = new dbDataContext();
            if (_drawer.ID == 0)
            {
                _account = new Account();
                _db.Drawers.InsertOnSubmit(_drawer);
                _db.Accounts.InsertOnSubmit(_account);
            }
            else
            {
                _db.Drawers.Attach(_drawer);
                _account = _db.Accounts.SingleOrDefault(a => a.ID == _drawer.AccountID);
            }

            SetData();
            _account.Name = _drawer.Name;
            _db.SubmitChanges();
            _drawer.AccountID = _account.ID;
            _db.SubmitChanges();
            base.Save();
        }
        public override void New()
        {
            _drawer = new Drawer();
            base.New();
        }
        public override void GetData()
        {
            drawerNameTextEdit.Text = _drawer.Name;
            base.GetData();
        }
        public override void SetData()
        {
             _drawer.Name= drawerNameTextEdit.Text;
            base.SetData();
        }
    }
}