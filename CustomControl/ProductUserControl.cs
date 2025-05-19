using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sport.Models;
using GreatBritain.AppForms;
using Sport.AppForms;
using Sport.Services;

namespace Sport.CustomControl
{
    public partial class ProductUserControl: UserControl
    {
        private Products _product;
        public ProductUserControl(Products products)
        {
            InitializeComponent();
            _product = products;
            SetLabelTextValues();
            LoadImageFromResources();
        }

        private void SetLabelTextValues()
        {
            productName.Text = $"Наименование товара: {_product.NameProduct}";
            descriptionProduct.Text = $"Описание товара: {_product.Description}";
            manufacturer.Text = $"Производитель: {_product.Manufacturer.Manufacturer1}";
            cost.Text = $"Цена: {_product.Cost}";
            sale.Text = $"Размер скидки: {_product.MaxProbablySaleSize}%";
        }
        
        public static SportDb context = new SportDb();
        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            var user = AuthorizationForm.CurrentUser;

            if (user.Role.Role1 == "Клиент" || user.Role.Role1 == "Менеджер")
            {
                MessageBox.Show("Доступ запрещен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateUpdateProductForm createUpdateProductForm = new CreateUpdateProductForm(_product);
            DialogResult productSaved = createUpdateProductForm.ShowDialog();
            if (productSaved == DialogResult.OK)
            {
                MainForm mainForm = (MainForm)this.Parent.Parent.Parent.Parent;
                mainForm.RefreshProducts();
            }
        }

        private void LoadImageFromResources()
        {
            if (!string.IsNullOrEmpty(_product.Image))
            {
                    // Получаем изображение из ресурсов по имени, указанному в _product.Image
                    object resource = GreatBritain.Properties.Resources.ResourceManager.GetObject(_product.Image.Replace(".jpg", "")); 

                    if (resource != null && resource is Image)
                    {
                        pictureBox1.Image = (Image)resource;
                    }
            }
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {

            UserExperienceManager.CustomizeControls(this.Controls);
            if (_product.MaxProbablySaleSize > 15)
            {
                this.BackColor = ColorTranslator.FromHtml(Sport.Constants.Color.maxProbablySize);
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml(Sport.Constants.Color.auxColor);
            }
        }

        private void ProductUserControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
            ColorTranslator.FromHtml(Sport.Constants.Color.attentionColor), ButtonBorderStyle.Solid);
        }
    }
}
