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
    public partial class RequestWorker : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source = IRLASAILOR\SQLEXPRESS; Initial Catalog = filmstudio; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public RequestWorker()
        {
            InitializeComponent();
            cmd.Connection = sc;
        }

        private void requestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void RequestWorker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.dataSet1.Requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Requests". При необходимости она может быть перемещена или удалена.
            //this.requestsTableAdapter.Fill(this.dataSet1.Requests);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (typeTextBox.Text != "" && commentaryTextBox.Text != "") {
                this.requestsTableAdapter.InsertRequest(typeTextBox.Text, commentaryTextBox.Text);
                this.requestsTableAdapter.Fill(this.dataSet1.Requests);
                typeTextBox.Clear();
                commentaryTextBox.Clear();
                MessageBox.Show("Ваша заявка была передана в систему и получила статус 'new'. Когда администратор ее рассмотрит, она получит статус 'in process'. Отклоненные заявки получают статус 'declined', закрытые заявки будут помечены 'done'.");
            }
            else
            {
                MessageBox.Show("Заполните поля для подачи заявки!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DashboardWorker dashw = new DashboardWorker();
            this.Dispose();
            Close();
            //dashw.Show();
        }
    }
}
