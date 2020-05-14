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
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils.Extensions;

namespace SalesWithLinq.AppForms
{
    public partial class AppProductForm : AppMasterForm
    {
        dbDataContext _newDB = new dbDataContext();
        Product _product;
        ProductCategory _productCategory;
        RepositoryItemCalcEdit calc = new RepositoryItemCalcEdit();
        RepositoryItemLookUpEdit lookUpEdit = new RepositoryItemLookUpEdit();
        public AppProductForm()
        {
            InitializeComponent();
            RefreshData();
            New();
        }
        public override void New()
        {
            _product = new Product();
            base.New();
        }
        public override void GetData()
        {
            productNameTextEdit.Text = _product.Name;
            productCodeTextEdit.Text = _product.Code;
            productCategoryLookUpEdit.EditValue = _product.CategoryID;
            productTypeLookUpEdit.EditValue = _product.Type;
            descriptionMemoEdit.Text = _product.Description;
            //productStatusCheckEdit.Checked = _product.IsActive==true ? true  :false;
            
            productUnitsGridControl.DataSource = _newDB.ProductUnits.Where(u => u.ProductID == _product.ID);
            base.GetData();
        }
        Byte[] GetByteFromImage(Image image)
        {
            using(MemoryStream stream=new MemoryStream())
            {
                try
                {
                    image.Save(stream, ImageFormat.Jpeg);
                    return stream.ToArray();
                }
                catch (Exception)
                {
                    return stream.ToArray();
                }
            }
        }
        public override void SetData()
        {
            _product.Name= productNameTextEdit.Text;
            _product.Code= productCodeTextEdit.Text;
            _product.CategoryID= Convert.ToInt32(productCategoryLookUpEdit.EditValue);
            _product.Type= Convert.ToByte(productTypeLookUpEdit.EditValue);
            _product.Description= descriptionMemoEdit.Text;
            _product.IsActive = productStatusCheckEdit.Checked;
            _product.Image = GetByteFromImage(productImagePictureEdit.Image);
            base.SetData();
        }
     
        bool IsDataValid()
        {
            if(productCategoryLookUpEdit.EditValue is int == false)
            {
                productCategoryLookUpEdit.ErrorText = ErrorText;
                return false;
            }
            if (productTypeLookUpEdit.EditValue is int == false)
            {
                productTypeLookUpEdit.ErrorText = ErrorText;
                return false;
            }
            if (string.IsNullOrWhiteSpace(productNameTextEdit.Text))
            {
                productNameTextEdit.ErrorText = ErrorText;
                return false;
            }
            if (string.IsNullOrWhiteSpace(productCodeTextEdit.Text))
            {
                productNameTextEdit.ErrorText = ErrorText;
                return false;
            }
            var _db = new dbDataContext();
            if (_db.Products.Any(c => c.Name.Trim() == productNameTextEdit.Text
             && c.ID != _product.ID
             &&c.CategoryID==productCategoryLookUpEdit.EditValue as int?))
            {
                var categoryName = _db.ProductCategories.SingleOrDefault(c => c.ID == productCategoryLookUpEdit.EditValue as int?);
                productNameTextEdit.ErrorText = "هذا الإسم موجود داخل  "+categoryName.Name +"\n"+"اختر اسم آخر";
                return false;
            }
            if (_db.Products.Any(c => c.Code.Trim() == productCodeTextEdit.Text
             && c.ID != _product.ID))
            {
                productNameTextEdit.ErrorText = "هذا الكود مكرر   ";
                return false;
            }
            return true;
        }
        public override void RefreshData()
        {
            using(var _db=new dbDataContext())
            {
                productCategoryLookUpEdit.Properties.DataSource = _db.ProductCategories
                    .Where(x=>_db.ProductCategories.Where(c=>c.ParentID==x.ID).Count()==0).ToList();
                lookUpEdit.DataSource = _db.Units.ToList();
            }
            base.RefreshData();
        }
        public override void Save()
        {
            if (IsDataValid() == false) return;

            var _db = new dbDataContext();
            if (_product.ID == 0)
            {
                _db.Products.InsertOnSubmit(_product);
            }

            else
            {
                _db.Products.Attach(_product);
            }
            SetData();
            _db.SubmitChanges();
            _newDB.SubmitChanges();
            base.Save();
        }

        private void AppProductForm_Load(object sender, EventArgs e)
        {
            productCategoryLookUpEdit.Properties.DisplayMember = nameof(_productCategory.Name);
            productCategoryLookUpEdit.Properties.ValueMember = nameof(_productCategory.ID);
            productCategoryLookUpEdit.ProcessNewValue += ProductCategoryLookUpEdit_ProcessNewValue;
            productCategoryLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            var ins = new ProductUnit();

            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            gridView1.Columns[nameof(ins.ID)].Visible = false;
            gridView1.Columns[nameof(ins.ProductID)].Visible = false;

            

            productUnitsGridControl.RepositoryItems.Add(lookUpEdit);
            productUnitsGridControl.RepositoryItems.Add(calc);
            gridView1.Columns[nameof(ins.SellPrice)].ColumnEdit = calc;
            gridView1.Columns[nameof(ins.BuyPrice)].ColumnEdit = calc;
            gridView1.Columns[nameof(ins.SellDiscount)].ColumnEdit = calc;
            gridView1.Columns[nameof(ins.UnitID)].ColumnEdit = lookUpEdit;

            productTypeLookUpEdit.Properties.DataSource = new List<ValuAndID>() { new ValuAndID { ID=0,Name="صنف مخزنى"},
            new ValuAndID{ID=1,Name="صنف خدمى"}};
            productTypeLookUpEdit.Properties.DisplayMember = nameof(ValuAndID.Name);
            productTypeLookUpEdit.Properties.ValueMember = nameof(ValuAndID.ID);

            lookUpEdit.DisplayMember = "UnitName";
            lookUpEdit.ValueMember = "ID";
            lookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit.ProcessNewValue += LookUpEdit_ProcessNewValue;
        }

        private void LookUpEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
           if(e.DisplayValue is string st&&st.Trim()!=string.Empty)
            {
                var newUnit = new Unit { UnitName = st };
                using(var _db = new dbDataContext())
                {
                    _db.Units.InsertOnSubmit(newUnit);
                    _db.SubmitChanges();
                }
                ((List<Unit>)lookUpEdit.DataSource).Add(newUnit);
                e.Handled = true;
            }
        }

        public class ValuAndID
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void ProductCategoryLookUpEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue is string st && st.Trim() != string.Empty)
            {
                var newCategory = new ProductCategory { Name = st, ParentID = 0 ,Number="0"};
                using (var _db = new dbDataContext())
                {
                    _db.ProductCategories.InsertOnSubmit(newCategory);
                    _db.SubmitChanges();
                }
                ((List<ProductCategory>)productCategoryLookUpEdit.Properties.DataSource).Add(newCategory);
                e.Handled = true;
            }
        }
    }
}