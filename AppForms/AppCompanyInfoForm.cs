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
using System.Runtime.Remoting.Contexts;
using DevExpress.Data.Filtering.Helpers;

namespace SalesWithLinq.AppForms
{
    public partial class AppCompanyInfoForm : DevExpress.XtraEditors.XtraForm
    {
        public AppCompanyInfoForm()
        {
            InitializeComponent();
            this.Load += CompanyInfoForm_Load;
        }

        private void CompanyInfoForm_Load(object sender, EventArgs e)
        {
            GetDataWithProfessionalWay();
            //GetDataWithOldWay();
        }
        void GetDataWithProfessionalWay()
        {
            dbDataContext _db = new dbDataContext();
            var getCompanyInfo = _db.CompanyInfos.FirstOrDefault();
            if (getCompanyInfo == null) return;
            companyNameTextEdit.Text = getCompanyInfo.CompanyName;
            addressTextEdit.Text = getCompanyInfo.Address;
            telephoneTextEdit.Text = getCompanyInfo.Phone;
            mobileTextEdit.Text = getCompanyInfo.Mobile;
        }
        void GetDataWithOldWay()
        {
            dbDataContext _db = new dbDataContext();

            var checkCompanyInfo = _db.CompanyInfos.OrderBy(p => p.ID).ToList();
            bool isEmpty = !checkCompanyInfo.Any();
            if (isEmpty)
            {
                companyNameTextEdit.Text = "أدخل اسم الشركة";
                addressTextEdit.Text = "أدخل عنوان الشركة";
                telephoneTextEdit.Text = "111111";
                mobileTextEdit.Text = "0102036521541";
            }
            else
            {
                var getCompanyInfo = _db.CompanyInfos.FirstOrDefault();

                companyNameTextEdit.Text = getCompanyInfo.CompanyName;
                addressTextEdit.Text = getCompanyInfo.Address;
                telephoneTextEdit.Text = getCompanyInfo.Phone;
                mobileTextEdit.Text = getCompanyInfo.Mobile;
            }
        }
        private void saveDataBarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveWithProfessionalWay();
        }
        void SaveWithProfessionalWay()
        {
            if (string.IsNullOrWhiteSpace(companyNameTextEdit.Text))
            {
                companyNameTextEdit.ErrorText = "برجاء إدخال اسم الشركة";
                return;
            }

            dbDataContext context = new dbDataContext();

            var info = context.CompanyInfos.FirstOrDefault();
            if (info == null)
            {
                info = new CompanyInfo();
                info.CompanyName = companyNameTextEdit.Text;
                info.Phone = telephoneTextEdit.Text;
                info.Mobile = mobileTextEdit.Text;
                info.Address = addressTextEdit.Text;
                context.CompanyInfos.InsertOnSubmit(info);
                context.SubmitChanges();
            }
            else
            {
                info.CompanyName = companyNameTextEdit.Text;
                info.Phone = telephoneTextEdit.Text;
                info.Mobile = mobileTextEdit.Text;
                info.Address = addressTextEdit.Text;
                context.SubmitChanges();
            }
        }
        void SaveWithOldWay()
        {
            using (var context = new dbDataContext())
            {
                if (string.IsNullOrWhiteSpace(companyNameTextEdit.Text))
                {
                    companyNameTextEdit.ErrorText = "برجاء إدخال اسم الشركة";
                    return;
                }
                var checkCompanyInfo = context.CompanyInfos.OrderBy(p => p.ID).ToList();
                bool isEmpty = !checkCompanyInfo.Any();
                if (isEmpty)
                {
                    CompanyInfo info = new CompanyInfo();
                    info.CompanyName = companyNameTextEdit.Text;
                    info.Phone = telephoneTextEdit.Text;
                    info.Mobile = mobileTextEdit.Text;
                    info.Address = addressTextEdit.Text;
                    context.CompanyInfos.InsertOnSubmit(info);
                    context.SubmitChanges();
                }
                else
                {
                    var info = context.CompanyInfos.FirstOrDefault();
                    info.CompanyName = companyNameTextEdit.Text;
                    info.Phone = telephoneTextEdit.Text;
                    info.Mobile = mobileTextEdit.Text;
                    info.Address = addressTextEdit.Text;
                    //context.CompanyInfos.InsertOnSubmit(info);
                    context.SubmitChanges();
                }
            }
        }
    }
}