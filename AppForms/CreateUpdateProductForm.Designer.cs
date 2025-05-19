namespace GreatBritain.AppForms
{
    partial class CreateUpdateProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameProductLabel;
            System.Windows.Forms.Label unitOfMeasurementLabel;
            System.Windows.Forms.Label maxProbablySaleSizeLabel;
            System.Windows.Forms.Label manufacturerIDLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label cathegoryProductIDLabel;
            System.Windows.Forms.Label currentSaleLabel;
            System.Windows.Forms.Label amountInStockLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label iDProductArticulNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateProductForm));
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportDataSet = new GreatBritain.SportDataSet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDProductArticulNumberTextBox = new System.Windows.Forms.TextBox();
            this.imageComboBox = new System.Windows.Forms.ComboBox();
            this.saveAttentionBackground = new System.Windows.Forms.Button();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.unitOfMeasurementTextBox = new System.Windows.Forms.TextBox();
            this.maxProbablySaleSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manufacturerIDComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cathegoryProductIDComboBox = new System.Windows.Forms.ComboBox();
            this.cathegoryProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentSaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountInStockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.orderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new GreatBritain.SportDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new GreatBritain.SportDataSetTableAdapters.TableAdapterManager();
            this.cathegoryProductTableAdapter = new GreatBritain.SportDataSetTableAdapters.CathegoryProductTableAdapter();
            this.manufacturerTableAdapter = new GreatBritain.SportDataSetTableAdapters.ManufacturerTableAdapter();
            this.supplierTableAdapter = new GreatBritain.SportDataSetTableAdapters.SupplierTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.orderProductTableAdapter = new GreatBritain.SportDataSetTableAdapters.OrderProductTableAdapter();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKOrderProductProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameProductLabel = new System.Windows.Forms.Label();
            unitOfMeasurementLabel = new System.Windows.Forms.Label();
            maxProbablySaleSizeLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            cathegoryProductIDLabel = new System.Windows.Forms.Label();
            currentSaleLabel = new System.Windows.Forms.Label();
            amountInStockLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            iDProductArticulNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxProbablySaleSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathegoryProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSaleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInStockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderProductProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameProductLabel
            // 
            nameProductLabel.AutoSize = true;
            nameProductLabel.Location = new System.Drawing.Point(46, 41);
            nameProductLabel.Name = "nameProductLabel";
            nameProductLabel.Size = new System.Drawing.Size(99, 15);
            nameProductLabel.TabIndex = 2;
            nameProductLabel.Text = "Название товара:";
            // 
            // unitOfMeasurementLabel
            // 
            unitOfMeasurementLabel.AutoSize = true;
            unitOfMeasurementLabel.Location = new System.Drawing.Point(46, 70);
            unitOfMeasurementLabel.Name = "unitOfMeasurementLabel";
            unitOfMeasurementLabel.Size = new System.Drawing.Size(87, 15);
            unitOfMeasurementLabel.TabIndex = 4;
            unitOfMeasurementLabel.Text = "Ед. измерения:";
            // 
            // maxProbablySaleSizeLabel
            // 
            maxProbablySaleSizeLabel.AutoSize = true;
            maxProbablySaleSizeLabel.Location = new System.Drawing.Point(46, 125);
            maxProbablySaleSizeLabel.Name = "maxProbablySaleSizeLabel";
            maxProbablySaleSizeLabel.Size = new System.Drawing.Size(141, 15);
            maxProbablySaleSizeLabel.TabIndex = 8;
            maxProbablySaleSizeLabel.Text = "Макс. возможная скидка:";
            // 
            // manufacturerIDLabel
            // 
            manufacturerIDLabel.AutoSize = true;
            manufacturerIDLabel.Location = new System.Drawing.Point(46, 157);
            manufacturerIDLabel.Name = "manufacturerIDLabel";
            manufacturerIDLabel.Size = new System.Drawing.Size(95, 15);
            manufacturerIDLabel.TabIndex = 10;
            manufacturerIDLabel.Text = "Производитель:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(46, 186);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(71, 15);
            supplierIDLabel.TabIndex = 12;
            supplierIDLabel.Text = "Поставщик:";
            // 
            // cathegoryProductIDLabel
            // 
            cathegoryProductIDLabel.AutoSize = true;
            cathegoryProductIDLabel.Location = new System.Drawing.Point(46, 215);
            cathegoryProductIDLabel.Name = "cathegoryProductIDLabel";
            cathegoryProductIDLabel.Size = new System.Drawing.Size(104, 15);
            cathegoryProductIDLabel.TabIndex = 14;
            cathegoryProductIDLabel.Text = "Категория товара:";
            // 
            // currentSaleLabel
            // 
            currentSaleLabel.AutoSize = true;
            currentSaleLabel.Location = new System.Drawing.Point(46, 241);
            currentSaleLabel.Name = "currentSaleLabel";
            currentSaleLabel.Size = new System.Drawing.Size(94, 15);
            currentSaleLabel.TabIndex = 16;
            currentSaleLabel.Text = "Текущая скидка:";
            // 
            // amountInStockLabel
            // 
            amountInStockLabel.AutoSize = true;
            amountInStockLabel.Location = new System.Drawing.Point(46, 270);
            amountInStockLabel.Name = "amountInStockLabel";
            amountInStockLabel.Size = new System.Drawing.Size(103, 15);
            amountInStockLabel.TabIndex = 18;
            amountInStockLabel.Text = "Кол-во на складе:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(46, 302);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 15);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Описание:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(46, 95);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(67, 15);
            costLabel.TabIndex = 23;
            costLabel.Text = "Стоимость:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(46, 331);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(42, 15);
            imageLabel.TabIndex = 25;
            imageLabel.Text = "Image:";
            // 
            // iDProductArticulNumberLabel
            // 
            iDProductArticulNumberLabel.AutoSize = true;
            iDProductArticulNumberLabel.Location = new System.Drawing.Point(46, 12);
            iDProductArticulNumberLabel.Name = "iDProductArticulNumberLabel";
            iDProductArticulNumberLabel.Size = new System.Drawing.Size(54, 15);
            iDProductArticulNumberLabel.TabIndex = 26;
            iDProductArticulNumberLabel.Text = "Артикул:";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.sportDataSet;
            // 
            // sportDataSet
            // 
            this.sportDataSet.DataSetName = "SportDataSet";
            this.sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.titleLabelAttentionFont);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(iDProductArticulNumberLabel);
            this.splitContainer1.Panel2.Controls.Add(this.iDProductArticulNumberTextBox);
            this.splitContainer1.Panel2.Controls.Add(imageLabel);
            this.splitContainer1.Panel2.Controls.Add(this.imageComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.saveAttentionBackground);
            this.splitContainer1.Panel2.Controls.Add(costLabel);
            this.splitContainer1.Panel2.Controls.Add(this.costNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(nameProductLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nameProductTextBox);
            this.splitContainer1.Panel2.Controls.Add(unitOfMeasurementLabel);
            this.splitContainer1.Panel2.Controls.Add(this.unitOfMeasurementTextBox);
            this.splitContainer1.Panel2.Controls.Add(maxProbablySaleSizeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxProbablySaleSizeNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(manufacturerIDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.manufacturerIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(supplierIDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.supplierIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(cathegoryProductIDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cathegoryProductIDComboBox);
            this.splitContainer1.Panel2.Controls.Add(currentSaleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.currentSaleNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(amountInStockLabel);
            this.splitContainer1.Panel2.Controls.Add(this.amountInStockNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(390, 562);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 2;
            // 
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(101, 20);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(90, 15);
            this.titleLabelAttentionFont.TabIndex = 1;
            this.titleLabelAttentionFont.Text = "Добавить товар";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iDProductArticulNumberTextBox
            // 
            this.iDProductArticulNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "IDProductArticulNumber", true));
            this.iDProductArticulNumberTextBox.Location = new System.Drawing.Point(197, 9);
            this.iDProductArticulNumberTextBox.Name = "iDProductArticulNumberTextBox";
            this.iDProductArticulNumberTextBox.Size = new System.Drawing.Size(120, 23);
            this.iDProductArticulNumberTextBox.TabIndex = 27;
            // 
            // imageComboBox
            // 
            this.imageComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Image", true));
            this.imageComboBox.DataSource = this.productsBindingSource;
            this.imageComboBox.DisplayMember = "Image";
            this.imageComboBox.FormattingEnabled = true;
            this.imageComboBox.Location = new System.Drawing.Point(197, 328);
            this.imageComboBox.Name = "imageComboBox";
            this.imageComboBox.Size = new System.Drawing.Size(121, 23);
            this.imageComboBox.TabIndex = 26;
            this.imageComboBox.ValueMember = "Image";
            // 
            // saveAttentionBackground
            // 
            this.saveAttentionBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveAttentionBackground.Location = new System.Drawing.Point(23, 378);
            this.saveAttentionBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveAttentionBackground.Name = "saveAttentionBackground";
            this.saveAttentionBackground.Size = new System.Drawing.Size(327, 57);
            this.saveAttentionBackground.TabIndex = 17;
            this.saveAttentionBackground.Text = "Сохранить";
            this.saveAttentionBackground.UseVisualStyleBackColor = true;
            this.saveAttentionBackground.Click += new System.EventHandler(this.saveAttentionBackground_Click);
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "Cost", true));
            this.costNumericUpDown.Location = new System.Drawing.Point(197, 95);
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.costNumericUpDown.TabIndex = 24;
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "NameProduct", true));
            this.nameProductTextBox.Location = new System.Drawing.Point(197, 38);
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.Size = new System.Drawing.Size(121, 23);
            this.nameProductTextBox.TabIndex = 3;
            // 
            // unitOfMeasurementTextBox
            // 
            this.unitOfMeasurementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitOfMeasurement", true));
            this.unitOfMeasurementTextBox.Location = new System.Drawing.Point(197, 67);
            this.unitOfMeasurementTextBox.Name = "unitOfMeasurementTextBox";
            this.unitOfMeasurementTextBox.Size = new System.Drawing.Size(121, 23);
            this.unitOfMeasurementTextBox.TabIndex = 5;
            // 
            // maxProbablySaleSizeNumericUpDown
            // 
            this.maxProbablySaleSizeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "MaxProbablySaleSize", true));
            this.maxProbablySaleSizeNumericUpDown.Location = new System.Drawing.Point(197, 125);
            this.maxProbablySaleSizeNumericUpDown.Name = "maxProbablySaleSizeNumericUpDown";
            this.maxProbablySaleSizeNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.maxProbablySaleSizeNumericUpDown.TabIndex = 9;
            // 
            // manufacturerIDComboBox
            // 
            this.manufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "ManufacturerID", true));
            this.manufacturerIDComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIDComboBox.DisplayMember = "Manufacturer";
            this.manufacturerIDComboBox.FormattingEnabled = true;
            this.manufacturerIDComboBox.Location = new System.Drawing.Point(197, 154);
            this.manufacturerIDComboBox.Name = "manufacturerIDComboBox";
            this.manufacturerIDComboBox.Size = new System.Drawing.Size(121, 23);
            this.manufacturerIDComboBox.TabIndex = 11;
            this.manufacturerIDComboBox.ValueMember = "IDManufacturer";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.sportDataSet;
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "SupplierID", true));
            this.supplierIDComboBox.DataSource = this.supplierBindingSource;
            this.supplierIDComboBox.DisplayMember = "Supplier";
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.Location = new System.Drawing.Point(197, 183);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(121, 23);
            this.supplierIDComboBox.TabIndex = 13;
            this.supplierIDComboBox.ValueMember = "IDSupplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.sportDataSet;
            // 
            // cathegoryProductIDComboBox
            // 
            this.cathegoryProductIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "CathegoryProductID", true));
            this.cathegoryProductIDComboBox.DataSource = this.cathegoryProductBindingSource;
            this.cathegoryProductIDComboBox.DisplayMember = "CathegoryProduct";
            this.cathegoryProductIDComboBox.FormattingEnabled = true;
            this.cathegoryProductIDComboBox.Location = new System.Drawing.Point(197, 212);
            this.cathegoryProductIDComboBox.Name = "cathegoryProductIDComboBox";
            this.cathegoryProductIDComboBox.Size = new System.Drawing.Size(121, 23);
            this.cathegoryProductIDComboBox.TabIndex = 15;
            this.cathegoryProductIDComboBox.ValueMember = "IDCathegoryProduct";
            // 
            // cathegoryProductBindingSource
            // 
            this.cathegoryProductBindingSource.DataMember = "CathegoryProduct";
            this.cathegoryProductBindingSource.DataSource = this.sportDataSet;
            // 
            // currentSaleNumericUpDown
            // 
            this.currentSaleNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "CurrentSale", true));
            this.currentSaleNumericUpDown.Location = new System.Drawing.Point(197, 241);
            this.currentSaleNumericUpDown.Name = "currentSaleNumericUpDown";
            this.currentSaleNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.currentSaleNumericUpDown.TabIndex = 17;
            // 
            // amountInStockNumericUpDown
            // 
            this.amountInStockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "AmountInStock", true));
            this.amountInStockNumericUpDown.Location = new System.Drawing.Point(197, 270);
            this.amountInStockNumericUpDown.Name = "amountInStockNumericUpDown";
            this.amountInStockNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.amountInStockNumericUpDown.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(197, 299);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 23);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // orderProductBindingSource
            // 
            this.orderProductBindingSource.DataMember = "OrderProduct";
            this.orderProductBindingSource.DataSource = this.sportDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CathegoryProductTableAdapter = this.cathegoryProductTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickUpPointTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.StatusOrderTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = GreatBritain.SportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // cathegoryProductTableAdapter
            // 
            this.cathegoryProductTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // orderProductTableAdapter
            // 
            this.orderProductTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.sportDataSet;
            // 
            // fKOrderProductProductsBindingSource
            // 
            this.fKOrderProductProductsBindingSource.DataMember = "FK_OrderProduct_Products";
            this.fKOrderProductProductsBindingSource.DataSource = this.productsBindingSource;
            // 
            // CreateUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 562);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateUpdateProductForm";
            this.Text = "CreateUpdateProductForm";
            this.Load += new System.EventHandler(this.CreateUpdateProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxProbablySaleSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cathegoryProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSaleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInStockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderProductProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SportDataSet sportDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private SportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.TextBox unitOfMeasurementTextBox;
        private System.Windows.Forms.NumericUpDown maxProbablySaleSizeNumericUpDown;
        private System.Windows.Forms.ComboBox manufacturerIDComboBox;
        private System.Windows.Forms.ComboBox supplierIDComboBox;
        private System.Windows.Forms.ComboBox cathegoryProductIDComboBox;
        private System.Windows.Forms.NumericUpDown currentSaleNumericUpDown;
        private System.Windows.Forms.NumericUpDown amountInStockNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private SportDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private SportDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private SportDataSetTableAdapters.CathegoryProductTableAdapter cathegoryProductTableAdapter;
        private System.Windows.Forms.BindingSource cathegoryProductBindingSource;
        private System.Windows.Forms.Button saveAttentionBackground;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource orderProductBindingSource;
        private SportDataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private System.Windows.Forms.ComboBox imageComboBox;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.BindingSource fKOrderProductProductsBindingSource;
        private System.Windows.Forms.TextBox iDProductArticulNumberTextBox;
    }
}