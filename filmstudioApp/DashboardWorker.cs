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
    public partial class DashboardWorker : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        public DashboardWorker()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void DashboardWorker_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            this.Dispose();
            Close();
            worker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string fio = textBox1.Text;
                this.actorsTableAdapter.FillByActor(this.dataSet1.Actors, fio);
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
                MessageBox.Show("Пожалуйста, введите корректное ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string film = textBox3.Text;
                this.actorsByMovieTableAdapter.FillActByMov(this.dataSet1.ActorsByMovie, film);
                this.workersByMovieTableAdapter.FillWrkByFilm(this.dataSet1.WorkersByMovie, film);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное название фильма!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateWorkerOrMovie upd = new UpdateWorkerOrMovie();
            this.Dispose();
            Close();
            upd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RequestWorker reqw = new RequestWorker();
            //this.Dispose();
            //Close();
            reqw.Show();
        }
    }
}
