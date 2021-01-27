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
    public partial class UpdateWorkerOrMovie : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public UpdateWorkerOrMovie()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void UpdateWorkerOrMovie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Movie". При необходимости она может быть перемещена или удалена.
            //this.movieTableAdapter.Fill(this.dataSet1.Movie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Workers". При необходимости она может быть перемещена или удалена.
            //this.workersTableAdapter.Fill(this.dataSet1.Workers);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && lengthTextBox.Text != "" && budgetTextBox.Text != "")
            {
                if (Int32.Parse(lengthTextBox.Text) < 0)
                {
                    MessageBox.Show("Некорректная длина фильма!");
                }
                else if (Int32.Parse(budgetTextBox.Text) < 0)
                {
                    MessageBox.Show("Некорректный бюджет фильма!");
                }
                else {
                    try
                    {
                        this.movieTableAdapter.InsertMovie(titleTextBox.Text, releaseDateDateTimePicker.Value, rateTextBox.Text, Int32.Parse(lengthTextBox.Text), commentaryTextBox.Text, Int32.Parse(budgetTextBox.Text));
                        //this.movieTableAdapter.Fill(this.dataSet1.Movie);
                        MessageBox.Show("Фильм успешно добавлен!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sc.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные для добавления фильма!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "") {
                sc.Open();
                string worker = "";
                cmd.CommandText = $"SELECT Name FROM Workers WHERE Name = '{nameTextBox.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        worker = reader1["Name"].ToString();
                    }
                }
                if (worker != "")
                {
                    try
                    {
                        this.workersTableAdapter.UpdateWorker(nameTextBox.Text, positionTextBox.Text, birthdayDateTimePicker.Value, motherlandTextBox.Text, degreeTextBox.Text);
                        MessageBox.Show("Данные о работнике успешно обновлены!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //sc.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Работник не найден!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Введите корректные данные для изменения!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashboardWorker dashw = new DashboardWorker();
            this.Dispose();
            Close();
            dashw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && lengthTextBox.Text != "" && budgetTextBox.Text != "")
            {
                if (Int32.Parse(lengthTextBox.Text) < 0)
                {
                    MessageBox.Show("Некорректная длина фильма!");
                }
                else if (Int32.Parse(budgetTextBox.Text) < 0)
                {
                    MessageBox.Show("Некорректный бюджет фильма!");
                }
                else
                {
                    sc.Open();
                    string title = "";
                    cmd.CommandText = $"SELECT Title FROM Movie WHERE Title = '{titleTextBox.Text}'";
                    using (SqlDataReader reader1 = cmd.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            title = reader1["Title"].ToString();
                        }
                    }
                    if (title != "")
                    {
                        try
                        {
                            this.movieTableAdapter.UpdateMovie(titleTextBox.Text, releaseDateDateTimePicker.Value, rateTextBox.Text, Int32.Parse(lengthTextBox.Text), commentaryTextBox.Text, Int32.Parse(budgetTextBox.Text));
                            //this.movieTableAdapter.Fill(this.dataSet1.Movie);
                            MessageBox.Show("Данные о фильме успешно обновлены!");
                            sc.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sc.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Фильм не найден!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные для изменения!");
            }

        }
    }
}
