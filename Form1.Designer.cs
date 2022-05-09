
namespace MpKurs1
{
    partial class Form11
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииСТаблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеДанныхВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стажРаботыВсехСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создание2ойТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Запись = new System.Windows.Forms.ListBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-14, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииСТаблицейToolStripMenuItem,
            this.toolStripMenuItem1,
            this.аналитикаToolStripMenuItem,
            this.создание2ойТаблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1433, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Операции с таблицей";
            // 
            // операцииСТаблицейToolStripMenuItem
            // 
            this.операцииСТаблицейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеДанныхToolStripMenuItem,
            this.режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem,
            this.сохранениеДанныхВФайлToolStripMenuItem});
            this.операцииСТаблицейToolStripMenuItem.Name = "операцииСТаблицейToolStripMenuItem";
            this.операцииСТаблицейToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.операцииСТаблицейToolStripMenuItem.Text = "Операции с таблицей";
            // 
            // добавлениеДанныхToolStripMenuItem
            // 
            this.добавлениеДанныхToolStripMenuItem.Name = "добавлениеДанныхToolStripMenuItem";
            this.добавлениеДанныхToolStripMenuItem.Size = new System.Drawing.Size(411, 26);
            this.добавлениеДанныхToolStripMenuItem.Text = "Добавление данных";
            this.добавлениеДанныхToolStripMenuItem.Click += new System.EventHandler(this.добавлениеДанныхToolStripMenuItem_Click);
            // 
            // режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem
            // 
            this.режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem.Name = "режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem";
            this.режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem.Size = new System.Drawing.Size(411, 26);
            this.режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem.Text = "Режим загрузки данных из стороннего файла";
            this.режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem.Click += new System.EventHandler(this.режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem_Click);
            // 
            // сохранениеДанныхВФайлToolStripMenuItem
            // 
            this.сохранениеДанныхВФайлToolStripMenuItem.Name = "сохранениеДанныхВФайлToolStripMenuItem";
            this.сохранениеДанныхВФайлToolStripMenuItem.Size = new System.Drawing.Size(411, 26);
            this.сохранениеДанныхВФайлToolStripMenuItem.Text = "Сохранение данных в файл";
            this.сохранениеДанныхВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранениеДанныхВФайлToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 26);
            // 
            // аналитикаToolStripMenuItem
            // 
            this.аналитикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стажРаботыВсехСотрудниковToolStripMenuItem,
            this.среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem,
            this.количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem,
            this.увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem});
            this.аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            this.аналитикаToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            // 
            // стажРаботыВсехСотрудниковToolStripMenuItem
            // 
            this.стажРаботыВсехСотрудниковToolStripMenuItem.Name = "стажРаботыВсехСотрудниковToolStripMenuItem";
            this.стажРаботыВсехСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(509, 26);
            this.стажРаботыВсехСотрудниковToolStripMenuItem.Text = "Стаж работы всех сотрудников";
            this.стажРаботыВсехСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.стажРаботыВсехСотрудниковToolStripMenuItem_Click);
            // 
            // среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem
            // 
            this.среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem.Name = "среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem";
            this.среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem.Size = new System.Drawing.Size(509, 26);
            this.среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem.Text = "Средний стаж работы сотрудников заданного отдела";
            this.среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem.Click += new System.EventHandler(this.среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem_Click);
            // 
            // количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem
            // 
            this.количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem.Name = "количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem";
            this.количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem.Size = new System.Drawing.Size(509, 26);
            this.количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem.Text = "Количество сотрудников с окладом ниже заданного";
            this.количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem.Click += new System.EventHandler(this.количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem_Click);
            // 
            // увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem
            // 
            this.увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem.Name = "увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem";
            this.увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem.Size = new System.Drawing.Size(509, 26);
            this.увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem.Text = "Увеличить оклад лицам со стажем работы выше заданного";
            this.увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem.Click += new System.EventHandler(this.увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem_Click);
            // 
            // создание2ойТаблицыToolStripMenuItem
            // 
            this.создание2ойТаблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сToolStripMenuItem,
            this.удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem});
            this.создание2ойТаблицыToolStripMenuItem.Name = "создание2ойТаблицыToolStripMenuItem";
            this.создание2ойТаблицыToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.создание2ойТаблицыToolStripMenuItem.Text = "Создание 2-ой таблицы с:";
            // 
            // сToolStripMenuItem
            // 
            this.сToolStripMenuItem.Name = "сToolStripMenuItem";
            this.сToolStripMenuItem.Size = new System.Drawing.Size(471, 26);
            this.сToolStripMenuItem.Text = "Сотрудники пенсионного возраста";
            this.сToolStripMenuItem.Click += new System.EventHandler(this.сToolStripMenuItem_Click);
            // 
            // удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem
            // 
            this.удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem.Name = "удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem";
            this.удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem.Size = new System.Drawing.Size(471, 26);
            this.удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem.Text = "Удалить данные о сотрудниках пенсионного возраста";
            this.удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem.Click += new System.EventHandler(this.удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1078, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 729);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Название отдела";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 772);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 815);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата поступления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 858);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Должность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 901);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Оклад";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 683);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 37);
            this.textBox3.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 597);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 37);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 640);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 37);
            this.textBox2.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 726);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 37);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 769);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(232, 37);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 812);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(232, 37);
            this.textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(149, 855);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(232, 37);
            this.textBox7.TabIndex = 26;
            // 
            // Запись
            // 
            this.Запись.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Запись.FormattingEnabled = true;
            this.Запись.ItemHeight = 31;
            this.Запись.Location = new System.Drawing.Point(0, 542);
            this.Запись.Name = "Запись";
            this.Запись.Size = new System.Drawing.Size(427, 438);
            this.Запись.TabIndex = 28;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(149, 898);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(232, 37);
            this.textBox8.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Номер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 36);
            this.label9.TabIndex = 31;
            this.label9.Text = "Запись:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1110, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Поиск информации";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1115, 580);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(232, 37);
            this.textBox9.TabIndex = 32;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(934, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 46);
            this.button3.TabIndex = 35;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1222, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 36;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 46);
            this.button4.TabIndex = 37;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1433, 31);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 28);
            this.toolStripLabel1.Text = "Лист №";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 986);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Запись);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form11";
            this.Text = "Органайзер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииСТаблицейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавлениеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стажРаботыВсехСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создание2ойТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеДанныхВФайлToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox Запись;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem;
    }
}

