﻿using Sport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport.AppForms
{
    public partial class ParentForm: Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            //this.BackColor = ColorTranslator.FromHtml(SportDataSet.Constants.Color.mainBackgroundColor);
        }
    }
}
