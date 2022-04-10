using SecureLineSalesApp.Dtos.SubSubCategory;
using SecureLineSalesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureLineSalesApp.Components.Dashboard.SubSubCategoryForm
{
    public partial class SubSubCategoryForm : Form
    {
        long id = 0;
        SalesDbContext context = new SalesDbContext();
        SubSubCategory model = new SubSubCategory();
        public SubSubCategoryForm()
        {
            InitializeComponent();
            BindValues();
            LoadSubCategories();
        }

        void BindValues()
        {
            var Subcategory = from b in context.SubSubCategories
                           where b.IsDeleted == 0
                           select new SubSubCategoryDTO()
                           {
                               Id = b.Id,
                               SubCategory = b.SubCategory.SubCategoryName,
                               SubSubCategoryName = b.SubSubCategoryName,
                               UpdatedOn = b.UpdatedOn,
                               CreatedOn = b.CreatedOn
                           };
            subsubCategoryDataGrid.DataSource = Subcategory.ToList();
        }

        void LoadSubCategories()
        {
            var customers = (from c in context.SubCategories
                             select new { c.SubCategoryName, c.Id })
                             .Distinct().ToList();
            listSubCategory.DataSource = customers;
            listSubCategory.ValueMember = "Id";
            listSubCategory.DisplayMember = "SubCategoryName";
        }

        void ResetControls()
        {
            txtSubSubCategory.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.SubCategoryId = Convert.ToInt32(listSubCategory.SelectedValue.ToString());
            model.SubSubCategoryName = txtSubSubCategory.Text.Trim();
            model.UpdatedOn = DateTime.Now;
            model.CreatedOn = DateTime.Now;
            model.IsDeleted = 0;
            if (model.SubCategoryId > 0)
            {
                if (model.SubSubCategoryName != null)
                {
                    try
                    {
                        context.SubSubCategories.Add(model);
                        int result = context.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Data Inserted Successfull!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            BindValues();
                            ResetControls();
                        }
                        else
                        {
                            MessageBox.Show(
                      "Data Not Inserted!",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show(
                   ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                   "Enter Sub SubCategory Name",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Select SubCategory",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.SubCategoryId = Convert.ToInt32(listSubCategory.SelectedValue.ToString());
            model.SubSubCategoryName = txtSubSubCategory.Text.Trim();
            model.UpdatedOn = DateTime.Now;
            if (model.SubCategoryId > 0)
            {
                if (model.SubSubCategoryName != null)
                {
                    context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    int result = context.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Data Updated Successfull!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BindValues();
                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show(
                  "Data Not Updated!",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                   "Enter Sub SubCategory Name",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Select SubCategory",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void subsubCategoryDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(subsubCategoryDataGrid.SelectedRows[0].Cells[0].Value);
            model = context.SubSubCategories.Where(x => x.Id == id).FirstOrDefault();
            txtSubSubCategory.Text = model.SubSubCategoryName;
            listSubCategory.SelectedValue = model.SubCategoryId;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search = textBox2.Text.ToString();
            var s = from b in context.SubSubCategories
                    where b.SubSubCategoryName.Contains(search) ||
                    b.SubCategory.SubCategoryName.Contains(search) &&
                    b.IsDeleted == 0
                    select new SubSubCategoryDTO()
                    {
                        Id = b.Id,
                        SubCategory = b.SubCategory.SubCategoryName,
                        SubSubCategoryName = b.SubSubCategoryName,
                        UpdatedOn = b.UpdatedOn,
                        CreatedOn = b.CreatedOn
                    };
            subsubCategoryDataGrid.DataSource = s.ToList();
        }
    }
}
