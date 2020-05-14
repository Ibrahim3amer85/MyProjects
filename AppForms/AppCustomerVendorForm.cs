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
    public partial class AppCustomerVendorForm : AppMasterForm
    {
        bool _isCustomer;
        CustomersAndVendor customersAndVendors;
        Account account;
        public AppCustomerVendorForm(bool isCustomer)
        {
            InitializeComponent();
            New();
            _isCustomer = isCustomer;
        }

        private void AppCustomerVendorForm_Load(object sender, EventArgs e)
        {
            this.Text = (_isCustomer) ? "عميل" : "مورد";
        }
        public override void New()
        {
            customersAndVendors = new CustomersAndVendor();
            base.New();
        }
        public override void GetData()
        {
            nameTextEdit.Text = customersAndVendors.Name;
            phoneTextEdit.Text = customersAndVendors.Phone;
            mobileTextEdit.Text = customersAndVendors.Mobile;
            addressTextEdit.Text = customersAndVendors.Address;
            accountIDTextEdit.Text = customersAndVendors.AccountID.ToString();
            base.GetData();
        }
        public override void SetData()
        {
            customersAndVendors.Name = nameTextEdit.Text;
            customersAndVendors.Phone = phoneTextEdit.Text;
            customersAndVendors.Mobile = mobileTextEdit.Text;
            customersAndVendors.Address = addressTextEdit.Text;
            customersAndVendors.IsCustomer = _isCustomer;
            customersAndVendors.AccountID = Convert.ToInt32(accountIDTextEdit.Text); 
            base.SetData(); 
        }
        bool IsDataValid()
        {
            if (string.IsNullOrWhiteSpace(nameTextEdit.Text))
            {
                nameTextEdit.ErrorText = "هذا الحقل مطلوب";
                return false;
            }
            var _db = new dbDataContext();
            if(_db.CustomersAndVendors.Any(c=>c.Name.Trim()==nameTextEdit.Text
            &&c.ID!=customersAndVendors.ID
            && c.IsCustomer == _isCustomer))
            {
                nameTextEdit.ErrorText = "هذا الإسم موجود مسبقا ";
                return false;
            }
            //another way to check for validation
            ////////if(_db.CustomersAndVendors.Where(c=>c.Name.Trim()==nameTextEdit.Text
            ////////&& c.IsCustomer == _isCustomer).Count() > 0)
            ////////{
            ////////    nameTextEdit.ErrorText = "هذا الإسم موجود مسبقا ";
            ////////    return false;
            ////////}
            ///
            return true;
        }
        public override void Save()
        {
            if (IsDataValid() == false) return;

            var _db = new dbDataContext();
            if (customersAndVendors.ID == 0)
            {
                _db.CustomersAndVendors.InsertOnSubmit(customersAndVendors);
                account = new Account();
                _db.Accounts.InsertOnSubmit(account);
            }

            else
            {
                _db.CustomersAndVendors.Attach(customersAndVendors);
                account = _db.Accounts.SingleOrDefault(a => a.ID == customersAndVendors.AccountID);
            }
                

            SetData();
            account.Name = customersAndVendors.Name;
            _db.SubmitChanges();
            customersAndVendors.AccountID = account.ID;
            _db.SubmitChanges();
            base.Save();
        }
    }
}