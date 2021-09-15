
namespace Project1
{
    partial class tarif
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
            this.тарифBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addtrcb1 = new System.Windows.Forms.ComboBox();
            this.тарифBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet7 = new Project1.newdb4eckDataSet7();
            this.newlbl = new System.Windows.Forms.Label();
            this.тарифBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDТарифDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьтарифаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.тарифTableAdapter2 = new Project1.newdb4eckDataSet7TableAdapters.ТарифTableAdapter();
            this.tbt1 = new System.Windows.Forms.TextBox();
            this.tbt2 = new System.Windows.Forms.TextBox();
            this.tbt3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            this.button22 = new Project1.Button2();
            this.button23 = new Project1.Button2();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // тарифBindingSource
            // 
            this.тарифBindingSource.DataMember = "Тариф";
            // 
            // addtrcb1
            // 
            this.addtrcb1.DataSource = this.тарифBindingSource3;
            this.addtrcb1.DisplayMember = "ID_Тариф";
            this.addtrcb1.FormattingEnabled = true;
            this.addtrcb1.Location = new System.Drawing.Point(12, 177);
            this.addtrcb1.Name = "addtrcb1";
            this.addtrcb1.Size = new System.Drawing.Size(74, 21);
            this.addtrcb1.TabIndex = 5;
            this.addtrcb1.SelectedIndexChanged += new System.EventHandler(this.addtrcb1_SelectedIndexChanged);
            // 
            // тарифBindingSource3
            // 
            this.тарифBindingSource3.DataMember = "Тариф";
            this.тарифBindingSource3.DataSource = this.newdb4eckDataSet7;
            // 
            // newdb4eckDataSet7
            // 
            this.newdb4eckDataSet7.DataSetName = "newdb4eckDataSet7";
            this.newdb4eckDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newlbl
            // 
            this.newlbl.AutoSize = true;
            this.newlbl.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlbl.Location = new System.Drawing.Point(12, 154);
            this.newlbl.Name = "newlbl";
            this.newlbl.Size = new System.Drawing.Size(129, 20);
            this.newlbl.TabIndex = 6;
            this.newlbl.Text = "Удаление тарифа";
            // 
            // тарифBindingSource1
            // 
            this.тарифBindingSource1.DataMember = "Тариф";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТарифDataGridViewTextBoxColumn,
            this.тарифDataGridViewTextBoxColumn,
            this.стоимостьтарифаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.тарифBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(351, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // iDТарифDataGridViewTextBoxColumn
            // 
            this.iDТарифDataGridViewTextBoxColumn.DataPropertyName = "ID_Тариф";
            this.iDТарифDataGridViewTextBoxColumn.HeaderText = "ID Тариф";
            this.iDТарифDataGridViewTextBoxColumn.Name = "iDТарифDataGridViewTextBoxColumn";
            this.iDТарифDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТарифDataGridViewTextBoxColumn.Width = 80;
            // 
            // тарифDataGridViewTextBoxColumn
            // 
            this.тарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф";
            this.тарифDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.тарифDataGridViewTextBoxColumn.Name = "тарифDataGridViewTextBoxColumn";
            this.тарифDataGridViewTextBoxColumn.ReadOnly = true;
            this.тарифDataGridViewTextBoxColumn.Width = 120;
            // 
            // стоимостьтарифаDataGridViewTextBoxColumn
            // 
            this.стоимостьтарифаDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_тарифа";
            this.стоимостьтарифаDataGridViewTextBoxColumn.HeaderText = "Стоимость тарифа";
            this.стоимостьтарифаDataGridViewTextBoxColumn.Name = "стоимостьтарифаDataGridViewTextBoxColumn";
            this.стоимостьтарифаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // тарифTableAdapter2
            // 
            this.тарифTableAdapter2.ClearBeforeFill = true;
            // 
            // tbt1
            // 
            this.tbt1.Location = new System.Drawing.Point(78, 254);
            this.tbt1.Name = "tbt1";
            this.tbt1.Size = new System.Drawing.Size(142, 20);
            this.tbt1.TabIndex = 10;
            this.tbt1.Enter += new System.EventHandler(this.tbt1_Enter);
            this.tbt1.Leave += new System.EventHandler(this.tbt1_Leave);
            // 
            // tbt2
            // 
            this.tbt2.Location = new System.Drawing.Point(226, 254);
            this.tbt2.MaxLength = 4;
            this.tbt2.Name = "tbt2";
            this.tbt2.Size = new System.Drawing.Size(113, 20);
            this.tbt2.TabIndex = 11;
            this.tbt2.Enter += new System.EventHandler(this.tbt2_Enter);
            this.tbt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbt2_KeyPress);
            this.tbt2.Leave += new System.EventHandler(this.tbt2_Leave);
            // 
            // tbt3
            // 
            this.tbt3.DataSource = this.тарифBindingSource3;
            this.tbt3.DisplayMember = "ID_Тариф";
            this.tbt3.FormattingEnabled = true;
            this.tbt3.Location = new System.Drawing.Point(12, 253);
            this.tbt3.Name = "tbt3";
            this.tbt3.Size = new System.Drawing.Size(60, 21);
            this.tbt3.TabIndex = 12;
            this.tbt3.SelectedIndexChanged += new System.EventHandler(this.tbt3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Добавление тарифа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Изменение тарифа";
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
            this.Exitbtn1.Location = new System.Drawing.Point(264, 314);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn1.TabIndex = 25;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(183, 177);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(156, 25);
            this.button21.TabIndex = 26;
            this.button21.Text = "Добавить тариф";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DimGray;
            this.button22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(92, 177);
            this.button22.Name = "button22";
            this.button22.Rounding = 40;
            this.button22.RoundingEnable = true;
            this.button22.Size = new System.Drawing.Size(75, 25);
            this.button22.TabIndex = 27;
            this.button22.Text = "Удалить";
            this.button22.TextHover = null;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.DimGray;
            this.button23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(12, 280);
            this.button23.Name = "button23";
            this.button23.Rounding = 40;
            this.button23.RoundingEnable = true;
            this.button23.Size = new System.Drawing.Size(327, 25);
            this.button23.TabIndex = 28;
            this.button23.Text = "Изменить тариф";
            this.button23.TextHover = null;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // tarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(351, 349);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt3);
            this.Controls.Add(this.tbt2);
            this.Controls.Add(this.tbt1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newlbl);
            this.Controls.Add(this.addtrcb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "tarif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тариф";
            this.Load += new System.EventHandler(this.tarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private newdb4eckDataSet5 newdb4eckDataSet5;
        private System.Windows.Forms.BindingSource тарифBindingSource;
        private System.Windows.Forms.ComboBox addtrcb1;
        private System.Windows.Forms.Label newlbl;
        //private newdb4eckDataSet6 newdb4eckDataSet6;
        private System.Windows.Forms.BindingSource тарифBindingSource1;
        //private newdb4eckDataSet6TableAdapters.ТарифTableAdapter тарифTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource тарифBindingSource2;
        private newdb4eckDataSet7 newdb4eckDataSet7;
        private System.Windows.Forms.BindingSource тарифBindingSource3;
        private newdb4eckDataSet7TableAdapters.ТарифTableAdapter тарифTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТарифDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьтарифаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbt1;
        private System.Windows.Forms.TextBox tbt2;
        private System.Windows.Forms.ComboBox tbt3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private button1 Exitbtn1;
        private Button2 button21;
        private Button2 button22;
        private Button2 button23;
        //private Project1.newdb4eckDataSet7 newdb4eckDataSet7;
        //private Project1.newdb4eckDataSet7TableAdapters.ТарифTableAdapter тарифTableAdapter2;
    }
}