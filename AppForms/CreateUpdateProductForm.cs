using Sport;
using Sport.AppForms;
using Sport.Models;
using Sport.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GreatBritain.AppForms
{
    public partial class CreateUpdateProductForm: ParentForm
    {
        Products _product;
        public CreateUpdateProductForm()
        {
            InitializeComponent();
            _product = new Products();
            UserExperienceManager.SetTitle(this, "Новый товар");
        }

        public CreateUpdateProductForm(Products product)
        {
            InitializeComponent();
            _product = product;
            UserExperienceManager.SetTitle(this, $"Изменить товар: \"{_product.NameProduct}\"");
            iDProductArticulNumberTextBox.Enabled = false;
        }

        private void CreateUpdateProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.OrderProduct". При необходимости она может быть перемещена или удалена.
            this.orderProductTableAdapter.Fill(this.sportDataSet.OrderProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.CathegoryProduct". При необходимости она может быть перемещена или удалена.
            this.cathegoryProductTableAdapter.Fill(this.sportDataSet.CathegoryProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.sportDataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.sportDataSet.Manufacturer);

            if (_product == null)
            {
                _product = new Products();
            }

            if (!_product.isNew())
            {
                productsBindingSource.DataSource = _product;

                iDProductArticulNumberTextBox.ReadOnly = true;
            }

            UserExperienceManager.CustomizeControls(splitContainer1.Panel1.Controls);
            UserExperienceManager.CustomizeControls(splitContainer1.Panel2.Controls);
        }

        public static SportDb context = new SportDb();

        private void FillModelFields()
        {
            _product.IDProductArticulNumber = this.iDProductArticulNumberTextBox.Text.Trim(); 
            _product.NameProduct = this.nameProductTextBox.Text.Trim();
            _product.ManufacturerID = (int)this.manufacturerIDComboBox.SelectedValue;
            _product.UnitOfMeasurement = this.unitOfMeasurementTextBox.Text.Trim();
            _product.Cost = (int)this.costNumericUpDown.Value;
            _product.MaxProbablySaleSize = (int)this.maxProbablySaleSizeNumericUpDown.Value;
            _product.SupplierID = (int)this.supplierIDComboBox.SelectedValue;
            _product.CathegoryProductID = (int)this.cathegoryProductIDComboBox.SelectedValue;
            _product.CurrentSale = (int)this.currentSaleNumericUpDown.Value;
            _product.AmountInStock = (int)this.amountInStockNumericUpDown.Value;
            _product.Description = this.descriptionTextBox.Text.Trim();
            _product.Image = (string)this.imageComboBox.SelectedValue;
        }


        private void ValidateGeneral(string userInputText, string field, string messageAboutAllowedSymbols = "поле не должно быть пустым.", string pattern = @"^.+$")
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool isValid = regex.IsMatch(userInputText.Trim());
            if (!isValid)
            {
                throw new ValidationException($"{field}: {messageAboutAllowedSymbols}");
            }
        }

        private void ValidateProductName()
        {
            ValidateGeneral(nameProductTextBox.Text, "Наименование товара");
        }

        private void ValidateArticulName()
        {
            ValidateGeneral(iDProductArticulNumberTextBox.Text, "Наименование артикула");
        }

        private void ValidateUnitOfMeasurement()
        {
            ValidateGeneral(unitOfMeasurementTextBox.Text, "Единица измерения");
        }

        private void ValidateDescription()
        {
            ValidateGeneral(descriptionTextBox.Text, "Описание товара");
        }

       

        private void Validate()
        {
            ValidateDescription();
            ValidateUnitOfMeasurement();
            ValidateArticulName();
            ValidateProductName();
        }

        
        private void saveAttentionBackground_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();

            if (_product.isNew() || !Program.context.Products.Any(p => p.IDProductArticulNumber == _product.IDProductArticulNumber))
            {
                Program.context.Products.Add(_product);
            }
            else
            {
                Program.context.Entry(_product).State = EntityState.Modified;
            }

            DialogResult toBeSaved = MessageBox.Show("Сохранить?", "Запрос подтверждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (toBeSaved == DialogResult.No)
            {
                return;
            }

            try
            {
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
