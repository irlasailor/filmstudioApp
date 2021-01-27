
namespace filmstudioApp
{
    partial class RequestWorker
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
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label commentaryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestWorker));
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.commentaryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new filmstudioApp.DataSet1();
            this.tableAdapterManager = new filmstudioApp.DataSet1TableAdapters.TableAdapterManager();
            this.requestsTableAdapter = new filmstudioApp.DataSet1TableAdapters.RequestsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            typeLabel = new System.Windows.Forms.Label();
            commentaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(265, 350);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(107, 20);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "Тема заявки:";
            // 
            // commentaryLabel
            // 
            commentaryLabel.AutoSize = true;
            commentaryLabel.Location = new System.Drawing.Point(265, 382);
            commentaryLabel.Name = "commentaryLabel";
            commentaryLabel.Size = new System.Drawing.Size(116, 20);
            commentaryLabel.TabIndex = 6;
            commentaryLabel.Text = "Комментарий:";
            // 
            // requestsDataGridView
            // 
            this.requestsDataGridView.AllowUserToAddRows = false;
            this.requestsDataGridView.AllowUserToDeleteRows = false;
            this.requestsDataGridView.AutoGenerateColumns = false;
            this.requestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRequestDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.commentaryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.requestsDataGridView.DataSource = this.requestsBindingSource;
            this.requestsDataGridView.Location = new System.Drawing.Point(29, 36);
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.RowHeadersWidth = 62;
            this.requestsDataGridView.RowTemplate.Height = 28;
            this.requestsDataGridView.ShowEditingIcon = false;
            this.requestsDataGridView.Size = new System.Drawing.Size(698, 223);
            this.requestsDataGridView.TabIndex = 1;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(390, 347);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(337, 26);
            this.typeTextBox.TabIndex = 5;
            // 
            // commentaryTextBox
            // 
            this.commentaryTextBox.Location = new System.Drawing.Point(390, 379);
            this.commentaryTextBox.Name = "commentaryTextBox";
            this.commentaryTextBox.Size = new System.Drawing.Size(337, 26);
            this.commentaryTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Послать заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Чтобы послать заявку на реквизит или актера/работника,\r\nзаполните поля ниже:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 100);
            this.label2.TabIndex = 12;
            this.label2.Text = "Статусы заявок:\r\nnew - новая заявка\r\nin process - на рассмотрении\r\ndeclined - зая" +
    "вка отклонена\r\ndone - заявка выполнена";
            // 
            // idRequestDataGridViewTextBoxColumn
            // 
            this.idRequestDataGridViewTextBoxColumn.DataPropertyName = "IdRequest";
            this.idRequestDataGridViewTextBoxColumn.HeaderText = "IdRequest";
            this.idRequestDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idRequestDataGridViewTextBoxColumn.Name = "idRequestDataGridViewTextBoxColumn";
            this.idRequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRequestDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentaryDataGridViewTextBoxColumn
            // 
            this.commentaryDataGridViewTextBoxColumn.DataPropertyName = "Commentary";
            this.commentaryDataGridViewTextBoxColumn.HeaderText = "Commentary";
            this.commentaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.commentaryDataGridViewTextBoxColumn.Name = "commentaryDataGridViewTextBoxColumn";
            this.commentaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Actors_MoviesTableAdapter = null;
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RequestWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(777, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(commentaryLabel);
            this.Controls.Add(this.commentaryTextBox);
            this.Controls.Add(this.requestsDataGridView);
            this.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestWorker";
            this.Text = "RequestWorker";
            this.Load += new System.EventHandler(this.RequestWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView requestsDataGridView;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox commentaryTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private DataSet1TableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}