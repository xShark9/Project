
namespace Project1
{
    partial class client
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
            this.iDКлиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.водительскоеудостоверениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdb4eckDataSet3 = new Project1.newdb4eckDataSet3();
            this.клиентыTableAdapter = new Project1.newdb4eckDataSet3TableAdapters.КлиентыTableAdapter();
            this.delcl1 = new System.Windows.Forms.Label();
            this.cltxt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            this.button22 = new Project1.Button2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.водительскоеудостоверениеDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(731, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDКлиентDataGridViewTextBoxColumn
            // 
            this.iDКлиентDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.HeaderText = "ID Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.Name = "iDКлиентDataGridViewTextBoxColumn";
            this.iDКлиентDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКлиентDataGridViewTextBoxColumn.Width = 85;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // водительскоеудостоверениеDataGridViewTextBoxColumn
            // 
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.DataPropertyName = "Водительское_удостоверение";
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.HeaderText = "Водительское удостоверение";
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.Name = "водительскоеудостоверениеDataGridViewTextBoxColumn";
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            this.паспортDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.newdb4eckDataSet3;
            // 
            // newdb4eckDataSet3
            // 
            this.newdb4eckDataSet3.DataSetName = "newdb4eckDataSet3";
            this.newdb4eckDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // delcl1
            // 
            this.delcl1.AutoSize = true;
            this.delcl1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delcl1.Location = new System.Drawing.Point(39, 358);
            this.delcl1.Name = "delcl1";
            this.delcl1.Size = new System.Drawing.Size(145, 23);
            this.delcl1.TabIndex = 1;
            this.delcl1.Text = "Удалить клиента";
            // 
            // cltxt1
            // 
            this.cltxt1.Location = new System.Drawing.Point(33, 384);
            this.cltxt1.Name = "cltxt1";
            this.cltxt1.Size = new System.Drawing.Size(162, 20);
            this.cltxt1.TabIndex = 2;
            this.cltxt1.Enter += new System.EventHandler(this.cltxt1_Enter);
            this.cltxt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cltxt1_KeyPress);
            this.cltxt1.Leave += new System.EventHandler(this.cltxt1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавить клиента";
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
            this.Exitbtn1.Location = new System.Drawing.Point(625, 414);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(94, 34);
            this.Exitbtn1.TabIndex = 13;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "Выйти";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(303, 410);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(139, 34);
            this.button21.TabIndex = 14;
            this.button21.Text = "Добавить";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DimGray;
            this.button22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(43, 410);
            this.button22.Name = "button22";
            this.button22.Rounding = 40;
            this.button22.RoundingEnable = true;
            this.button22.Size = new System.Drawing.Size(139, 34);
            this.button22.TabIndex = 15;
            this.button22.Text = "Удалить";
            this.button22.TextHover = null;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(756, 460);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cltxt1);
            this.Controls.Add(this.delcl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private newdb4eckDataSet3 newdb4eckDataSet3;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private newdb4eckDataSet3TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.Label delcl1;
        private System.Windows.Forms.TextBox cltxt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn водительскоеудостоверениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private button1 Exitbtn1;
        private Button2 button21;
        private Button2 button22;
    }
}