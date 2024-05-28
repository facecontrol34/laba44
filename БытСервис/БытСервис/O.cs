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
    public partial class O : Form
    {
        public O()
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
            otchet1 glav1 = new otchet1();
            glav1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            otchet2 glav1 = new otchet2();
            glav1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            otchet3 glav1 = new otchet3();
            glav1.Show();
        }
    }
}
