using DAL.Context.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class NorthWind : Form
    {
        NORTHWNDDbContext db = null;

        public NorthWind()
        {
            InitializeComponent();
            db = new NORTHWNDDbContext();
        }

        private void NorthWind_Load(object sender, EventArgs e)
        {
            NORTHWNDDbContext db = new NORTHWNDDbContext();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Product Name";
            dataGridView1.Columns[1].Name = "Supplier Name";
            dataGridView1.Columns[2].Name = "Category Name";
            dataGridView1.Columns[3].Name = "Stock";
            dataGridView1.Columns[4].Name = "Unit Price";
            dataGridView1.Columns[5].Name = "ID";
            dataGridView1.Columns[5].Visible = false;
            var list = db.Products.AsNoTracking().Include("Categories").Include("Suppliers").ToList();
            foreach (var item in list)
            {
                object[] row = new object[]
                {
                    item.ProductName,
                    item.Suppliers.CompanyName,
                    item.Categories.CategoryName,
                    item.UnitsInStock,
                    item.UnitPrice,
                    item.ProductID
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void productUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = move.RowIndex;
            int id = (int)dataGridView1.Rows[index].Cells[5].Value;
            var product = db.Products.Include("Categories").Include("Suppliers").Single(x => x.ProductID == id);
            NorthWindProductUpdate Update = new NorthWindProductUpdate(product, db);
            Update.ShowDialog();
        }
        DataGridViewCellMouseEventArgs move;
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            move = e;
        }
    }
}
