
namespace Project1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОтчествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПаспортуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТелефонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУдостоверениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поМаркеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поМоделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКлассуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госНомерАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяЗаказасуткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусвыполненияDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet4 = new Project1.newdb4eckDataSet4();
            this.заказыTableAdapter = new Project1.newdb4eckDataSet4TableAdapters.ЗаказыTableAdapter();
            this.f1tb2 = new System.Windows.Forms.TextBox();
            this.f1cb1 = new System.Windows.Forms.ComboBox();
            this.тарифBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet13 = new Project1.newdb4eckDataSet13();
            this.f1tb1 = new System.Windows.Forms.ComboBox();
            this.f1lb1 = new System.Windows.Forms.Label();
            this.тарифTableAdapter = new Project1.newdb4eckDataSet13TableAdapters.ТарифTableAdapter();
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            this.f1btn1 = new Project1.Button2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобилиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.тарифToolStripMenuItem,
            this.классToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.автомобилиToolStripMenuItem_Click);
            this.автомобилиToolStripMenuItem.MouseEnter += new System.EventHandler(this.автомобилиToolStripMenuItem_MouseEnter);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // тарифToolStripMenuItem
            // 
            this.тарифToolStripMenuItem.Name = "тарифToolStripMenuItem";
            this.тарифToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.тарифToolStripMenuItem.Text = "Тариф";
            this.тарифToolStripMenuItem.Click += new System.EventHandler(this.тарифToolStripMenuItem_Click);
            // 
            // классToolStripMenuItem
            // 
            this.классToolStripMenuItem.Name = "классToolStripMenuItem";
            this.классToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.классToolStripMenuItem.Text = "Класс";
            this.классToolStripMenuItem.Click += new System.EventHandler(this.классToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентаToolStripMenuItem,
            this.автомобиляToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.запросыToolStripMenuItem.Text = "Поиск";
            // 
            // клиентаToolStripMenuItem
            // 
            this.клиентаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem,
            this.поИмениToolStripMenuItem,
            this.поОтчествуToolStripMenuItem,
            this.поПаспортуToolStripMenuItem,
            this.поТелефонуToolStripMenuItem,
            this.поУдостоверениюToolStripMenuItem});
            this.клиентаToolStripMenuItem.Name = "клиентаToolStripMenuItem";
            this.клиентаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.клиентаToolStripMenuItem.Text = "Клиента";
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поФамилииToolStripMenuItem.Text = "по фамилии";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.поФамилииToolStripMenuItem_Click);
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поИмениToolStripMenuItem.Text = "по имени";
            this.поИмениToolStripMenuItem.Click += new System.EventHandler(this.поИмениToolStripMenuItem_Click);
            // 
            // поОтчествуToolStripMenuItem
            // 
            this.поОтчествуToolStripMenuItem.Name = "поОтчествуToolStripMenuItem";
            this.поОтчествуToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поОтчествуToolStripMenuItem.Text = "по отчеству";
            this.поОтчествуToolStripMenuItem.Click += new System.EventHandler(this.поОтчествуToolStripMenuItem_Click);
            // 
            // поПаспортуToolStripMenuItem
            // 
            this.поПаспортуToolStripMenuItem.Name = "поПаспортуToolStripMenuItem";
            this.поПаспортуToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поПаспортуToolStripMenuItem.Text = "по паспорту";
            this.поПаспортуToolStripMenuItem.Click += new System.EventHandler(this.поПаспортуToolStripMenuItem_Click);
            // 
            // поТелефонуToolStripMenuItem
            // 
            this.поТелефонуToolStripMenuItem.Name = "поТелефонуToolStripMenuItem";
            this.поТелефонуToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поТелефонуToolStripMenuItem.Text = "по телефону";
            this.поТелефонуToolStripMenuItem.Click += new System.EventHandler(this.поТелефонуToolStripMenuItem_Click);
            // 
            // поУдостоверениюToolStripMenuItem
            // 
            this.поУдостоверениюToolStripMenuItem.Name = "поУдостоверениюToolStripMenuItem";
            this.поУдостоверениюToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поУдостоверениюToolStripMenuItem.Text = "по удостоверению";
            this.поУдостоверениюToolStripMenuItem.Click += new System.EventHandler(this.поУдостоверениюToolStripMenuItem_Click);
            // 
            // автомобиляToolStripMenuItem
            // 
            this.автомобиляToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поМаркеToolStripMenuItem,
            this.поМоделиToolStripMenuItem,
            this.поКлассуToolStripMenuItem});
            this.автомобиляToolStripMenuItem.Name = "автомобиляToolStripMenuItem";
            this.автомобиляToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.автомобиляToolStripMenuItem.Text = "Автомобиля";
            // 
            // поМаркеToolStripMenuItem
            // 
            this.поМаркеToolStripMenuItem.Name = "поМаркеToolStripMenuItem";
            this.поМаркеToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.поМаркеToolStripMenuItem.Text = "по марке";
            this.поМаркеToolStripMenuItem.Click += new System.EventHandler(this.поМаркеToolStripMenuItem_Click);
            // 
            // поМоделиToolStripMenuItem
            // 
            this.поМоделиToolStripMenuItem.Name = "поМоделиToolStripMenuItem";
            this.поМоделиToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.поМоделиToolStripMenuItem.Text = "по модели";
            this.поМоделиToolStripMenuItem.Click += new System.EventHandler(this.поМоделиToolStripMenuItem_Click);
            // 
            // поКлассуToolStripMenuItem
            // 
            this.поКлассуToolStripMenuItem.Name = "поКлассуToolStripMenuItem";
            this.поКлассуToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.поКлассуToolStripMenuItem.Text = "по классу";
            this.поКлассуToolStripMenuItem.Click += new System.EventHandler(this.поКлассуToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаказаDataGridViewTextBoxColumn,
            this.паспортКлиентаDataGridViewTextBoxColumn,
            this.госНомерАвтомобиляDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.времяЗаказасуткиDataGridViewTextBoxColumn,
            this.тарифDataGridViewTextBoxColumn,
            this.статусвыполненияDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 352);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDЗаказаDataGridViewTextBoxColumn
            // 
            this.iDЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.HeaderText = "ID Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.Name = "iDЗаказаDataGridViewTextBoxColumn";
            // 
            // паспортКлиентаDataGridViewTextBoxColumn
            // 
            this.паспортКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Паспорт клиента";
            this.паспортКлиентаDataGridViewTextBoxColumn.HeaderText = "Паспорт клиента";
            this.паспортКлиентаDataGridViewTextBoxColumn.Name = "паспортКлиентаDataGridViewTextBoxColumn";
            // 
            // госНомерАвтомобиляDataGridViewTextBoxColumn
            // 
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Гос номер автомобиля";
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Гос номер автомобиля";
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.Name = "госНомерАвтомобиляDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.датаЗаказаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // времяЗаказасуткиDataGridViewTextBoxColumn
            // 
            this.времяЗаказасуткиDataGridViewTextBoxColumn.DataPropertyName = "Время заказа (сутки)";
            this.времяЗаказасуткиDataGridViewTextBoxColumn.HeaderText = "Время заказа (сутки)";
            this.времяЗаказасуткиDataGridViewTextBoxColumn.Name = "времяЗаказасуткиDataGridViewTextBoxColumn";
            // 
            // тарифDataGridViewTextBoxColumn
            // 
            this.тарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф";
            this.тарифDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.тарифDataGridViewTextBoxColumn.Name = "тарифDataGridViewTextBoxColumn";
            // 
            // статусвыполненияDataGridViewCheckBoxColumn
            // 
            this.статусвыполненияDataGridViewCheckBoxColumn.DataPropertyName = "Статус_выполнения";
            this.статусвыполненияDataGridViewCheckBoxColumn.HeaderText = "Статус выполнения";
            this.статусвыполненияDataGridViewCheckBoxColumn.Name = "статусвыполненияDataGridViewCheckBoxColumn";
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.newdb4eckDataSet4;
            // 
            // newdb4eckDataSet4
            // 
            this.newdb4eckDataSet4.DataSetName = "newdb4eckDataSet4";
            this.newdb4eckDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // f1tb2
            // 
            this.f1tb2.Location = new System.Drawing.Point(94, 410);
            this.f1tb2.Name = "f1tb2";
            this.f1tb2.Size = new System.Drawing.Size(143, 20);
            this.f1tb2.TabIndex = 4;
            this.f1tb2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // f1cb1
            // 
            this.f1cb1.DataSource = this.тарифBindingSource;
            this.f1cb1.DisplayMember = "Тариф";
            this.f1cb1.FormattingEnabled = true;
            this.f1cb1.Location = new System.Drawing.Point(243, 410);
            this.f1cb1.Name = "f1cb1";
            this.f1cb1.Size = new System.Drawing.Size(143, 21);
            this.f1cb1.TabIndex = 5;
            this.f1cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.f1cb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f1cb1_KeyPress);
            // 
            // тарифBindingSource
            // 
            this.тарифBindingSource.DataMember = "Тариф";
            this.тарифBindingSource.DataSource = this.newdb4eckDataSet13;
            // 
            // newdb4eckDataSet13
            // 
            this.newdb4eckDataSet13.DataSetName = "newdb4eckDataSet13";
            this.newdb4eckDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f1tb1
            // 
            this.f1tb1.DataSource = this.заказыBindingSource;
            this.f1tb1.DisplayMember = "ID_Заказа";
            this.f1tb1.FormattingEnabled = true;
            this.f1tb1.Location = new System.Drawing.Point(3, 409);
            this.f1tb1.Name = "f1tb1";
            this.f1tb1.Size = new System.Drawing.Size(85, 21);
            this.f1tb1.TabIndex = 8;
            this.f1tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f1tb1_KeyPress);
            // 
            // f1lb1
            // 
            this.f1lb1.AutoSize = true;
            this.f1lb1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1lb1.Location = new System.Drawing.Point(-1, 384);
            this.f1lb1.Name = "f1lb1";
            this.f1lb1.Size = new System.Drawing.Size(210, 23);
            this.f1lb1.TabIndex = 9;
            this.f1lb1.Text = "Изменить данные заказа:";
            // 
            // тарифTableAdapter
            // 
            this.тарифTableAdapter.ClearBeforeFill = true;
            // 
            // Exitbtn1
            // 
            this.Exitbtn1.BackColor = System.Drawing.Color.DimGray;
            this.Exitbtn1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Exitbtn1.ForeColor = System.Drawing.Color.White;
            this.Exitbtn1.Location = new System.Drawing.Point(632, 409);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(100, 56);
            this.Exitbtn1.TabIndex = 11;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "Выйти";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(438, 409);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(166, 56);
            this.button21.TabIndex = 12;
            this.button21.Text = "Отчет по заказам";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // f1btn1
            // 
            this.f1btn1.BackColor = System.Drawing.Color.DimGray;
            this.f1btn1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.f1btn1.ForeColor = System.Drawing.Color.White;
            this.f1btn1.Location = new System.Drawing.Point(68, 443);
            this.f1btn1.Name = "f1btn1";
            this.f1btn1.Rounding = 40;
            this.f1btn1.RoundingEnable = true;
            this.f1btn1.Size = new System.Drawing.Size(189, 25);
            this.f1btn1.TabIndex = 13;
            this.f1btn1.Text = "Изменить";
            this.f1btn1.TextHover = null;
            this.f1btn1.Click += new System.EventHandler(this.f1btn1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(744, 478);
            this.Controls.Add(this.f1btn1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.f1lb1);
            this.Controls.Add(this.f1tb1);
            this.Controls.Add(this.f1cb1);
            this.Controls.Add(this.f1tb2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private newdb4eckDataSet4 newdb4eckDataSet4;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private newdb4eckDataSet4TableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem тарифToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОтчествуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПаспортуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТелефонуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобиляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поМаркеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поМоделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКлассуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУдостоверениюToolStripMenuItem;
        private System.Windows.Forms.TextBox f1tb2;
        private System.Windows.Forms.ComboBox f1cb1;
        private System.Windows.Forms.ComboBox f1tb1;
        private System.Windows.Forms.Label f1lb1;
        private newdb4eckDataSet13 newdb4eckDataSet13;
        private System.Windows.Forms.BindingSource тарифBindingSource;
        private newdb4eckDataSet13TableAdapters.ТарифTableAdapter тарифTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госНомерАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяЗаказасуткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn статусвыполненияDataGridViewCheckBoxColumn;
        private button1 Exitbtn1;
        private Button2 button21;
        private Button2 f1btn1;
    }
}

