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
    public partial class PodZaiavk : Form
    {
        public PodZaiavk()
        {
            InitializeComponent();
        }

        private void osnrab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PodZaiavk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "a4DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.a4DataSet.Users);

        }

        private void naz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Z m = new Z();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Код добавления заявки
            SqlConnection con = new SqlConnection("Data Source = DC\\WS2021; Initial Catalog =a4; Integrated Security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Requests (startDate, homeTechType, homeTechModel, problemDescryption, requestStatus, clientID) Values (@q, @w, @e, @r, @t, @y)", con);
            cmd.Parameters.AddWithValue("@q", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@w", comboBox2.Text);
            cmd.Parameters.AddWithValue("@e", textBox2.Text);
            cmd.Parameters.AddWithValue("@r", textBox3.Text);
            cmd.Parameters.AddWithValue("@t", label7.Text);
            cmd.Parameters.AddWithValue("@y", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Добавлено");

        }
    }
}
