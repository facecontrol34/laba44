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

namespace БытСервис
{
    public partial class otchet1 : Form
    {
        public otchet1()
        {
            InitializeComponent();
        }

        private void otchet1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.a4DataSet.Requests);
            SqlConnection con = new SqlConnection("Data Source = DC\\WS2021; Initial Catalog =a4; Integrated Security = true");
            con.Open();
            SqlCommand com = new SqlCommand("Select * From Requests where (requestStatus) like '%" + label7.Text + "%'", con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource= dt;
            int i = dataGridView1.Rows.Count - 1;
            label1.Text = "Количество выполненных заявок"  + i.ToString();
        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            O m = new O();
            m.Show();
        }
    }
}
