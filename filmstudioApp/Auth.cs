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

namespace filmstudioApp
{
    public partial class Auth : Form
    {
        //public string idauth;
       // public int id = -1;
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        //String globalConstForList;
        public Auth()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc.Open();
            string role = comboBox1.Text;
            if (role == "Актер")
            {
                cmd.CommandText = $"SELECT IdAuth FROM authentification WHERE(dbo.authentification.login  = '{textBox1.Text}' AND dbo.authentification.password = HASHBYTES('SHA2_256', '{textBox2.Text}') AND EXISTS(SELECT * from Actors, authentification WHERE Actors.authId = authentification.IdAuth AND authentification.login = '{textBox1.Text}'))";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Program.Idauth = reader["IdAuth"].ToString();
                        Program.Id = Int32.Parse(Program.Idauth);
                    }
                }
                if (Program.Idauth != "")
                {
                    Actor ac = new Actor();
                    ac.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данные пользователя не найдены!");
                }
            }
            else if (role == "Работник")
            {
                cmd.CommandText = $"SELECT IdAuth FROM authentification WHERE(dbo.authentification.login  = '{textBox1.Text}' AND dbo.authentification.password = HASHBYTES('SHA2_256', '{textBox2.Text}') AND EXISTS(SELECT * from Workers, authentification WHERE Workers.authId = authentification.IdAuth AND authentification.login = '{textBox1.Text}'))";
                string returnData = "";
                returnData = cmd.CommandText;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Program.Idauth = reader["IdAuth"].ToString();
                        Program.Id = Int32.Parse(Program.Idauth);
                    }
                }
                if (Program.Idauth != "")
                {
                    Worker wr = new Worker();
                    wr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данные пользователя не найдены!");
                }

            }
            else if (role == "Администратор")
            {
                cmd.CommandText = $"SELECT IdAuth FROM authentification WHERE(dbo.authentification.login  = '{textBox1.Text}' AND dbo.authentification.password = HASHBYTES('SHA2_256', '{textBox2.Text}') AND EXISTS(SELECT * from Admin, authentification WHERE Admin.authId = authentification.IdAuth AND authentification.login = '{textBox1.Text}'))";
                //string returnData = "";
                //returnData = cmd.CommandText;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Program.Idauth = reader["IdAuth"].ToString();
                        Program.Id = Int32.Parse(Program.Idauth);
                    }
                }
                if (Program.Idauth != "")
                {
                    Admin adm = new Admin();
                    adm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данные пользователя не найдены!");
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные для входа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sc.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
