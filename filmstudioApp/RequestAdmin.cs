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
    public partial class RequestAdmin : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public RequestAdmin()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DashboardAdmin dasha = new DashboardAdmin();
            this.Dispose();
            Close();
            //dasha.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idRequestTextBox.Text != "" && statusTextBox.Text != "")
            {
                this.requestsTableAdapter.UpdateStatus(statusTextBox.Text, Int32.Parse(idRequestTextBox.Text));
                this.requestsTableAdapter.Fill(this.dataSet1.Requests);
                idRequestTextBox.Clear();
                statusTextBox.Clear();
                MessageBox.Show("Статус заявки успешно изменен!");
            }
            else
            {
                MessageBox.Show("Заполните поля для подачи заявки!");
            }
        }

        private void RequestAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.dataSet1.Requests);

        }
    }
}
