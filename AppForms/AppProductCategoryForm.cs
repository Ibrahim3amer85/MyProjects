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
using DevExpress.XtraTab.Drawing;

namespace SalesWithLinq.AppForms
{
    public partial class AppProductCategoryForm : AppMasterForm
    {
        ProductCategory _productCategory;
        public AppProductCategoryForm()
        {
            InitializeComponent();
            New();
        }
        public override void GetData()
        {
            nameTextEdit.Text = _productCategory.Name;
            productCategorylookUpEdit.EditValue = _productCategory.ParentID;
            base.GetData();
        }
        public override void SetData()
        {
            _productCategory.Name = nameTextEdit.Text;
            _productCategory.ParentID= (productCategorylookUpEdit.EditValue as int?)??0;
            _productCategory.Number = "0";
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
            if (_db.ProductCategories.Any(c => c.Name.Trim() == nameTextEdit.Text
             && c.ID != _productCategory.ID
             && c.ParentID == productCategorylookUpEdit.EditValue as int?
             ))
            {
                nameTextEdit.ErrorText = "هذا الإسم موجود مسبقا ";
                return false;
            }
            //if (_db.ProductCategories.Where(c => c.Name.Trim() == nameTextEdit.Text
            // && c.ID != _productCategory.ID
            // //&& c.ParentID == _productCategory.ParentID
            // ).Count()>0)
            //{
            //    nameTextEdit.ErrorText = "هذا الإسم موجود مسبقا ";
            //    return false;
            //}

            return true;
        }
        public override void Save()
        {
            if (IsDataValid() == false) return;

            var _db = new dbDataContext();
            if (_productCategory.ID == 0)
            {
                _db.ProductCategories.InsertOnSubmit(_productCategory);
            }

            else
            {
                _db.ProductCategories.Attach(_productCategory);  
            }
            SetData();
            _db.SubmitChanges();
            base.Save();
        }
        public override void New()
        {
            _productCategory = new ProductCategory();
            base.New();
        }
        public override void RefreshData()
        {
            var _db = new dbDataContext();
            var groups = _db.ProductCategories.OrderBy(p => p.ID);
            productCategorylookUpEdit.Properties.DataSource = groups;
            treeList1.DataSource = groups;
            treeList1.OptionsBehavior.Editable = false;
            treeList1.Columns[nameof(_productCategory.Name)].Caption = "الإسم";
            treeList1.Columns[nameof(_productCategory.Number)].Visible = false;
            base.RefreshData();
        }
        private void AppProductCategoryForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            productCategorylookUpEdit.Properties.DisplayMember = nameof(_productCategory.Name);
            productCategorylookUpEdit.Properties.ValueMember = nameof(_productCategory.ID);
            treeList1.ParentFieldName = nameof(_productCategory.ParentID);
            treeList1.KeyFieldName = nameof(_productCategory.ID);
            treeList1.FocusedNodeChanged += TreeList1_FocusedNodeChanged;
        }

        private void TreeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            int id = 0;
            if(int.TryParse(e.Node.GetValue(nameof(_productCategory.ID )).ToString(),out id))
            {
                var _db = new dbDataContext();
                _productCategory = _db.ProductCategories.SingleOrDefault(p => p.ID == id);
                GetData();
            }
               
               
            
        }
    }
}