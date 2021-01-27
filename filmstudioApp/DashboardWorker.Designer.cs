
namespace filmstudioApp
{
    partial class DashboardWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardWorker));
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherlandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new filmstudioApp.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.actors_MoviesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsByMovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsTableAdapter = new filmstudioApp.DataSet1TableAdapters.ActorsTableAdapter();
            this.tableAdapterManager = new filmstudioApp.DataSet1TableAdapters.TableAdapterManager();
            this.testtTableAdapter = new filmstudioApp.DataSet1TableAdapters.testtTableAdapter();
            this.actorsByMovieTableAdapter = new filmstudioApp.DataSet1TableAdapters.ActorsByMovieTableAdapter();
            this.workersByMovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersByMovieTableAdapter = new filmstudioApp.DataSet1TableAdapters.WorkersByMovieTableAdapter();
            this.workersByMovieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actors_MoviesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsByMovieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersByMovieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersByMovieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ввод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск актера по ФИО:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.motherlandDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(921, 90);
            this.dataGridView1.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // motherlandDataGridViewTextBoxColumn
            // 
            this.motherlandDataGridViewTextBoxColumn.DataPropertyName = "Motherland";
            this.motherlandDataGridViewTextBoxColumn.HeaderText = "Motherland";
            this.motherlandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.motherlandDataGridViewTextBoxColumn.Name = "motherlandDataGridViewTextBoxColumn";
            this.motherlandDataGridViewTextBoxColumn.ReadOnly = true;
            this.motherlandDataGridViewTextBoxColumn.Width = 150;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeDataGridViewTextBoxColumn.Width = 150;
            // 
            // activityDataGridViewTextBoxColumn
            // 
            this.activityDataGridViewTextBoxColumn.DataPropertyName = "Activity";
            this.activityDataGridViewTextBoxColumn.HeaderText = "Activity";
            this.activityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            this.activityDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityDataGridViewTextBoxColumn.Width = 150;
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.testtBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(37, 341);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(381, 90);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Storage";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Prop";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // testtBindingSource
            // 
            this.testtBindingSource.DataMember = "testt";
            this.testtBindingSource.DataSource = this.dataSet1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ввод";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 26);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск реквизита по складу:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(271, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 84);
            this.button5.TabIndex = 15;
            this.button5.Text = "Послать заявку";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Список актеров/работников по фильму:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(315, 26);
            this.textBox3.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(783, 275);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 45);
            this.button7.TabIndex = 19;
            this.button7.Text = "Ввод";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // actors_MoviesDataGridView
            // 
            this.actors_MoviesDataGridView.AllowUserToAddRows = false;
            this.actors_MoviesDataGridView.AllowUserToDeleteRows = false;
            this.actors_MoviesDataGridView.AutoGenerateColumns = false;
            this.actors_MoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actors_MoviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.actors_MoviesDataGridView.DataSource = this.actorsByMovieBindingSource;
            this.actors_MoviesDataGridView.Location = new System.Drawing.Point(445, 361);
            this.actors_MoviesDataGridView.Name = "actors_MoviesDataGridView";
            this.actors_MoviesDataGridView.ReadOnly = true;
            this.actors_MoviesDataGridView.RowHeadersWidth = 62;
            this.actors_MoviesDataGridView.RowTemplate.Height = 28;
            this.actors_MoviesDataGridView.ShowEditingIcon = false;
            this.actors_MoviesDataGridView.Size = new System.Drawing.Size(214, 220);
            this.actors_MoviesDataGridView.TabIndex = 19;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // actorsByMovieBindingSource
            // 
            this.actorsByMovieBindingSource.DataMember = "ActorsByMovie";
            this.actorsByMovieBindingSource.DataSource = this.dataSet1;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Actors_MoviesTableAdapter = null;
            this.tableAdapterManager.ActorsTableAdapter = this.actorsTableAdapter;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Movies_PropsTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.PropsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.Storages_MoviesTableAdapter = null;
            this.tableAdapterManager.Storages_PropsTableAdapter = null;
            this.tableAdapterManager.StoragesTableAdapter = null;
            this.tableAdapterManager.Studios_MoviesTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = filmstudioApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Workers_MoviesTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // testtTableAdapter
            // 
            this.testtTableAdapter.ClearBeforeFill = true;
            // 
            // actorsByMovieTableAdapter
            // 
            this.actorsByMovieTableAdapter.ClearBeforeFill = true;
            // 
            // workersByMovieBindingSource
            // 
            this.workersByMovieBindingSource.DataMember = "WorkersByMovie";
            this.workersByMovieBindingSource.DataSource = this.dataSet1;
            // 
            // workersByMovieTableAdapter
            // 
            this.workersByMovieTableAdapter.ClearBeforeFill = true;
            // 
            // workersByMovieDataGridView
            // 
            this.workersByMovieDataGridView.AllowUserToAddRows = false;
            this.workersByMovieDataGridView.AllowUserToDeleteRows = false;
            this.workersByMovieDataGridView.AutoGenerateColumns = false;
            this.workersByMovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersByMovieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.workersByMovieDataGridView.DataSource = this.workersByMovieBindingSource;
            this.workersByMovieDataGridView.Location = new System.Drawing.Point(692, 361);
            this.workersByMovieDataGridView.Name = "workersByMovieDataGridView";
            this.workersByMovieDataGridView.ReadOnly = true;
            this.workersByMovieDataGridView.RowHeadersWidth = 62;
            this.workersByMovieDataGridView.RowTemplate.Height = 28;
            this.workersByMovieDataGridView.ShowEditingIcon = false;
            this.workersByMovieDataGridView.Size = new System.Drawing.Size(217, 220);
            this.workersByMovieDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(37, 463);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(219, 84);
            this.button8.TabIndex = 20;
            this.button8.Text = "Перейти в панель управления фильмами/работниками";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Список актеров фильма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Список работников фильма";
            // 
            // DashboardWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 609);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.workersByMovieDataGridView);
            this.Controls.Add(this.actors_MoviesDataGridView);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardWorker";
            this.Text = "DashboardWorker";
            this.Load += new System.EventHandler(this.DashboardWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actors_MoviesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsByMovieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersByMovieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersByMovieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private DataSet1TableAdapters.ActorsTableAdapter actorsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherlandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testtBindingSource;
        private DataSet1TableAdapters.testtTableAdapter testtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView actors_MoviesDataGridView;
        private System.Windows.Forms.BindingSource actorsByMovieBindingSource;
        private DataSet1TableAdapters.ActorsByMovieTableAdapter actorsByMovieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource workersByMovieBindingSource;
        private DataSet1TableAdapters.WorkersByMovieTableAdapter workersByMovieTableAdapter;
        private System.Windows.Forms.DataGridView workersByMovieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}