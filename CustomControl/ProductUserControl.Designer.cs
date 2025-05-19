namespace Sport.CustomControl
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cost = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.Label();
            this.descriptionProduct = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sale = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cost);
            this.panel1.Controls.Add(this.manufacturer);
            this.panel1.Controls.Add(this.descriptionProduct);
            this.panel1.Controls.Add(this.productName);
            this.panel1.Location = new System.Drawing.Point(242, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(12, 74);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(36, 13);
            this.cost.TabIndex = 3;
            this.cost.Text = "Цена:";
            this.cost.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSize = true;
            this.manufacturer.Location = new System.Drawing.Point(12, 51);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(89, 13);
            this.manufacturer.TabIndex = 2;
            this.manufacturer.Text = "Производитель:";
            this.manufacturer.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // descriptionProduct
            // 
            this.descriptionProduct.AutoSize = true;
            this.descriptionProduct.Location = new System.Drawing.Point(12, 28);
            this.descriptionProduct.Name = "descriptionProduct";
            this.descriptionProduct.Size = new System.Drawing.Size(95, 13);
            this.descriptionProduct.TabIndex = 1;
            this.descriptionProduct.Text = "Описание товара";
            this.descriptionProduct.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(12, 6);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(121, 13);
            this.productName.TabIndex = 0;
            this.productName.Text = "Наименование товара";
            this.productName.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sale);
            this.panel2.Location = new System.Drawing.Point(595, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 93);
            this.panel2.TabIndex = 2;
            // 
            // sale
            // 
            this.sale.AutoSize = true;
            this.sale.Location = new System.Drawing.Point(23, 32);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(46, 26);
            this.sale.TabIndex = 4;
            this.sale.Text = "Размер\r\nскидки\r\n";
            this.sale.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(12, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GreatBritain.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(56, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ProductUserControl_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "ProductUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(738, 139);
            this.Load += new System.EventHandler(this.ProductUserControl_Load);
            this.Click += new System.EventHandler(this.ProductUserControl_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductUserControl_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label manufacturer;
        private System.Windows.Forms.Label descriptionProduct;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sale;
        private System.Windows.Forms.Panel panel3;
    }
}
