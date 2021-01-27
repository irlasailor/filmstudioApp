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
using System.IO;
using System.Security.Cryptography;

namespace filmstudioApp
{
    public partial class DataPanel : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public DataPanel()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox1.Text != "")
            {

                string s1 = "";
                string s2 = "";
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

                using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
                {
                    while (s1.Length != 14)
                    {
                        byte[] oneByte = new byte[1];
                        provider.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s1 += character;
                        }
                    }
                }
                using (RNGCryptoServiceProvider provider1 = new RNGCryptoServiceProvider())
                {
                    while (s2.Length != 19)
                    {
                        byte[] oneByte = new byte[1];
                        provider1.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s2 += character;
                        }
                    }
                }

                this.workersTableAdapter.AddWorker(s1, s2, nameTextBox1.Text, positionTextBox1.Text, birthdayDateTimePicker1.Value, motherlandTextBox1.Text, degreeTextBox1.Text);
                this.workersTableAdapter.Fill(this.dataSet1.Workers);
                MessageBox.Show("Работник успешно добавлен! Передайте работнику логин и пароль для последующего изменения" + "\n\n" + "Логин: " + s1 + '\n' + "Пароль: " + s2);
            }
            else
            {
                MessageBox.Show("Заполните поля для добавления работника!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashboardAdmin dasha = new DashboardAdmin();
            this.Dispose();
            Close();
            dasha.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nameTextBox1.Text != "" && textBox3.Text != "")
            {
                try
                {
                    this.workersTableAdapter.UpdateWorkerAdmin(nameTextBox1.Text, positionTextBox1.Text, birthdayDateTimePicker1.Value, motherlandTextBox1.Text, degreeTextBox1.Text, Int32.Parse(textBox3.Text));
                    this.workersTableAdapter.Fill(this.dataSet1.Workers);
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
                MessageBox.Show("Заполните поля для изменения данных работника!");
            }
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void DataPanel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Movies_Props". При необходимости она может быть перемещена или удалена.
            this.movies_PropsTableAdapter.Fill(this.dataSet1.Movies_Props);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.testt". При необходимости она может быть перемещена или удалена.
            this.testtTableAdapter.Fill(this.dataSet1.testt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Props". При необходимости она может быть перемещена или удалена.
            this.propsTableAdapter.Fill(this.dataSet1.Props);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Storages_Movies". При необходимости она может быть перемещена или удалена.
            this.storages_MoviesTableAdapter.Fill(this.dataSet1.Storages_Movies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Storages_Props". При необходимости она может быть перемещена или удалена.
            //this.storages_PropsTableAdapter.Fill(this.dataSet1.Storages_Props);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Storages". При необходимости она может быть перемещена или удалена.
            this.storagesTableAdapter.Fill(this.dataSet1.Storages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Studios_Movies". При необходимости она может быть перемещена или удалена.
            this.studios_MoviesTableAdapter.Fill(this.dataSet1.Studios_Movies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Studios". При необходимости она может быть перемещена или удалена.
            this.studiosTableAdapter.Fill(this.dataSet1.Studios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Movie". При необходимости она может быть перемещена или удалена.
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Actors_Movies". При необходимости она может быть перемещена или удалена.
            this.actors_MoviesTableAdapter.Fill(this.dataSet1.Actors_Movies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.dataSet1.Actors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Workers_Movies". При необходимости она может быть перемещена или удалена.
            //this.workers_MoviesTableAdapter.Fill(this.dataSet1.Workers_Movies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dataSet1.Workers);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                sc.Open();
                string id = "";
                string worker = "";
                string movie = "";

                cmd.CommandText = $"SELECT WorkerId FROM Workers WHERE Workers.Name = '{textBox1.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        worker = reader1["WorkerId"].ToString();
                    }
                }
                cmd.CommandText = $"SELECT MovieId FROM Movie WHERE Movie.Title = '{textBox2.Text}'";
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        movie = reader2["MovieId"].ToString();
                    }
                }

                if (worker != "" && movie != "")
                {

                    cmd.CommandText = $"SELECT relationId FROM Workers_Movies, Workers, Movie WHERE Workers.WorkerId = Workers_Movies.Worker AND Movie.MovieId = Workers_Movies.Movie AND Workers.Name = '{textBox1.Text}' AND Movie.Title = '{textBox2.Text}'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader["relationId"].ToString();
                        }
                    }
                    if (id != "")
                    {
                        MessageBox.Show("Данный работник уже назначен на этот фильм!");
                    }
                    else
                    {
                        this.workers_MoviesTableAdapter.SetWorkerToMovie(textBox1.Text, textBox2.Text);
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show("Работник успешно назначен на фильм");
                    }
                }
                else
                {
                    MessageBox.Show("Данные работник или фильм не найдены!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для назначения работника на фильм!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                sc.Open();
                string id = "";
                //int ID = -1;
                cmd.CommandText = $"SELECT relationId FROM Workers_Movies, Workers, Movie WHERE Workers.WorkerId = Workers_Movies.Worker AND Movie.MovieId = Workers_Movies.Movie AND Workers.Name = '{textBox1.Text}' AND Movie.Title = '{textBox2.Text}'";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader["relationId"].ToString();
                    }
                }
                if (id == "")
                {
                    MessageBox.Show("Данный работник не назначен на этот фильм!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы точно хотите снять работника с фильма?", "Подтвердите снятие с фильма", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.workers_MoviesTableAdapter.DeleteWorkerFromFilm(textBox1.Text, textBox2.Text);
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show("Работник успешно снят с фильма");
                    }
                    else if (result == DialogResult.No)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для снятия работника с фильма!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить работника?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (textBox3.Text != "")
                {
                    this.workersTableAdapter.DeleteWorker(Int32.Parse(textBox3.Text));
                    this.workersTableAdapter.Fill(this.dataSet1.Workers);
                    MessageBox.Show("Работник успешно удален!");
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Введите Id работника!");
                }
            }
            else if (result == DialogResult.No)
            {
                textBox3.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (nameTextBox1.Text != "")
            {
              
                string s1 = "";
                string s2 = "";
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

                using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
                {
                    while (s1.Length != 14)
                    {
                        byte[] oneByte = new byte[1];
                        provider.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s1 += character;
                        }
                    }
                }
                using (RNGCryptoServiceProvider provider1 = new RNGCryptoServiceProvider())
                {
                    while (s2.Length != 19)
                    {
                        byte[] oneByte = new byte[1];
                        provider1.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s2 += character;
                        }
                    }
                }

                this.workersTableAdapter.AddWorker(s1, s2, nameTextBox1.Text, positionTextBox1.Text, birthdayDateTimePicker1.Value, motherlandTextBox1.Text, degreeTextBox1.Text);
                this.workersTableAdapter.Fill(this.dataSet1.Workers);
                MessageBox.Show("Работник успешно добавлен! Передайте работнику логин и пароль для последующего изменения" + "\n\n" + "Логин: " + s1 + '\n' + "Пароль: " + s2);
            }
            else
            {
                MessageBox.Show("Заполните поля для добавления работника!");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DashboardAdmin dasha = new DashboardAdmin();
            this.Dispose();
            Close();
            dasha.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (nameTextBox1.Text != "")
            {

                string s1 = "";
                string s2 = "";
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

                using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
                {
                    while (s1.Length != 14)
                    {
                        byte[] oneByte = new byte[1];
                        provider.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s1 += character;
                        }
                    }
                }
                using (RNGCryptoServiceProvider provider1 = new RNGCryptoServiceProvider())
                {
                    while (s2.Length != 19)
                    {
                        byte[] oneByte = new byte[1];
                        provider1.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s2 += character;
                        }
                    }
                }

                try
                {
                    this.workersTableAdapter.AddWorker(s1, s2, nameTextBox1.Text, positionTextBox1.Text, birthdayDateTimePicker1.Value, motherlandTextBox1.Text, degreeTextBox1.Text);
                    this.workersTableAdapter.Fill(this.dataSet1.Workers);
                    MessageBox.Show("Работник успешно добавлен! Передайте работнику логин и пароль для последующего изменения" + "\n\n" + "Логин: " + s1 + '\n' + "Пароль: " + s2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поля для добавления работника!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {

                string s1 = "";
                string s2 = "";
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

                using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
                {
                    while (s1.Length != 14)
                    {
                        byte[] oneByte = new byte[1];
                        provider.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s1 += character;
                        }
                    }
                }
                using (RNGCryptoServiceProvider provider1 = new RNGCryptoServiceProvider())
                {
                    while (s2.Length != 19)
                    {
                        byte[] oneByte = new byte[1];
                        provider1.GetBytes(oneByte);
                        char character = (char)oneByte[0];
                        if (valid.Contains(character))
                        {
                            s2 += character;
                        }
                    }
                }
                try
                {
                    this.actorsTableAdapter.AddActor(s1, s2, nameTextBox.Text, birthdayDateTimePicker.Value, motherlandTextBox.Text, degreeTextBox.Text, activityTextBox.Text);
                    this.actorsTableAdapter.Fill(this.dataSet1.Actors);
                    MessageBox.Show("Актер успешно добавлен! Передайте актеру логин и пароль для последующего изменения" + "\n\n" + "Логин: " + s1 + '\n' + "Пароль: " + s2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поля для добавления актера!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && textBox4.Text != "")
            {
                try
                {
                this.actorsTableAdapter.UpdateActorAdmin(nameTextBox.Text, birthdayDateTimePicker.Value, motherlandTextBox.Text, degreeTextBox.Text, activityTextBox.Text, Int32.Parse(textBox4.Text));
                this.actorsTableAdapter.Fill(this.dataSet1.Actors);
                MessageBox.Show("Данные об актере успешно обновлены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поля для изменения данных актера!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить актера?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (textBox4.Text != "")
                {
                    this.actorsTableAdapter.DeleteActor(Int32.Parse(textBox4.Text));
                    this.actorsTableAdapter.Fill(this.dataSet1.Actors);
                    MessageBox.Show("Актер успешно удален!");
                    textBox4.Clear();
                }
                else
                {
                    MessageBox.Show("Введите Id актера!");
                }
            }
            else if (result == DialogResult.No)
            {
                textBox4.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "" && textBox5.Text != "")
            {
                sc.Open();
                string id = "";
                string actor = "";
                string movie = "";

                cmd.CommandText = $"SELECT ActorId FROM Actors WHERE Actors.Name = '{textBox6.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        actor = reader1["ActorId"].ToString();
                    }
                }
                cmd.CommandText = $"SELECT MovieId FROM Movie WHERE Movie.Title = '{textBox5.Text}'";
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        movie = reader2["MovieId"].ToString();
                    }
                }

                if (actor != "" && movie != "")
                {
                    cmd.CommandText = $"SELECT relationId FROM Actors_Movies, Actors, Movie WHERE Actors.ActorId = Actors_Movies.Actor AND Movie.MovieId = Actors_Movies.Movie AND Actors.Name = '{textBox6.Text}' AND Movie.Title = '{textBox5.Text}'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader["relationId"].ToString();
                        }
                    }
                    //MessageBox.Show(id);
                    if (id != "")
                    {
                        MessageBox.Show("Данный актер уже назначен на этот фильм!");
                    }
                    else
                    {
                        this.actors_MoviesTableAdapter.SetActorToMovie(textBox6.Text, textBox5.Text);
                        textBox6.Clear();
                        textBox5.Clear();
                        MessageBox.Show("Актер успешно назначен на фильм");
                    }
                }
                else
                {
                    MessageBox.Show("Данные актер или фильм не найдены!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для назначения актера на фильм!");
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "" && textBox5.Text != "")
            {
                sc.Open();
                string idact = "";
                //int ID = -1;
                cmd.CommandText = $"SELECT relationId FROM Actors_Movies, Actors, Movie WHERE Actors.ActorId = Actors_Movies.Actor AND Movie.MovieId = Actors_Movies.Movie AND Actors.Name = '{textBox6.Text}' AND Movie.Title = '{textBox5.Text}'";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idact = reader["relationId"].ToString();
                    }
                }
                if (idact == "")
                {
                    MessageBox.Show("Данный актер не назначен на этот фильм!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы точно хотите снять актера с фильма?", "Подтвердите снятие с фильма", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.actors_MoviesTableAdapter.DeleteActorFromMovie(Int32.Parse(idact));
                        textBox6.Clear();
                        textBox5.Clear();
                        MessageBox.Show("Актер успешно снят с фильма");
                    }
                    else if (result == DialogResult.No)
                    {
                        textBox6.Clear();
                        textBox5.Clear();
                    }
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для снятия актера с фильма!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && lengthTextBox.Text != "" && budgetTextBox.Text != "")
            {
                if (Int32.Parse(lengthTextBox.Text) < 0)
                {
                    MessageBox.Show("Некорректная длина фильма!");
                } else if (Int32.Parse(budgetTextBox.Text) < 0)
                {
                    MessageBox.Show("Некорректный бюджет фильма!");
                }
                else {
                    try
                    {
                        this.movieTableAdapter.InsertMovie(titleTextBox.Text, releaseDateDateTimePicker.Value, rateTextBox.Text, Int32.Parse(lengthTextBox.Text), commentaryTextBox.Text, Int32.Parse(budgetTextBox.Text));
                        this.movieTableAdapter.Fill(this.dataSet1.Movie);
                        MessageBox.Show("Фильм успешно добавлен!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //sc.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные для добавления фильма!");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && lengthTextBox.Text != "" && budgetTextBox.Text != "" && textBox15.Text != "")
            {
                sc.Open();
                string mid = "";
                cmd.CommandText = $"SELECT MovieId FROM Movie WHERE MovieId = '{textBox15.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        mid = reader1["MovieId"].ToString();
                    }
                }
                if (mid != "")
                {
                    try
                    {
                        this.movieTableAdapter.UpdateMovieAdmin(titleTextBox.Text, releaseDateDateTimePicker.Value, rateTextBox.Text, Int32.Parse(lengthTextBox.Text), commentaryTextBox.Text, Int32.Parse(budgetTextBox.Text), Int32.Parse(textBox15.Text));
                        this.movieTableAdapter.Fill(this.dataSet1.Movie);
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
            else
            {
                MessageBox.Show("Введите корректные данные для изменения!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //if (textBox7.Text != "")
            //{
            //    sc.Open();
            //    string id = "";
                
            //    cmd.CommandText = $"SELECT MovieId FROM Movie WHERE Movie.MovieId = '{textBox7.Text}'";
            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            id = reader["MovieId"].ToString();
            //        }
            //    }
            //    if (id == "")
            //    {
            //        MessageBox.Show("Фильм не найден!");
            //    }
            //    else
            //    {
            //        DialogResult result = MessageBox.Show("Вы точно хотите удалить фильм?", "Подтвердите удаление фильма", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (result == DialogResult.Yes)
            //        {
            //            this.movieTableAdapter.DeleteMovie(Int32.Parse(id));
            //            textBox7.Clear();
            //            this.movieTableAdapter.Fill(this.dataSet1.Movie);
            //            MessageBox.Show("Фильм успешно удален");
            //        }
            //        else if (result == DialogResult.No)
            //        {
            //            textBox7.Clear();
            //        }
            //    }
            //    sc.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Заполните поле MovieId для удаления фильма!");
            //}
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DashboardAdmin dasha = new DashboardAdmin();
            this.Dispose();
            Close();
            dasha.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            //this.movieBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet1);
            //this.movieTableAdapter.Fill(this.dataSet1.Movie);
            //MessageBox.Show("Фильм успешно добавлен!");

        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            DashboardAdmin dasha = new DashboardAdmin();
            this.Dispose();
            Close();
            dasha.Show();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (locationTextBox.Text != "")
            {
                try
                {
                    this.studiosTableAdapter.InsertStudio(locationTextBox.Text);
                    this.studiosTableAdapter.Fill(this.dataSet1.Studios);
                    locationTextBox.Clear();
                    MessageBox.Show("Съемочный павильон успешно добавлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные для добавления павильона!");
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (locationTextBox.Text != "" && textBox7.Text != "")
            {
                sc.Open();
                string loc = "";
                cmd.CommandText = $"SELECT Location FROM Studios WHERE Location = '{locationTextBox.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        loc = reader1["Location"].ToString();
                    }
                }
                if (loc != "")
                {
                    try
                    {
                        this.studiosTableAdapter.UpdateStudio(textBox7.Text, locationTextBox.Text);
                        this.studiosTableAdapter.Fill(this.dataSet1.Studios);
                        locationTextBox.Clear();
                        textBox7.Clear();
                        MessageBox.Show("Данные о павильоне успешно изменены!");
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
                    MessageBox.Show("Съемочный павильон не найден!");
                }               
            }
            else
            {
                MessageBox.Show("Введите корректные данные для изменения данных!");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить павильон?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (textBox8.Text != "")
                {
                    this.studiosTableAdapter.DeleteStudio(Int32.Parse(textBox8.Text));
                    this.studiosTableAdapter.Fill(this.dataSet1.Studios);
                    MessageBox.Show("Павильон успешно удален!");
                    textBox8.Clear();
                }
                else
                {
                    MessageBox.Show("Введите Id павильона!");
                }
            }
            else if (result == DialogResult.No)
            {
                textBox8.Clear();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "")
            {
                sc.Open();
                string id = "";
                string loc = "";
                string movie = "";

                cmd.CommandText = $"SELECT StudioId FROM Studios WHERE StudioId = '{textBox9.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        loc = reader1["StudioId"].ToString();
                    }
                }
                cmd.CommandText = $"SELECT MovieId FROM Movie WHERE Movie.Title = '{textBox10.Text}'";
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        movie = reader2["MovieId"].ToString();
                    }
                }

                if (loc != "" && movie != "")
                {
                    cmd.CommandText = $"SELECT relationId FROM Studios_Movies, Studios, Movie WHERE Studios.StudioId = Studios_Movies.Studio AND Movie.MovieId = Studios_Movies.Movie AND Studios.StudioId = '{textBox9.Text}' AND Movie.Title = '{textBox10.Text}'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader["relationId"].ToString();
                        }
                    }
                    //MessageBox.Show(id);
                    if (id != "")
                    {
                        MessageBox.Show("Данный павильон уже привязан к этому фильму!");
                    }
                    else
                    {
                        this.studios_MoviesTableAdapter.SetStudioToMovie(Int32.Parse(textBox9.Text), textBox10.Text);
                        textBox9.Clear();
                        textBox10.Clear();
                        MessageBox.Show("Павильон успешно привязан к фильму");
                    }
                }
                else
                {
                    MessageBox.Show("Данные павильон или фильм не найдены!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для привязки павильона к фильму!");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "")
            {
                sc.Open();
                string idstd = "";
                //int ID = -1;
                cmd.CommandText = $"SELECT relationId FROM Studios_Movies, Studios, Movie WHERE Studios.StudioId = Studios_Movies.Studio AND Movie.MovieId = Studios_Movies.Movie AND Studios.StudioId = '{textBox9.Text}' AND Movie.Title = '{textBox10.Text}'";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idstd = reader["relationId"].ToString();
                    }
                }
                if (idstd == "")
                {
                    MessageBox.Show("Данный павильон не привязан к этому фильму!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы точно хотите снять павильон с фильма?", "Подтвердите снятие с фильма", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.studios_MoviesTableAdapter.DeleteStudioFromMovie(Int32.Parse(idstd));
                        textBox9.Clear();
                        textBox10.Clear();
                        MessageBox.Show("Павильон успешно снят с фильма");
                    }
                    else if (result == DialogResult.No)
                    {
                        textBox9.Clear();
                        textBox10.Clear();
                    }
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для снятия павильона с фильма!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void storageIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void storageIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox18.Text != "" && textBox17.Text != "")
            {
                sc.Open();
                string id = "";
                string loc = "";
                string movie = "";

                cmd.CommandText = $"SELECT StorageId FROM Storages WHERE StorageId = '{textBox18.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        loc = reader1["StorageId"].ToString();
                    }
                }
                cmd.CommandText = $"SELECT MovieId FROM Movie WHERE Movie.Title = '{textBox17.Text}'";
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        movie = reader2["MovieId"].ToString();
                    }
                }

                if (loc != "" && movie != "")
                {
                    cmd.CommandText = $"SELECT relationId FROM Storages_Movies, Storages, Movie WHERE Storages.StorageId = Storages_Movies.Storage AND Movie.MovieId = Storages_Movies.Movie AND Storages.StorageId = '{textBox18.Text}' AND Movie.Title = '{textBox17.Text}'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader["relationId"].ToString();
                        }
                    }
                    //MessageBox.Show(id);
                    if (id != "")
                    {
                        MessageBox.Show("Данный склад уже привязан к этому фильму!");
                    }
                    else
                    {
                        this.storages_MoviesTableAdapter.SetStorageToMovie(Int32.Parse(textBox18.Text), textBox17.Text);
                        textBox18.Clear();
                        textBox17.Clear();
                        MessageBox.Show("Склад успешно привязан к фильму");
                    }
                }
                else
                {
                    MessageBox.Show("Данные склад или фильм не найдены!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для привязки склада к фильму!");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox18.Text != "" && textBox17.Text != "")
            {
                sc.Open();
                string idst = "";
                //int ID = -1;
                cmd.CommandText = $"SELECT relationId FROM Storages_Movies, Storages, Movie WHERE Storages.StorageId = Storages_Movies.Storage AND Movie.MovieId = Storages_Movies.Movie AND Storages.StorageId = '{textBox18.Text}' AND Movie.Title = '{textBox17.Text}'";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idst = reader["relationId"].ToString();
                    }
                }
                if (idst == "")
                {
                    MessageBox.Show("Данный склад не привязан к этому фильму!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы точно хотите снять склад с фильма?", "Подтвердите снятие с фильма", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.storages_MoviesTableAdapter.DeleteStorageFromMovie(Int32.Parse(idst));
                        textBox18.Clear();
                        textBox17.Clear();
                        MessageBox.Show("Склад успешно снят с фильма");
                    }
                    else if (result == DialogResult.No)
                    {
                        textBox18.Clear();
                        textBox17.Clear();
                    }
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для снятия склада с фильма!");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (locationTextBox1.Text != "")
            {
                try
                {
                    this.storagesTableAdapter.InsertStorage(locationTextBox1.Text);
                    this.storagesTableAdapter.Fill(this.dataSet1.Storages);
                    locationTextBox1.Clear();
                    MessageBox.Show("Склад успешно добавлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные для добавления склада!");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text != "" && textBox21.Text != "")
            {
                sc.Open();
                string sid = "";
                string n = "";

                cmd.CommandText = $"SELECT StorageId FROM Storages WHERE StorageId = '{textBox21.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        sid = reader1["StorageId"].ToString();
                    }
                }
               
                if (sid != "") {
                    this.propsTableAdapter.AddProp(descriptionTextBox.Text, Int32.Parse(textBox21.Text));
                    cmd.CommandText = $"SELECT DISTINCT number FROM Storages_Props WHERE Storage = '{textBox21.Text}'";
                    using (SqlDataReader reader2 = cmd.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            n = reader2["number"].ToString();
                        }
                    }
                    if (n == "")
                    {
                        cmd.CommandText = $"UPDATE Storages_Props SET number = 1 WHERE Storage = '{textBox21.Text}'";
                        using (SqlDataReader reader2 = cmd.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                n = reader2["number"].ToString();
                            }
                        }
                        
                    }
                    this.propsTableAdapter.Fill(this.dataSet1.Props);
                    this.testtTableAdapter.Fill(this.dataSet1.testt);
                    descriptionTextBox.Clear();
                    textBox21.Clear();
                    MessageBox.Show("Реквизит успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Склад не найден!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Введите корректные данные для добавления склада!");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DashboardAdmin dasha = new DashboardAdmin();
            this.Dispose();
            Close();
            dasha.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            sc.Open();
            string sid = "";
            string n = "";
            cmd.CommandText = $"SELECT StorageId FROM Storages WHERE StorageId = '{textBox22.Text}'";
            using (SqlDataReader reader1 = cmd.ExecuteReader())
            {
                while (reader1.Read())
                {
                    sid = reader1["StorageId"].ToString();
                }
            }
            if (sid == "")
            {
                MessageBox.Show("Склад не найден!");
            }
            else
            {
                cmd.CommandText = $"SELECT number FROM Storages_Props WHERE Storage = '{textBox22.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        n = reader1["number"].ToString();
                    }
                }
                if (n != "")
                {
                    textBox22.Clear();
                    MessageBox.Show("Количество реквизита на складе: " + n);
                }
                else
                {
                    MessageBox.Show("Склад пуст!");
                }
            }
            sc.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "" && textBox11.Text != "")
            {
                sc.Open();
                string loc = "";
                cmd.CommandText = $"SELECT Location FROM Storages WHERE Location = '{textBox13.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        loc = reader1["Location"].ToString();
                    }
                }
                if (loc != "")
                {
                    try
                    {
                        this.storagesTableAdapter.UpdateStorage(textBox11.Text, textBox13.Text);
                        this.storagesTableAdapter.Fill(this.dataSet1.Storages);
                        this.testtTableAdapter.Fill(this.dataSet1.testt);
                        textBox13.Clear();
                        textBox11.Clear();
                        MessageBox.Show("Данные о складе успешно изменены!");
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
                    MessageBox.Show("Склад не найден!");
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные для изменения данных!");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "" && textBox12.Text != "")
            {
                sc.Open();
                string des = "";
                cmd.CommandText = $"SELECT Description FROM Props WHERE Description = '{textBox14.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        des = reader1["Description"].ToString();
                    }
                }
                if (des != "")
                {
                    this.propsTableAdapter.UpdateProp(textBox12.Text, textBox14.Text);
                    this.propsTableAdapter.Fill(this.dataSet1.Props);
                    this.testtTableAdapter.Fill(this.dataSet1.testt);
                    textBox14.Clear();
                    textBox12.Clear();
                    MessageBox.Show("Данные о реквизите успешно изменены!");
                }
                else
                {
                    MessageBox.Show("Реквизит не найден!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Введите корректные данные для изменения данных!");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить реквизит?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //string n = "";
                if (propIdTextBox.Text != "")
                {
                    sc.Open();
                    //cmd.CommandText = $"SELECT DISTINCT number FROM Storages_Props WHERE Storage = '{textBox21.Text}'";
                    //using (SqlDataReader reader2 = cmd.ExecuteReader())
                    //{
                    //    while (reader2.Read())
                    //    {
                    //        n = reader2["number"].ToString();
                    //    }
                    //}
                    //if (n == "")
                    //{
                        //cmd.CommandText = $"UPDATE Storages_Props SET number = 1 WHERE Storage = '{textBox21.Text}'";
                        //using (SqlDataReader reader2 = cmd.ExecuteReader())
                        //{
                        //    while (reader2.Read())
                        //    {
                        //        n = reader2["number"].ToString();
                        //    }
                        //}

                    //}
                    this.propsTableAdapter.DeleteProp(Int32.Parse(propIdTextBox.Text));
                    this.propsTableAdapter.Fill(this.dataSet1.Props);
                    this.testtTableAdapter.Fill(this.dataSet1.testt);
                    MessageBox.Show("Реквизит успешно удален!");
                    propIdTextBox.Clear();
                    sc.Close();
                }
                else
                {
                    MessageBox.Show("Введите Id реквизита!");
                }
            }
            else if (result == DialogResult.No)
            {
                propIdTextBox.Clear();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //if (textBox15.Text != "" && textBox16.Text != "")
            //{
            //    sc.Open();
            //    string sid = "";
            //    string n = "";
            //    string n2 = "";

            //    cmd.CommandText = $"SELECT StorageId FROM Storages WHERE StorageId = '{textBox16.Text}'";
            //    using (SqlDataReader reader1 = cmd.ExecuteReader())
            //    {
            //        while (reader1.Read())
            //        {
            //            sid = reader1["StorageId"].ToString();
            //        }
            //    }

            //    if (sid != "")
            //    {
            //        string oldSt = "";
            //        cmd.CommandText = $"SELECT DISTINCT Storage FROM Storages_Props WHERE Prop = '{textBox15.Text}'";
            //        using (SqlDataReader reader2 = cmd.ExecuteReader())
            //        {
            //            while (reader2.Read())
            //            {
            //                oldSt = reader2["Storage"].ToString();
            //            }
            //        }
            //        //MessageBox.Show(oldSt);

            //        cmd.CommandText = $"SELECT DISTINCT number FROM Storages_Props WHERE Storage = '{oldSt}'";
            //        using (SqlDataReader reader2 = cmd.ExecuteReader())
            //        {
            //            while (reader2.Read())
            //            {
            //                n = reader2["number"].ToString();
            //            }
            //        }
            //        MessageBox.Show(n);

            //        if (n != "")
            //        {
            //            cmd.CommandText = $"UPDATE Storages_Props SET number = number - 1 WHERE Storage = '{oldSt}'";
            //        }
            //        //почему-то не удаляет запись, но апдейтит номер!
            //        cmd.CommandText = $"DELETE FROM Storages_Props WHERE (Storage = {oldSt}' AND Prop = '{textBox15.Text}')";
            //        cmd.CommandText = $"UPDATE Props SET storageID = '{textBox16.Text}' WHERE PropId = '{textBox15.Text}'";

            //        this.storages_PropsTableAdapter.AddPropById(Int32.Parse(textBox15.Text), Int32.Parse(textBox16.Text));
            //        cmd.CommandText = $"SELECT number FROM Storages_Props WHERE Storage = '{textBox16.Text}' AND Prop = '{textBox15.Text}'";
            //        using (SqlDataReader reader3 = cmd.ExecuteReader())
            //        {
            //            while (reader3.Read())
            //            {
            //                n2 = reader3["number"].ToString();
            //            }
            //        }
            //        MessageBox.Show(n2);
            //        if (n2 == "")
            //        {
            //            //почему-то не апдейтит номер!
            //            cmd.CommandText = $"UPDATE Storages_Props SET number = 1 WHERE Storage = '{textBox16.Text}' AND Prop = '{textBox15.Text}'";
            //            cmd.CommandText = $"SELECT number FROM Storages_Props WHERE Storage = '{textBox16.Text}' AND Prop = '{textBox15.Text}'";
            //            using (SqlDataReader reader4 = cmd.ExecuteReader())
            //            {
            //                while (reader4.Read())
            //                {
            //                    n2 = reader4["number"].ToString();
            //                }
            //            }
            //        }
            //        MessageBox.Show(n2);
            //        //почему-то не обновляет таблицу с реквизитом!
            //        this.propsTableAdapter.Fill(this.dataSet1.Props);
            //        this.storages_PropsTableAdapter.Update(this.dataSet1.Storages_Props);
            //        this.testtTableAdapter.Fill(this.dataSet1.testt);
            //        textBox15.Clear();
            //        textBox16.Clear();
            //        MessageBox.Show("Реквизит успешно перенесен на другой склад!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Склад не найден!");
            //    }
            //    sc.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Введите корректные данные для изменения данных!");
            //}
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox20.Text != "" && textBox19.Text != "")
            {
                sc.Open();
                string id = "";
                string prop = "";
                string movie = "";

                cmd.CommandText = $"SELECT PropId FROM Props WHERE PropId = '{textBox20.Text}'";
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        prop = reader1["PropId"].ToString();
                    }
                }
                cmd.CommandText = $"SELECT MovieId FROM Movie WHERE Movie.Title = '{textBox19.Text}'";
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        movie = reader2["MovieId"].ToString();
                    }
                }

                if (prop != "" && movie != "")
                {
                    cmd.CommandText = $"SELECT relationId FROM Movies_Props, Props, Movie WHERE Props.PropId = Movies_Props.Prop AND Movie.MovieId = Movies_Props.Movie AND Props.PropId = '{textBox20.Text}' AND Movie.Title = '{textBox19.Text}'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader["relationId"].ToString();
                        }
                    }
                    //MessageBox.Show(id);
                    if (id != "")
                    {
                        MessageBox.Show("Данный реквизит уже привязан к этому фильму!");
                    }
                    else
                    {
                        this.movies_PropsTableAdapter.SetPropToMovie(Int32.Parse(textBox20.Text), textBox19.Text);
                        textBox20.Clear();
                        textBox19.Clear();
                        MessageBox.Show("Реквизит успешно привязан к фильму");
                    }
                }
                else
                {
                    MessageBox.Show("Данные реквизит или фильм не найдены!");
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для привязки реквизита к фильму!");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox20.Text != "" && textBox19.Text != "")
            {
                sc.Open();
                string idst = "";
                //int ID = -1;
                cmd.CommandText = $"SELECT relationId FROM Movies_Props, Props, Movie WHERE Props.PropId = Movies_Props.Prop AND Movie.MovieId = Movies_Props.Movie AND Props.PropId = '{textBox20.Text}' AND Movie.Title = '{textBox19.Text}'";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idst = reader["relationId"].ToString();
                    }
                }
                if (idst == "")
                {
                    MessageBox.Show("Данный реквизит не привязан к этому фильму!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы точно хотите снять реквизит с фильма?", "Подтвердите снятие с фильма", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.movies_PropsTableAdapter.DeletePropFromMovie(Int32.Parse(idst));
                        textBox20.Clear();
                        textBox19.Clear();
                        MessageBox.Show("Реквизит успешно снят с фильма");
                    }
                    else if (result == DialogResult.No)
                    {
                        textBox20.Clear();
                        textBox19.Clear();
                    }
                }
                sc.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля для снятия реквизита с фильма!");
            }
        }
    }
}
