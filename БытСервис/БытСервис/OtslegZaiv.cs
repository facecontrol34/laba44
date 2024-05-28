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
    public partial class OtslegZaiv : Form
    {
        public OtslegZaiv()
        {
            InitializeComponent();
        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Z m = new Z();
            m.Show();
        }

        private void OtslegZaiv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.a4DataSet.Requests);

        }
    }
}
