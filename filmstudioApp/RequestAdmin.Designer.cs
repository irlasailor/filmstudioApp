
namespace filmstudioApp
{
    partial class RequestAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestAdmin));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idRequestTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new filmstudioApp.DataSet1();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new filmstudioApp.DataSet1TableAdapters.RequestsTableAdapter();
            this.tableAdapterManager = new filmstudioApp.DataSet1TableAdapters.TableAdapterManager();
            this.idRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeLabel = new System.Windows.Forms.Label();
            commentaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 100);
            this.label2.TabIndex = 21;
            this.label2.Text = "Статусы заявок:\r\nnew - новая заявка\r\nin process - на рассмотрении\r\ndeclined - зая" +
    "вка отклонена\r\ndone - заявка выполнена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Чтобы изменить статус заявки, найдите в таблице ее IdRequest\r\nи заполните соответ" +
    "ствующие поля:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Изменить статус";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(257, 337);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(148, 20);
            typeLabel.TabIndex = 15;
            typeLabel.Text = "IdRequest заявки:";
            // 
            // idRequestTextBox
            // 
            this.idRequestTextBox.Location = new System.Drawing.Point(411, 334);
            this.idRequestTextBox.Name = "idRequestTextBox";
            this.idRequestTextBox.Size = new System.Drawing.Size(358, 26);
            this.idRequestTextBox.TabIndex = 16;
            // 
            // commentaryLabel
            // 
            commentaryLabel.AutoSize = true;
            commentaryLabel.Location = new System.Drawing.Point(257, 369);
            commentaryLabel.Name = "commentaryLabel";
            commentaryLabel.Size = new System.Drawing.Size(117, 20);
            commentaryLabel.TabIndex = 17;
            commentaryLabel.Text = "Новый статус:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(411, 366);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(358, 26);
            this.statusTextBox.TabIndex = 18;
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
            this.requestsDataGridView.Location = new System.Drawing.Point(21, 23);
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.RowHeadersWidth = 62;
            this.requestsDataGridView.RowTemplate.Height = 28;
            this.requestsDataGridView.ShowEditingIcon = false;
            this.requestsDataGridView.Size = new System.Drawing.Size(748, 223);
            this.requestsDataGridView.TabIndex = 14;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.dataSet1;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Actors_MoviesTableAdapter = null;
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Movies_PropsTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.PropsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = this.requestsTableAdapter;
            this.tableAdapterManager.Storages_MoviesTableAdapter = null;
            this.tableAdapterManager.Storages_PropsTableAdapter = null;
            this.tableAdapterManager.StoragesTableAdapter = null;
            this.tableAdapterManager.Studios_MoviesTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = filmstudioApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Workers_MoviesTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = null;
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
            // RequestAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.idRequestTextBox);
            this.Controls.Add(commentaryLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.requestsDataGridView);
            this.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestAdmin";
            this.Text = "RequestAdmin";
            this.Load += new System.EventHandler(this.RequestAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idRequestTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DataGridView requestsDataGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private DataSet1TableAdapters.RequestsTableAdapter requestsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}