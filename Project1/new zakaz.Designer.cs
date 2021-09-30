
namespace Project1
{
    partial class new_zakaz
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
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.newdb4eckDataSet11 = new Project1.newdb4eckDataSet11();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter = new Project1.newdb4eckDataSet11TableAdapters.АвтомобилиTableAdapter();
            this.newdb4eckDataSet3 = new Project1.newdb4eckDataSet3();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Project1.newdb4eckDataSet3TableAdapters.КлиентыTableAdapter();
            this.newdb4eckDataSet7 = new Project1.newdb4eckDataSet7();
            this.тарифBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тарифTableAdapter = new Project1.newdb4eckDataSet7TableAdapters.ТарифTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = Project1.Components.EgoldsFormStyle.fStyle.None;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.автомобилиBindingSource;
            this.comboBox1.DisplayMember = "Гос_номера";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.тарифBindingSource;
            this.comboBox2.DisplayMember = "Тариф";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.клиентыBindingSource;
            this.comboBox3.DisplayMember = "Паспорт";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(152, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            // 
            // newdb4eckDataSet11
            // 
            this.newdb4eckDataSet11.DataSetName = "newdb4eckDataSet11";
            this.newdb4eckDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.newdb4eckDataSet11;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // newdb4eckDataSet3
            // 
            this.newdb4eckDataSet3.DataSetName = "newdb4eckDataSet3";
            this.newdb4eckDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.newdb4eckDataSet3;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // newdb4eckDataSet7
            // 
            this.newdb4eckDataSet7.DataSetName = "newdb4eckDataSet7";
            this.newdb4eckDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тарифBindingSource
            // 
            this.тарифBindingSource.DataMember = "Тариф";
            this.тарифBindingSource.DataSource = this.newdb4eckDataSet7;
            // 
            // тарифTableAdapter
            // 
            this.тарифTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 6;
            // 
            // newlbl
            // 
            this.newlbl.AutoSize = true;
            this.newlbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlbl.Location = new System.Drawing.Point(74, 9);
            this.newlbl.Name = "newlbl";
            this.newlbl.Size = new System.Drawing.Size(252, 25);
            this.newlbl.TabIndex = 8;
            this.newlbl.Text = "Форма добавления заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите автомобиль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Выберите тариф:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Выберите дату:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Введите время заказа:";
            // 
            // Exitbtn1
            // 
            this.Exitbtn1.BackColor = System.Drawing.Color.DimGray;
            this.Exitbtn1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Exitbtn1.ForeColor = System.Drawing.Color.White;
            this.Exitbtn1.Location = new System.Drawing.Point(275, 288);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(97, 40);
            this.Exitbtn1.TabIndex = 27;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(25, 288);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(97, 40);
            this.button21.TabIndex = 28;
            this.button21.Text = "Добавить ";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // new_zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 340);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newlbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "new_zakaz";
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.new_zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private newdb4eckDataSet11 newdb4eckDataSet11;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private newdb4eckDataSet11TableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private newdb4eckDataSet3 newdb4eckDataSet3;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private newdb4eckDataSet3TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private newdb4eckDataSet7 newdb4eckDataSet7;
        private System.Windows.Forms.BindingSource тарифBindingSource;
        private newdb4eckDataSet7TableAdapters.ТарифTableAdapter тарифTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newlbl;
        private button1 Exitbtn1;
        private Button2 button21;
    }
}