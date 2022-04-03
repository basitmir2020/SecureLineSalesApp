using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SecureLineSalesApp.Dtos.SubCategory;
using SecureLineSalesApp.Models;

namespace SecureLineSalesApp.Components.Dashboard.SubCategoryForm
{
    public partial class SubCategoryForm : Form
    {
        long id = 0;
        SalesDbContext context = new SalesDbContext();
        SubCategory model = new SubCategory();
        public SubCategoryForm()
        {
            InitializeComponent();
            LoadCategories();
            bindValues();
        }


        void LoadCategories()
        {
            var customers = (from c in context.Categories
                             select new { c.CategoryName, c.Id}).Distinct().ToList();
            listCategories.DataSource = customers;
            listCategories.ValueMember = "Id";
            listCategories.DisplayMember = "CategoryName";
        }

        void bindValues()
        {
            var category = from b in context.SubCategories
                           where b.IsDeleted == 0
                           select new SubCategoryDTO()
                           {
                               Id = b.Id,
                               Category = b.Category.CategoryName,
                               SubCategoryName = b.SubCategoryName,
                               UpdatedOn = b.UpdatedOn,
                               CreatedOn = b.CreatedOn
                           };
            subcategoryDatagrid.DataSource = category.ToList();
        }

        void ResetControls()
        {
            txtSubCategory.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.CategoryId = Convert.ToInt32(listCategories.SelectedValue.ToString());
            model.SubCategoryName = txtSubCategory.Text.Trim();
            model.UpdatedOn = DateTime.Now;
            model.CreatedOn = DateTime.Now;
            model.IsDeleted = 0;
            if(model.SubCategoryName != null)
            {
                context.SubCategories.Add(model);
                int result = context.SaveChanges();
                if(result > 0)
                {
                    MessageBox.Show("Data Inserted Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControls();
                    bindValues();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void subcategoryDatagrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(subcategoryDatagrid.SelectedRows[0].Cells[0].Value);
            model = context.SubCategories.Where(x => x.Id == id).FirstOrDefault();
            txtSubCategory.Text = model.SubCategoryName;
            listCategories.SelectedValue = model.CategoryId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.SubCategoryName = txtSubCategory.Text.Trim();
            model.CategoryId = Convert.ToInt32(listCategories.SelectedValue.ToString());
            model.UpdatedOn = DateTime.Now;
            if (model.SubCategoryName != null)
            {
                context.Entry(model).State = EntityState.Modified;
                int result = context.SaveChanges();
                if(result > 0)
                {
                    MessageBox.Show("Data Updated Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControls();
                    bindValues();
                }
                else
                {
                    MessageBox.Show("Nothing Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nothing To Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search = textBox2.Text.ToString();
            var s = from b in context.SubCategories
                    where b.SubCategoryName.Contains(search) ||
                    b.Category.CategoryName.Contains(search) &&
                    b.IsDeleted == 0
                      select new SubCategoryDTO()
                      {
                          Id = b.Id,
                          Category = b.Category.CategoryName,
                          SubCategoryName = b.SubCategoryName,
                          UpdatedOn = b.UpdatedOn,
                          CreatedOn = b.CreatedOn
                      };
            subcategoryDatagrid.DataSource = s.ToList();
        }
    }
}
