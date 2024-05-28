using System;
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
    public partial class Mast : Form
    {
        public Mast()
        {
            InitializeComponent();
        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav1 glav1 = new Glav1();
            glav1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZaiavkiM m = new ZaiavkiM();
            m.Show();
        }
    }
}
