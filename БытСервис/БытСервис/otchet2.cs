﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БытСервис
{
    public partial class otchet2 : Form
    {
        public otchet2()
        {
            InitializeComponent();
        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            O m = new O();
            m.Show();
        }
    }
}
