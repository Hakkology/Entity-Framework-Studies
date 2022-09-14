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
    public partial class NorthWindProductUpdate : Form
    {
        Products product = null;
        NORTHWNDDbContext Db = null;

        public NorthWindProductUpdate(Products products, NORTHWNDDbContext db)
        {
            InitializeComponent();
            this.product = products;
            this.Db = db;
        }

        private void NorthWindProductUpdate_Load(object sender, EventArgs e)
        {
            textBox_name.Text = product.ProductName;
            numericUpDown1.Value = Convert.ToDecimal(product.UnitsInStock);

            var supplier = Db.Suppliers.AsNoTracking().Select(x => x.CompanyName).ToList();
            comboBox_Supplier.Items.AddRange(supplier.ToArray());
            comboBox_Supplier.SelectedItem = product.Suppliers.CompanyName;

            var category = Db.Categories.AsNoTracking().Select(x => x.CategoryName).ToList();
            comboBox_Categories.Items.AddRange(category.ToArray());
            comboBox_Categories.SelectedItem = product.Categories.CategoryName;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            product.ProductName = textBox_name.Text;
            product.UnitsInStock = Convert.ToInt16(numericUpDown1.Value);
            var s = comboBox_Supplier.SelectedItem.ToString();
            var c = comboBox_Categories.SelectedItem.ToString();
            var sId = Db.Suppliers.FirstOrDefault(x => x.CompanyName == s).SupplierID;
            var cId = Db.Categories.FirstOrDefault(x => x.CategoryName == c).CategoryID;
            product.CategoryID = cId;
            product.SupplierID = sId;
            Db.SaveChanges();
            if (Db.SaveChanges()>0)
            {
                MessageBox.Show(product.ProductName + " " + "Product successfully updated. ");
            }
        }
    }
}
