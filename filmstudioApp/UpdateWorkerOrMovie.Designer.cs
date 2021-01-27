
namespace filmstudioApp
{
    partial class UpdateWorkerOrMovie
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label motherlandLabel;
            System.Windows.Forms.Label degreeLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label rateLabel;
            System.Windows.Forms.Label lengthLabel;
            System.Windows.Forms.Label commentaryLabel;
            System.Windows.Forms.Label budgetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWorkerOrMovie));
            this.dataSet1 = new filmstudioApp.DataSet1();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new filmstudioApp.DataSet1TableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new filmstudioApp.DataSet1TableAdapters.TableAdapterManager();
            this.movieTableAdapter = new filmstudioApp.DataSet1TableAdapters.MovieTableAdapter();
            this.workersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.workersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.motherlandTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.commentaryTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            motherlandLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            lengthLabel = new System.Windows.Forms.Label();
            commentaryLabel = new System.Windows.Forms.Label();
            budgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingNavigator)).BeginInit();
            this.workersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(22, 139);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(74, 20);
            positionLabel.TabIndex = 5;
            positionLabel.Text = "Position:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(22, 172);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(76, 20);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "Birthday:";
            // 
            // motherlandLabel
            // 
            motherlandLabel.AutoSize = true;
            motherlandLabel.Location = new System.Drawing.Point(22, 203);
            motherlandLabel.Name = "motherlandLabel";
            motherlandLabel.Size = new System.Drawing.Size(100, 20);
            motherlandLabel.TabIndex = 9;
            motherlandLabel.Text = "Motherland:";
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(22, 235);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(67, 20);
            degreeLabel.TabIndex = 11;
            degreeLabel.Text = "Degree:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(401, 107);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(47, 20);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "Title:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(401, 140);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(114, 20);
            releaseDateLabel.TabIndex = 18;
            releaseDateLabel.Text = "Release Date:";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(401, 171);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(47, 20);
            rateLabel.TabIndex = 20;
            rateLabel.Text = "Rate:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new System.Drawing.Point(401, 203);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new System.Drawing.Size(63, 20);
            lengthLabel.TabIndex = 22;
            lengthLabel.Text = "Length:";
            // 
            // commentaryLabel
            // 
            commentaryLabel.AutoSize = true;
            commentaryLabel.Location = new System.Drawing.Point(401, 235);
            commentaryLabel.Name = "commentaryLabel";
            commentaryLabel.Size = new System.Drawing.Size(106, 20);
            commentaryLabel.TabIndex = 24;
            commentaryLabel.Text = "Commentary:";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new System.Drawing.Point(401, 267);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new System.Drawing.Size(67, 20);
            budgetLabel.TabIndex = 26;
            budgetLabel.Text = "Budget:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.dataSet1;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Actors_MoviesTableAdapter = null;
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.authentificationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Movies_PropsTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.PropsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.Storages_MoviesTableAdapter = null;
            this.tableAdapterManager.Storages_PropsTableAdapter = null;
            this.tableAdapterManager.StoragesTableAdapter = null;
            this.tableAdapterManager.Studios_MoviesTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = filmstudioApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Workers_MoviesTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // workersBindingNavigator
            // 
            this.workersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workersBindingNavigator.BindingSource = this.workersBindingSource;
            this.workersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workersBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.workersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.workersBindingNavigatorSaveItem});
            this.workersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workersBindingNavigator.Name = "workersBindingNavigator";
            this.workersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workersBindingNavigator.Size = new System.Drawing.Size(1015, 33);
            this.workersBindingNavigator.TabIndex = 0;
            this.workersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // workersBindingNavigatorSaveItem
            // 
            this.workersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workersBindingNavigatorSaveItem.Image")));
            this.workersBindingNavigatorSaveItem.Name = "workersBindingNavigatorSaveItem";
            this.workersBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.workersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.workersBindingNavigatorSaveItem.Click += new System.EventHandler(this.workersBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(128, 104);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(128, 136);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(200, 26);
            this.positionTextBox.TabIndex = 6;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workersBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(128, 168);
            this.birthdayDateTimePicker.MaxDate = new System.DateTime(2020, 12, 13, 0, 0, 0, 0);
            this.birthdayDateTimePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.birthdayDateTimePicker.TabIndex = 8;
            this.birthdayDateTimePicker.Value = new System.DateTime(2020, 12, 13, 0, 0, 0, 0);
            // 
            // motherlandTextBox
            // 
            this.motherlandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Motherland", true));
            this.motherlandTextBox.Location = new System.Drawing.Point(128, 200);
            this.motherlandTextBox.Name = "motherlandTextBox";
            this.motherlandTextBox.Size = new System.Drawing.Size(200, 26);
            this.motherlandTextBox.TabIndex = 10;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Degree", true));
            this.degreeTextBox.Location = new System.Drawing.Point(128, 232);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(200, 26);
            this.degreeTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Изменить данные о работнике";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.dataSet1;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(521, 104);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 26);
            this.titleTextBox.TabIndex = 17;
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.movieBindingSource, "ReleaseDate", true));
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(521, 136);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.releaseDateDateTimePicker.TabIndex = 19;
            // 
            // rateTextBox
            // 
            this.rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Rate", true));
            this.rateTextBox.Location = new System.Drawing.Point(521, 168);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(200, 26);
            this.rateTextBox.TabIndex = 21;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Length", true));
            this.lengthTextBox.Location = new System.Drawing.Point(521, 200);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(200, 26);
            this.lengthTextBox.TabIndex = 23;
            // 
            // commentaryTextBox
            // 
            this.commentaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Commentary", true));
            this.commentaryTextBox.Location = new System.Drawing.Point(521, 232);
            this.commentaryTextBox.Name = "commentaryTextBox";
            this.commentaryTextBox.Size = new System.Drawing.Size(200, 26);
            this.commentaryTextBox.TabIndex = 25;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Budget", true));
            this.budgetTextBox.Location = new System.Drawing.Point(521, 264);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(200, 26);
            this.budgetTextBox.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 58);
            this.button4.TabIndex = 31;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 40);
            this.label3.TabIndex = 32;
            this.label3.Text = "Чтобы изменить данные о фильме,\r\nвведите нужные данные в поля выше и нажмите кноп" +
    "ку \"Изменить\"";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 38);
            this.button5.TabIndex = 33;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "Чтобы добавить фильм, пожалуйста, заполните поля ниже\r\nи нажмите на кнопку \"Добав" +
    "ить фильм\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 53);
            this.button2.TabIndex = 29;
            this.button2.Text = "Добавить фильм";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(405, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(534, 40);
            this.label12.TabIndex = 83;
            this.label12.Text = "ВНИМАНИЕ! Если значения длины фильма и бюджета неизвестны,\r\nпоставьте 0 в соответ" +
    "ствующих полях!";
            // 
            // UpdateWorkerOrMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1015, 586);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(rateLabel);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(lengthLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(commentaryLabel);
            this.Controls.Add(this.commentaryTextBox);
            this.Controls.Add(budgetLabel);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(motherlandLabel);
            this.Controls.Add(this.motherlandTextBox);
            this.Controls.Add(degreeLabel);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(this.workersBindingNavigator);
            this.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateWorkerOrMovie";
            this.Text = "UpdateActorOrMovie";
            this.Load += new System.EventHandler(this.UpdateWorkerOrMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingNavigator)).EndInit();
            this.workersBindingNavigator.ResumeLayout(false);
            this.workersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton workersBindingNavigatorSaveItem;
        private DataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox motherlandTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox commentaryTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
    }
}