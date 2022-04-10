using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SecureLineSalesApp.Dtos.Category;
using SecureLineSalesApp.Models;

namespace SecureLineSalesApp.Components.Dashboard.CategoryForm
{
    public partial class CategoryForm : Form
    {
        long id = 0;
        SalesDbContext context = new SalesDbContext();
        Category model = new Category();

        public CategoryForm()
        {
            InitializeComponent();
            bindValues();
        }

        void bindValues()
        {
            var category = from b in context.Categories
                           where b.IsDeleted == 0
                           select new CategoryDTO()
                           {
                               Id = b.Id,
                               CategoryName = b.CategoryName,
                               UpdatedOn = b.UpdatedOn,
                               CreatedOn = b.CreatedOn
                           };
            categoryGridView.DataSource = category.ToList();
        }

        void ResetControls()
        {
            txtCategoryName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.CategoryName = txtCategoryName.Text.Trim();
            model.CreatedOn = DateTime.Now;
            model.UpdatedOn = DateTime.Now;
            try
            {
                context.Categories.Add(model);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Data Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindValues();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoryGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(categoryGridView.SelectedRows[0].Cells[0].Value);
            model = context.Categories.Where(x => x.Id == id).FirstOrDefault();
            txtCategoryName.Text = model.CategoryName;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search = textBox2.Text.ToString();
            var cat = from b in context.Categories where 
                      b.CategoryName.Contains(search)
                      where b.IsDeleted == 0
                      select new CategoryDTO()
                      {
                          Id = b.Id,
                          CategoryName = b.CategoryName,
                          UpdatedOn = b.UpdatedOn,
                          CreatedOn = b.CreatedOn
                      };
            categoryGridView.DataSource = cat.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.Id = id;
            model.UpdatedOn = DateTime.Now;
            model.CategoryName = txtCategoryName.Text.Trim();
            if (!model.CategoryName.Equals(""))
            {
                context.Entry(model).State = EntityState.Modified;
                int result = context.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindValues();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Data Not Updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nothing To Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            model.Id = id;
            model.IsDeleted = 1;
            model.CategoryName = txtCategoryName.Text.Trim();
            if (!model.CategoryName.Equals(""))
            {
                DialogResult dr = MessageBox.Show("Are You Shure You Want To Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    context.Entry(model).State = EntityState.Modified;
                    int result = context.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindValues();
                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing To Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
