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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace БытСервис
{
    public partial class NazMast : Form
    {
        public NazMast()
        {
            InitializeComponent();
        }

        private void NazMast_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.a4DataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.a4DataSet.Requests);

        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            M m = new M();
            m.Show();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //Код назначения мастера
            SqlConnection con = new SqlConnection("Data Source = DC\\WS2021; Initial Catalog =a4; Integrated Security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Requests set masterID=@q where requestID=@w", con);
            cmd.Parameters.AddWithValue("@q", comboBox2.Text);
            cmd.Parameters.AddWithValue("@w", label7.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Мастер назначен");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
