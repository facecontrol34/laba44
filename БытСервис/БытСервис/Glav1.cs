using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace БытСервис
{
    public partial class Glav1 : Form
    {
        public Glav1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Код авторизации
            SqlConnection con = new SqlConnection("Data Source = DC\\WS2021; Initial Catalog =a4; Integrated Security = true");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Users where login= '"+textBox1.Text+"' and password= '"+textBox2.Text+"' and type = '"+comboBox1.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (comboBox1.Text == "Менеджер")
            {
                if (dt.Rows.Count == 1) 
                { 
                    this.Hide();
                    M m = new M();
                    m.Show();
                    MessageBox.Show("Вы успешно авторизовались");
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не верно");
                }
            }
            if (comboBox1.Text == "Мастер")
            {
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Mast m = new Mast();
                    m.Show();
                    MessageBox.Show("Вы успешно авторизовались");
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не верно");
                }
            }
            if (comboBox1.Text == "Оператор")
            {
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    O m = new O();
                    m.Show();
                    MessageBox.Show("Вы успешно авторизовались");
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не верно");
                }
            }
            if (comboBox1.Text == "Заказчик")
            {
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Z m = new Z();
                    m.Show();
                    MessageBox.Show("Вы успешно авторизовались");
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не верно");
                }
            }
        }
    }
}
