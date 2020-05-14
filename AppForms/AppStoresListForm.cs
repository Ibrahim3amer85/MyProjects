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
    public partial class StoresListForm : DevExpress.XtraEditors.XtraForm
    {
        public StoresListForm()
        {
            InitializeComponent();
            GetData();
        }
        void GetData()
        {

            RefreshData();
            gridView1.OptionsBehavior.Editable = false;
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["Name"].Caption = "الاسم";
            gridView1.DoubleClick += GridView1_DoubleClick;
        }
        void RefreshData()
        {
            var _db = new dbDataContext();
            storesGridControl.DataSource = _db.Stores;
        }
        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            AppStoresForm storesForm = new AppStoresForm(id);

            storesForm.ShowDialog();
            RefreshData();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }
    }
}