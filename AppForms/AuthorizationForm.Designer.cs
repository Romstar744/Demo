namespace GreatBritain.AppForms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveAttentionBackground = new System.Windows.Forms.Button();
            this.passwordLabelAttentionFont = new System.Windows.Forms.Label();
            this.loginLabelAttentionFont = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderProductTableAdapter = new GreatBritain.SportDataSetTableAdapters.OrderProductTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.supplierTableAdapter = new GreatBritain.SportDataSetTableAdapters.SupplierTableAdapter();
            this.manufacturerTableAdapter = new GreatBritain.SportDataSetTableAdapters.ManufacturerTableAdapter();
            this.cathegoryProductTableAdapter = new GreatBritain.SportDataSetTableAdapters.CathegoryProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.saveAttentionBackground);
            this.splitContainer1.Panel2.Controls.Add(this.passwordLabelAttentionFont);
            this.splitContainer1.Panel2.Controls.Add(this.loginLabelAttentionFont);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(258, 502);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(114, 23);
            this.titleLabelAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(77, 16);
            this.titleLabelAttentionFont.TabIndex = 4;
            this.titleLabelAttentionFont.Text = "Авторизация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // saveAttentionBackground
            // 
            this.saveAttentionBackground.Location = new System.Drawing.Point(56, 200);
            this.saveAttentionBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveAttentionBackground.Name = "saveAttentionBackground";
            this.saveAttentionBackground.Size = new System.Drawing.Size(135, 52);
            this.saveAttentionBackground.TabIndex = 4;
            this.saveAttentionBackground.Text = "Войти";
            this.saveAttentionBackground.UseVisualStyleBackColor = true;
            this.saveAttentionBackground.Click += new System.EventHandler(this.saveAttentionBackground_Click);
            // 
            // passwordLabelAttentionFont
            // 
            this.passwordLabelAttentionFont.AutoSize = true;
            this.passwordLabelAttentionFont.Location = new System.Drawing.Point(91, 117);
            this.passwordLabelAttentionFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabelAttentionFont.Name = "passwordLabelAttentionFont";
            this.passwordLabelAttentionFont.Size = new System.Drawing.Size(51, 15);
            this.passwordLabelAttentionFont.TabIndex = 3;
            this.passwordLabelAttentionFont.Text = "Пароль:";
            // 
            // loginLabelAttentionFont
            // 
            this.loginLabelAttentionFont.AutoSize = true;
            this.loginLabelAttentionFont.Location = new System.Drawing.Point(99, 21);
            this.loginLabelAttentionFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabelAttentionFont.Name = "loginLabelAttentionFont";
            this.loginLabelAttentionFont.Size = new System.Drawing.Size(43, 15);
            this.loginLabelAttentionFont.TabIndex = 2;
            this.loginLabelAttentionFont.Text = "Логин:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 0;
            // 
            // orderProductTableAdapter
            // 
            this.orderProductTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // cathegoryProductTableAdapter
            // 
            this.cathegoryProductTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 502);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private SportDataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private SportDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private SportDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private SportDataSetTableAdapters.CathegoryProductTableAdapter cathegoryProductTableAdapter;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passwordLabelAttentionFont;
        private System.Windows.Forms.Label loginLabelAttentionFont;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveAttentionBackground;
    }
}