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
    public partial class ZaiavkiM : Form
    {
        public ZaiavkiM()
        {
            InitializeComponent();
        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mast m = new Mast();
            m.Show();
        }

        private void ZaiavkiM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.a4DataSet.Requests);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //Код редактирования заявки
            SqlConnection con = new SqlConnection("Data Source = DC\\WS2021; Initial Catalog =a4; Integrated Security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Requests set requestStatus=@q where requestID=@w", con);
            cmd.Parameters.AddWithValue("@q", comboBox2.Text);
            cmd.Parameters.AddWithValue("@w", label7.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Изменено");
        }

        private void osnrab_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
