
namespace Project1
{
    partial class pavpm
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
            this.pstb1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госномераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типкузоваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коробкапередачDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet11 = new Project1.newdb4eckDataSet11();
            this.автомобилиTableAdapter = new Project1.newdb4eckDataSet11TableAdapters.АвтомобилиTableAdapter();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск автомобиля по марке";
            // 
            // pstb1
            // 
            this.pstb1.Location = new System.Drawing.Point(199, 198);
            this.pstb1.Name = "pstb1";
            this.pstb1.Size = new System.Drawing.Size(174, 20);
            this.pstb1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Введите марку автомобиля:";
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
            this.dataGridView1.DataSource = this.автомобилиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 19;
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
            this.маркаDataGridViewTextBoxColumn.Width = 95;
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
            this.типкузоваDataGridViewTextBoxColumn.Width = 90;
            // 
            // коробкапередачDataGridViewTextBoxColumn
            // 
            this.коробкапередачDataGridViewTextBoxColumn.DataPropertyName = "Коробка_передач";
            this.коробкапередачDataGridViewTextBoxColumn.HeaderText = "Коробка передач";
            this.коробкапередачDataGridViewTextBoxColumn.Name = "коробкапередачDataGridViewTextBoxColumn";
            this.коробкапередачDataGridViewTextBoxColumn.ReadOnly = true;
            this.коробкапередачDataGridViewTextBoxColumn.Width = 65;
            // 
            // классDataGridViewTextBoxColumn
            // 
            this.классDataGridViewTextBoxColumn.DataPropertyName = "Класс";
            this.классDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.классDataGridViewTextBoxColumn.Name = "классDataGridViewTextBoxColumn";
            this.классDataGridViewTextBoxColumn.ReadOnly = true;
            this.классDataGridViewTextBoxColumn.Width = 80;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.newdb4eckDataSet11;
            // 
            // newdb4eckDataSet11
            // 
            this.newdb4eckDataSet11.DataSetName = "newdb4eckDataSet11";
            this.newdb4eckDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
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
            this.Exitbtn1.Location = new System.Drawing.Point(690, 224);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(92, 37);
            this.Exitbtn1.TabIndex = 32;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "Выйти";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(243, 223);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(89, 37);
            this.button21.TabIndex = 33;
            this.button21.Text = "Поиск";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // pavpm
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
            this.Name = "pavpm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.pavpm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox pstb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private newdb4eckDataSet11 newdb4eckDataSet11;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private newdb4eckDataSet11TableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госномераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типкузоваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коробкапередачDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn классDataGridViewTextBoxColumn;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private button1 Exitbtn1;
        private Button2 button21;
    }
}