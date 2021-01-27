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
    public partial class DashboardAdmin : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public DashboardAdmin()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            this.Dispose();
            Close();
            adm.Show();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                string fio = textBox4.Text;
                this.workersTableAdapter.FillWorkerByName(this.dataSet1.Workers, fio);
                this.filmsWorkerTableAdapter.FillByWorker(this.dataSet1.FilmsWorker, fio);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string fio = textBox1.Text;
                this.actorsTableAdapter.FillByActor(this.dataSet1.Actors, fio);
                this.filmsActorTableAdapter.FillByActor(this.dataSet1.FilmsActor, fio);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string str = textBox2.Text;
                this.testtTableAdapter.FillByStorage(this.dataSet1.testt, str);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный склад!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string film = textBox3.Text;
                this.actorsByMovieTableAdapter.FillActByMov(this.dataSet1.ActorsByMovie, film);
                this.workersByMovieTableAdapter.FillWrkByFilm(this.dataSet1.WorkersByMovie, film);
                this.moviePropsStoragesTableAdapter.FillByMovie(this.dataSet1.MoviePropsStorages, film);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное название фильма!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataPanel dp = new DataPanel();
            this.Dispose();
            Close();
            dp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RequestAdmin reqa = new RequestAdmin();
            //this.Dispose();
            //Close();
            reqa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.testttTableAdapter.Fill(this.dataSet1.testtt);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.testttTableAdapter.FillByMax(this.dataSet1.testtt);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                string location = textBox5.Text;
                this.filmsStudioTableAdapter.FillByStudio(this.dataSet1.FilmsStudio, location);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный павильон!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void filmsActorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
