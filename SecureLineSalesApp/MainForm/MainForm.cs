using SecureLineSalesApp.Components.Dashboard.SubSubCategory;
using SecureLineSalesApp.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;
using SecureLineSalesApp.Components.Dashboard.Products;
using SecureLineSalesApp.Components.Dashboard.Variation;
using SecureLineSalesApp.Components.Dashboard.Variation.ProductVariation;
using SecureLineSalesApp.Components.Dashboard.Price;
using SecureLineSalesApp.Components.Dashboard.Stock;
using SecureLineSalesApp.Components;
using SecureLineSalesApp.Components.Dashboard.CategoryForm;
using SecureLineSalesApp.Components.Dashboard.SubCategoryForm;

namespace SecureLineSalesApp.MainForm
{
    public partial class MainForm : Form
    {
        private Button currentBtn;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while(tempIndex  == index)
            {
              index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object BtnSender)
        {
            if (BtnSender != null)
            {
                if (currentBtn != (Button)BtnSender)
                {
                    DisabledButton();
                    Color color = SelectThemeColor();
                    currentBtn = (Button)BtnSender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTittleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisabledButton()
        {
            foreach (Control previousBtn in Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(46, 52, 64);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System
                        .Drawing
                        .Font("Microsoft Sans Serif",
                        10F,
                        System.Drawing.FontStyle.Regular, 
                        System.Drawing.GraphicsUnit.Point, 
                        ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashBoard(), sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm(), sender);
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubCategoryForm(), sender);
        }

        private void btnSubSubCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubSubCategory(), sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Products(), sender);
        }

        private void btnVariation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Variation(), sender);
        }

        private void btnProductVariation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductVariation(), sender);
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Price(), sender);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Stock(), sender);
        }
    }
}
