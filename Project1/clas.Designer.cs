
namespace Project1
{
    partial class clas
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
            this.iDКлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet5 = new Project1.newdb4eckDataSet5();
            this.классTableAdapter = new Project1.newdb4eckDataSet5TableAdapters.КлассTableAdapter();
            this.newlbl = new System.Windows.Forms.Label();
            this.tbt3 = new System.Windows.Forms.ComboBox();
            this.tbt2 = new System.Windows.Forms.TextBox();
            this.tbt1 = new System.Windows.Forms.TextBox();
            this.addtrcb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button23 = new Project1.Button2();
            this.button22 = new Project1.Button2();
            this.button21 = new Project1.Button2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлассDataGridViewTextBoxColumn,
            this.классDataGridViewTextBoxColumn,
            this.наценкаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.классBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(349, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDКлассDataGridViewTextBoxColumn
            // 
            this.iDКлассDataGridViewTextBoxColumn.DataPropertyName = "ID_Класс";
            this.iDКлассDataGridViewTextBoxColumn.HeaderText = "ID_Класс";
            this.iDКлассDataGridViewTextBoxColumn.Name = "iDКлассDataGridViewTextBoxColumn";
            this.iDКлассDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // классDataGridViewTextBoxColumn
            // 
            this.классDataGridViewTextBoxColumn.DataPropertyName = "Класс";
            this.классDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.классDataGridViewTextBoxColumn.Name = "классDataGridViewTextBoxColumn";
            this.классDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наценкаDataGridViewTextBoxColumn
            // 
            this.наценкаDataGridViewTextBoxColumn.DataPropertyName = "Наценка";
            this.наценкаDataGridViewTextBoxColumn.HeaderText = "Наценка";
            this.наценкаDataGridViewTextBoxColumn.Name = "наценкаDataGridViewTextBoxColumn";
            this.наценкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // классBindingSource
            // 
            this.классBindingSource.DataMember = "Класс";
            this.классBindingSource.DataSource = this.newdb4eckDataSet5;
            // 
            // newdb4eckDataSet5
            // 
            this.newdb4eckDataSet5.DataSetName = "newdb4eckDataSet5";
            this.newdb4eckDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // классTableAdapter
            // 
            this.классTableAdapter.ClearBeforeFill = true;
            // 
            // newlbl
            // 
            this.newlbl.AutoSize = true;
            this.newlbl.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlbl.Location = new System.Drawing.Point(6, 164);
            this.newlbl.Name = "newlbl";
            this.newlbl.Size = new System.Drawing.Size(124, 20);
            this.newlbl.TabIndex = 7;
            this.newlbl.Text = "Удаление класса";
            // 
            // tbt3
            // 
            this.tbt3.DataSource = this.классBindingSource;
            this.tbt3.DisplayMember = "ID_Класс";
            this.tbt3.FormattingEnabled = true;
            this.tbt3.Location = new System.Drawing.Point(10, 248);
            this.tbt3.Name = "tbt3";
            this.tbt3.Size = new System.Drawing.Size(74, 21);
            this.tbt3.TabIndex = 20;
            // 
            // tbt2
            // 
            this.tbt2.Location = new System.Drawing.Point(238, 249);
            this.tbt2.Name = "tbt2";
            this.tbt2.Size = new System.Drawing.Size(110, 20);
            this.tbt2.TabIndex = 19;
            this.tbt2.Enter += new System.EventHandler(this.tbt2_Enter);
            this.tbt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbt2_KeyPress);
            this.tbt2.Leave += new System.EventHandler(this.tbt2_Leave);
            // 
            // tbt1
            // 
            this.tbt1.Location = new System.Drawing.Point(90, 249);
            this.tbt1.Name = "tbt1";
            this.tbt1.Size = new System.Drawing.Size(142, 20);
            this.tbt1.TabIndex = 18;
            this.tbt1.Enter += new System.EventHandler(this.tbt1_Enter);
            this.tbt1.Leave += new System.EventHandler(this.tbt1_Leave);
            // 
            // addtrcb1
            // 
            this.addtrcb1.DataSource = this.классBindingSource;
            this.addtrcb1.DisplayMember = "ID_Класс";
            this.addtrcb1.FormattingEnabled = true;
            this.addtrcb1.Location = new System.Drawing.Point(10, 187);
            this.addtrcb1.Name = "addtrcb1";
            this.addtrcb1.Size = new System.Drawing.Size(106, 21);
            this.addtrcb1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Изменение класса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Добавление класса";
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
            this.Exitbtn1.Location = new System.Drawing.Point(263, 305);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn1.TabIndex = 26;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.DimGray;
            this.button23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(12, 274);
            this.button23.Name = "button23";
            this.button23.Rounding = 40;
            this.button23.RoundingEnable = true;
            this.button23.Size = new System.Drawing.Size(327, 25);
            this.button23.TabIndex = 29;
            this.button23.Text = "Изменить класс";
            this.button23.TextHover = null;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DimGray;
            this.button22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(122, 183);
            this.button22.Name = "button22";
            this.button22.Rounding = 40;
            this.button22.RoundingEnable = true;
            this.button22.Size = new System.Drawing.Size(75, 25);
            this.button22.TabIndex = 30;
            this.button22.Text = "Удалить";
            this.button22.TextHover = null;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(203, 183);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(145, 25);
            this.button21.TabIndex = 31;
            this.button21.Text = "Добавить класс";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // clas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 337);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt3);
            this.Controls.Add(this.tbt2);
            this.Controls.Add(this.tbt1);
            this.Controls.Add(this.addtrcb1);
            this.Controls.Add(this.newlbl);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "clas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Класс";
            this.Load += new System.EventHandler(this.clas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private newdb4eckDataSet5 newdb4eckDataSet5;
        private System.Windows.Forms.BindingSource классBindingSource;
        private newdb4eckDataSet5TableAdapters.КлассTableAdapter классTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn классDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label newlbl;
        private System.Windows.Forms.ComboBox tbt3;
        private System.Windows.Forms.TextBox tbt2;
        private System.Windows.Forms.TextBox tbt1;
        private System.Windows.Forms.ComboBox addtrcb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private button1 Exitbtn1;
        private Button2 button23;
        private Button2 button22;
        private Button2 button21;
    }
}