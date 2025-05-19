using GreatBritain.Services;
using Sport.AppForms;
using Sport.Models;
using Sport.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatBritain.AppForms
{
    public partial class AuthorizationForm : ParentForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// PKGH
        /// ХУЙЙЙЙЙЙ
        /// 
        /// </summary>
        public static SportDb context = new SportDb();
        public static User CurrentUser { get; private set; }
        private void saveAttentionBackground_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            var user = context.User.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user != null)
            {
                CurrentUser = user;

                MessageBox.Show($"{user.FIO} " + ", Авторизация пройдена успешна! Вы вошли под: " + $"{user.Role.Role1}", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            UserExperienceManager.CustomizeControls(splitContainer1.Panel1.Controls);
            UserExperienceManager.CustomizeControls(splitContainer1.Panel2.Controls);
        }
    }
}
