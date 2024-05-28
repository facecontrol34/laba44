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
    public partial class Z : Form
    {
        public Z()
        {
            InitializeComponent();
        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glav1 glav1 = new Glav1();
            glav1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZaiavkiZ glav1 = new ZaiavkiZ();
            glav1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PodZaiavk glav1 = new PodZaiavk();
            glav1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtslegZaiv glav1 = new OtslegZaiv();
            glav1.Show();
        }
    }
}
