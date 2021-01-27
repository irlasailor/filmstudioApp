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
    public partial class Admin : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        public Admin()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            this.Dispose();
            Close();
            auth.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string fio = textBox1.Text;
                this.adminTableAdapter.FillByName(this.dataSet1.Admin, fio);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                string filmtitle = textBox9.Text;
                this.movieTableAdapter.FillByFilm(this.dataSet1.Movie, filmtitle);
                this.studiosTableAdapter.FillLocByFilm(this.dataSet1.Studios, filmtitle);
                this.testtTableAdapter.FillSPByFilm(this.dataSet1.testt, filmtitle);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное название фильма", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == null && textBox5.Text == null)
            {
                MessageBox.Show("Введите данные для изменения");
            }
            else
            {
                try
                {
                    sc.Open();
                    string currentId = "";
                    //int currentIdNum = -1;
                    cmd.CommandText = $"SELECT IdAuth FROM authentification WHERE(dbo.authentification.login  = '{textBox2.Text}' AND dbo.authentification.password = HASHBYTES('SHA2_256', '{textBox3.Text}') AND EXISTS(SELECT * from Admin, authentification WHERE Admin.authId = authentification.IdAuth AND authentification.login = '{textBox2.Text}'))";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentId = reader["IdAuth"].ToString();
                        }
                    }
                    if (Program.Idauth == currentId)
                    {
                        if (textBox8.Text == textBox5.Text)
                        {
                            this.authentificationTableAdapter.User_Change2(Program.Id, textBox4.Text, textBox5.Text);
                            this.tableAdapterManager.UpdateAll(this.dataSet1);
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox8.Clear();
                            MessageBox.Show("Данные успешно обновлены!");
                        }
                        else
                        {
                            MessageBox.Show("Подтвердите пароль!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректные данные для входа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    sc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sc.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox6.Text == "") && (textBox7.Text == ""))
            {
                MessageBox.Show("Введите данные для изменения");
            }
            else
            {
                sc.Open();
                string currentId = "";
                //int currentIdNum = -1;
                cmd.CommandText = $"SELECT IdAuth FROM authentification WHERE(dbo.authentification.login  = '{textBox2.Text}' AND dbo.authentification.password = HASHBYTES('SHA2_256', '{textBox3.Text}') AND EXISTS(SELECT * from Admin, authentification WHERE Admin.authId = authentification.IdAuth AND authentification.login = '{textBox2.Text}'))";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        currentId = reader["IdAuth"].ToString();
                    }
                }
                if (Program.Idauth == currentId)
                {
                    this.authentificationTableAdapter.User_Change1(Program.Id, textBox6.Text, textBox7.Text);
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    MessageBox.Show("Данные успешно обновлены!");
                }
                else
                {
                    MessageBox.Show("Некорректные данные для входа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                sc.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashad = new DashboardAdmin();
            this.Dispose();
            Close();
            dashad.Show();
        }
    }
}
