﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalShop.Controllers;
using MetroFramework.Forms;

namespace GlobalShop
{
    public partial class Log : MetroForm
    {
         private string email;
        public Log(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void continua_Click(object sender, EventArgs e)
        {
            if (LoginController.CheckPass(email, parola.Text))
            {
                Magazin magazin = new Magazin();
            }

        }

        private void Log_Load(object sender, EventArgs e)
        {

        }
    }
}
