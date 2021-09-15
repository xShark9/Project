
namespace Project1
{
    partial class pavcl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pstb1 = new System.Windows.Forms.ComboBox();
            this.классBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet8 = new Project1.newdb4eckDataSet8();
            this.newdb4eckDataSet6 = new Project1.newdb4eckDataSet6();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter = new Project1.newdb4eckDataSet6TableAdapters.АвтомобилиTableAdapter();
            this.классTableAdapter = new Project1.newdb4eckDataSet8TableAdapters.КлассTableAdapter();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            this.newdb4eckDataSet11 = new Project1.newdb4eckDataSet11();
            this.автомобилиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter1 = new Project1.newdb4eckDataSet11TableAdapters.АвтомобилиTableAdapter();
            this.iDАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госномераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типкузоваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коробкапередачDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск автомобиля по классу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Выберите класс:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАвтоDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn,
            this.госномераDataGridViewTextBoxColumn,
            this.типкузоваDataGridViewTextBoxColumn,
            this.коробкапередачDataGridViewTextBoxColumn,
            this.классDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автомобилиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // pstb1
            // 
            this.pstb1.DataSource = this.классBindingSource;
            this.pstb1.DisplayMember = "Класс";
            this.pstb1.FormattingEnabled = true;
            this.pstb1.Location = new System.Drawing.Point(131, 198);
            this.pstb1.Name = "pstb1";
            this.pstb1.Size = new System.Drawing.Size(161, 21);
            this.pstb1.TabIndex = 27;
            this.pstb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pstb1_KeyPress);
            // 
            // классBindingSource
            // 
            this.классBindingSource.DataMember = "Класс";
            this.классBindingSource.DataSource = this.newdb4eckDataSet8;
            // 
            // newdb4eckDataSet8
            // 
            this.newdb4eckDataSet8.DataSetName = "newdb4eckDataSet8";
            this.newdb4eckDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newdb4eckDataSet6
            // 
            this.newdb4eckDataSet6.DataSetName = "newdb4eckDataSet6";
            this.newdb4eckDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.newdb4eckDataSet6;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // классTableAdapter
            // 
            this.классTableAdapter.ClearBeforeFill = true;
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = Project1.Components.EgoldsFormStyle.fStyle.None;
            // 
            // Exitbtn1
            // 
            this.Exitbtn1.BackColor = System.Drawing.Color.DimGray;
            this.Exitbtn1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Exitbtn1.ForeColor = System.Drawing.Color.White;
            this.Exitbtn1.Location = new System.Drawing.Point(690, 225);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(92, 37);
            this.Exitbtn1.TabIndex = 30;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "Выйти";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(164, 225);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(89, 37);
            this.button21.TabIndex = 31;
            this.button21.Text = "Поиск";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // newdb4eckDataSet11
            // 
            this.newdb4eckDataSet11.DataSetName = "newdb4eckDataSet11";
            this.newdb4eckDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиBindingSource1
            // 
            this.автомобилиBindingSource1.DataMember = "Автомобили";
            this.автомобилиBindingSource1.DataSource = this.newdb4eckDataSet11;
            // 
            // автомобилиTableAdapter1
            // 
            this.автомобилиTableAdapter1.ClearBeforeFill = true;
            // 
            // iDАвтоDataGridViewTextBoxColumn
            // 
            this.iDАвтоDataGridViewTextBoxColumn.DataPropertyName = "ID_Авто";
            this.iDАвтоDataGridViewTextBoxColumn.HeaderText = "ID Авто";
            this.iDАвтоDataGridViewTextBoxColumn.Name = "iDАвтоDataGridViewTextBoxColumn";
            this.iDАвтоDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDАвтоDataGridViewTextBoxColumn.Width = 70;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            this.маркаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            this.цветDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            this.цветDataGridViewTextBoxColumn.ReadOnly = true;
            this.цветDataGridViewTextBoxColumn.Width = 90;
            // 
            // госномераDataGridViewTextBoxColumn
            // 
            this.госномераDataGridViewTextBoxColumn.DataPropertyName = "Гос_номера";
            this.госномераDataGridViewTextBoxColumn.HeaderText = "Гос номера";
            this.госномераDataGridViewTextBoxColumn.Name = "госномераDataGridViewTextBoxColumn";
            this.госномераDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типкузоваDataGridViewTextBoxColumn
            // 
            this.типкузоваDataGridViewTextBoxColumn.DataPropertyName = "Тип_кузова";
            this.типкузоваDataGridViewTextBoxColumn.HeaderText = "Тип кузова";
            this.типкузоваDataGridViewTextBoxColumn.Name = "типкузоваDataGridViewTextBoxColumn";
            this.типкузоваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // коробкапередачDataGridViewTextBoxColumn
            // 
            this.коробкапередачDataGridViewTextBoxColumn.DataPropertyName = "Коробка_передач";
            this.коробкапередачDataGridViewTextBoxColumn.HeaderText = "Коробка передач";
            this.коробкапередачDataGridViewTextBoxColumn.Name = "коробкапередачDataGridViewTextBoxColumn";
            this.коробкапередачDataGridViewTextBoxColumn.ReadOnly = true;
            this.коробкапередачDataGridViewTextBoxColumn.Width = 70;
            // 
            // классDataGridViewTextBoxColumn
            // 
            this.классDataGridViewTextBoxColumn.DataPropertyName = "Класс";
            this.классDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.классDataGridViewTextBoxColumn.Name = "классDataGridViewTextBoxColumn";
            this.классDataGridViewTextBoxColumn.ReadOnly = true;
            this.классDataGridViewTextBoxColumn.Width = 80;
            // 
            // pavcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 272);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.pstb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "pavcl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.pavcl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox pstb1;
        private newdb4eckDataSet6 newdb4eckDataSet6;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private newdb4eckDataSet6TableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private newdb4eckDataSet8 newdb4eckDataSet8;
        private System.Windows.Forms.BindingSource классBindingSource;
        private newdb4eckDataSet8TableAdapters.КлассTableAdapter классTableAdapter;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private button1 Exitbtn1;
        private Button2 button21;
        private newdb4eckDataSet11 newdb4eckDataSet11;
        private System.Windows.Forms.BindingSource автомобилиBindingSource1;
        private newdb4eckDataSet11TableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госномераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типкузоваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коробкапередачDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn классDataGridViewTextBoxColumn;
    }
}