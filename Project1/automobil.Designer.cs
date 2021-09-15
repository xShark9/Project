
namespace Project1
{
    partial class automobil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госномераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типкузоваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коробкапередачDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобилиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet1 = new Project1.newdb4eckDataSet();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet = new Project1.newdb4eckDataSet();
            this.автомобилиTableAdapter = new Project1.newdb4eckDataSetTableAdapters.АвтомобилиTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dellabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            this.button22 = new Project1.Button2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(823, 383);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDАвтоDataGridViewTextBoxColumn
            // 
            this.iDАвтоDataGridViewTextBoxColumn.DataPropertyName = "ID_Авто";
            this.iDАвтоDataGridViewTextBoxColumn.HeaderText = "ID Авто";
            this.iDАвтоDataGridViewTextBoxColumn.Name = "iDАвтоDataGridViewTextBoxColumn";
            this.iDАвтоDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDАвтоDataGridViewTextBoxColumn.Width = 80;
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
            this.коробкапередачDataGridViewTextBoxColumn.Width = 90;
            // 
            // классDataGridViewTextBoxColumn
            // 
            this.классDataGridViewTextBoxColumn.DataPropertyName = "Класс";
            this.классDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.классDataGridViewTextBoxColumn.Name = "классDataGridViewTextBoxColumn";
            this.классDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // автомобилиBindingSource1
            // 
            this.автомобилиBindingSource1.DataMember = "Автомобили";
            this.автомобилиBindingSource1.DataSource = this.newdb4eckDataSet1;
            // 
            // newdb4eckDataSet1
            // 
            this.newdb4eckDataSet1.DataSetName = "newdb4eckDataSet";
            this.newdb4eckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.newdb4eckDataSet;
            // 
            // newdb4eckDataSet
            // 
            this.newdb4eckDataSet.DataSetName = "newdb4eckDataSet";
            this.newdb4eckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 424);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dellabel
            // 
            this.dellabel.AutoSize = true;
            this.dellabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dellabel.Location = new System.Drawing.Point(24, 398);
            this.dellabel.Name = "dellabel";
            this.dellabel.Size = new System.Drawing.Size(175, 23);
            this.dellabel.TabIndex = 4;
            this.dellabel.Text = "Удалить автомобиль";
            this.dellabel.Click += new System.EventHandler(this.dellabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавить автомобиль";
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
            this.Exitbtn1.Location = new System.Drawing.Point(741, 458);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(94, 34);
            this.Exitbtn1.TabIndex = 12;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "Выйти";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(346, 458);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(139, 34);
            this.button21.TabIndex = 13;
            this.button21.Text = "Добавить";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DimGray;
            this.button22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(38, 458);
            this.button22.Name = "button22";
            this.button22.Rounding = 40;
            this.button22.RoundingEnable = true;
            this.button22.Size = new System.Drawing.Size(139, 34);
            this.button22.TabIndex = 14;
            this.button22.Text = "Удалить";
            this.button22.TextHover = null;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // automobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 504);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dellabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "automobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.automobil_FormClosing);
            this.Load += new System.EventHandler(this.automobil_Load);
            this.Enter += new System.EventHandler(this.automobil_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private newdb4eckDataSet newdb4eckDataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private newdb4eckDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dellabel;
        private newdb4eckDataSet newdb4eckDataSet1;
        private System.Windows.Forms.BindingSource автомобилиBindingSource1;
        private System.Windows.Forms.Label label1;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госномераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типкузоваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коробкапередачDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn классDataGridViewTextBoxColumn;
        private button1 Exitbtn1;
        private Button2 button21;
        private Button2 button22;
    }
}