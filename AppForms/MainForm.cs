using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sport.CustomControl;
using Sport.AppForms;
using Sport.Models;
using Sport.Services;
using GreatBritain.AppForms;

namespace Sport.AppForms
{
    public partial class MainForm: ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
            UserExperienceManager.SetTitle(this, "Главная формаааааа");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowProducts();
            UserExperienceManager.CustomizeControls(splitContainer1.Panel1.Controls);
        }

        private void ShowProducts()
        {
            List<Products> products = Program.context.Products.OrderBy(p => p.NameProduct).ToList();

            foreach (Products product in products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }
        }

        private void ClearProductList()
        {
            splitContainer1.Panel2.Controls[0].Controls.Clear();
        }

        public void RefreshProducts()
        {
            ClearProductList();
            ShowProducts();
        }

        private void newProductAttentionBackground_Click(object sender, EventArgs e)
        {
            CreateUpdateProductForm createUpdateProductForm = new CreateUpdateProductForm();
            DialogResult productSaved = createUpdateProductForm.ShowDialog();
        
            if (productSaved == DialogResult.OK)
            {
                Refresh();
            }
        }   
    }
}
