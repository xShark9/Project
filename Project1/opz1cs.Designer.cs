
namespace Project1
{
    partial class opz1cs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госНомерАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяЗаказасуткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьтарифаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусвыполненияDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.итогоПоЗаказамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet12 = new Project1.newdb4eckDataSet12();
            this.итого_по_заказамTableAdapter = new Project1.newdb4eckDataSet12TableAdapters.Итого_по_заказамTableAdapter();
            this.closebtn1 = new System.Windows.Forms.Button();
            this.opzbtn1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.итогоПоЗаказамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаказаDataGridViewTextBoxColumn,
            this.паспортКлиентаDataGridViewTextBoxColumn,
            this.госНомерАвтомобиляDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.времяЗаказасуткиDataGridViewTextBoxColumn,
            this.стоимостьтарифаDataGridViewTextBoxColumn,
            this.наценкаDataGridViewTextBoxColumn,
            this.итогоDataGridViewTextBoxColumn,
            this.статусвыполненияDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.итогоПоЗаказамBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(954, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDЗаказаDataGridViewTextBoxColumn
            // 
            this.iDЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.HeaderText = "ID Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.Name = "iDЗаказаDataGridViewTextBoxColumn";
            this.iDЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // паспортКлиентаDataGridViewTextBoxColumn
            // 
            this.паспортКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Паспорт клиента";
            this.паспортКлиентаDataGridViewTextBoxColumn.HeaderText = "Паспорт клиента";
            this.паспортКлиентаDataGridViewTextBoxColumn.Name = "паспортКлиентаDataGridViewTextBoxColumn";
            this.паспортКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // госНомерАвтомобиляDataGridViewTextBoxColumn
            // 
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Гос номер автомобиля";
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Гос номер автомобиля";
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.Name = "госНомерАвтомобиляDataGridViewTextBoxColumn";
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            dataGridViewCellStyle1.Format = "d";
            this.датаЗаказаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            this.датаЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаЗаказаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // времяЗаказасуткиDataGridViewTextBoxColumn
            // 
            this.времяЗаказасуткиDataGridViewTextBoxColumn.DataPropertyName = "Время заказа (сутки)";
            this.времяЗаказасуткиDataGridViewTextBoxColumn.HeaderText = "Время заказа (сутки)";
            this.времяЗаказасуткиDataGridViewTextBoxColumn.Name = "времяЗаказасуткиDataGridViewTextBoxColumn";
            this.времяЗаказасуткиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьтарифаDataGridViewTextBoxColumn
            // 
            this.стоимостьтарифаDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_тарифа";
            dataGridViewCellStyle2.Format = "C1";
            dataGridViewCellStyle2.NullValue = null;
            this.стоимостьтарифаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.стоимостьтарифаDataGridViewTextBoxColumn.HeaderText = "Стоимость тарифа";
            this.стоимостьтарифаDataGridViewTextBoxColumn.Name = "стоимостьтарифаDataGridViewTextBoxColumn";
            this.стоимостьтарифаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наценкаDataGridViewTextBoxColumn
            // 
            this.наценкаDataGridViewTextBoxColumn.DataPropertyName = "Наценка";
            this.наценкаDataGridViewTextBoxColumn.HeaderText = "Наценка";
            this.наценкаDataGridViewTextBoxColumn.Name = "наценкаDataGridViewTextBoxColumn";
            this.наценкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // итогоDataGridViewTextBoxColumn
            // 
            this.итогоDataGridViewTextBoxColumn.DataPropertyName = "Итого";
            dataGridViewCellStyle3.Format = "C1";
            dataGridViewCellStyle3.NullValue = null;
            this.итогоDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.итогоDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.итогоDataGridViewTextBoxColumn.Name = "итогоDataGridViewTextBoxColumn";
            this.итогоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусвыполненияDataGridViewCheckBoxColumn
            // 
            this.статусвыполненияDataGridViewCheckBoxColumn.DataPropertyName = "Статус_выполнения";
            this.статусвыполненияDataGridViewCheckBoxColumn.HeaderText = "Статус выполнения";
            this.статусвыполненияDataGridViewCheckBoxColumn.Name = "статусвыполненияDataGridViewCheckBoxColumn";
            this.статусвыполненияDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // итогоПоЗаказамBindingSource
            // 
            this.итогоПоЗаказамBindingSource.DataMember = "Итого по заказам";
            this.итогоПоЗаказамBindingSource.DataSource = this.newdb4eckDataSet12;
            // 
            // newdb4eckDataSet12
            // 
            this.newdb4eckDataSet12.DataSetName = "newdb4eckDataSet12";
            this.newdb4eckDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // итого_по_заказамTableAdapter
            // 
            this.итого_по_заказамTableAdapter.ClearBeforeFill = true;
            // 
            // closebtn1
            // 
            this.closebtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.closebtn1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closebtn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.closebtn1.FlatAppearance.BorderSize = 5;
            this.closebtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closebtn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closebtn1.Location = new System.Drawing.Point(879, 351);
            this.closebtn1.Name = "closebtn1";
            this.closebtn1.Size = new System.Drawing.Size(89, 37);
            this.closebtn1.TabIndex = 1;
            this.closebtn1.Text = "Закрыть";
            this.closebtn1.UseVisualStyleBackColor = false;
            this.closebtn1.Click += new System.EventHandler(this.closebtn1_Click);
            // 
            // opzbtn1
            // 
            this.opzbtn1.Location = new System.Drawing.Point(676, 351);
            this.opzbtn1.Name = "opzbtn1";
            this.opzbtn1.Size = new System.Drawing.Size(122, 37);
            this.opzbtn1.TabIndex = 2;
            this.opzbtn1.Text = "Сохранить в excel ";
            this.opzbtn1.UseVisualStyleBackColor = true;
            this.opzbtn1.Click += new System.EventHandler(this.opzbtn1_Click);
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = Project1.Components.EgoldsFormStyle.fStyle.None;
            // 
            // opz1cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 404);
            this.Controls.Add(this.opzbtn1);
            this.Controls.Add(this.closebtn1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "opz1cs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по заказам";
            this.Load += new System.EventHandler(this.opz1cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.итогоПоЗаказамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private newdb4eckDataSet12 newdb4eckDataSet12;
        private System.Windows.Forms.BindingSource итогоПоЗаказамBindingSource;
        private newdb4eckDataSet12TableAdapters.Итого_по_заказамTableAdapter итого_по_заказамTableAdapter;
        private System.Windows.Forms.Button closebtn1;
        private System.Windows.Forms.Button opzbtn1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госНомерАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяЗаказасуткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьтарифаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn статусвыполненияDataGridViewCheckBoxColumn;
        private Components.EgoldsFormStyle egoldsFormStyle1;
    }
}