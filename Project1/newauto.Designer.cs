
namespace Project1
{
    partial class newauto
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
            this.newlbl = new System.Windows.Forms.Label();
            this.newbx1 = new System.Windows.Forms.TextBox();
            this.newbx2 = new System.Windows.Forms.TextBox();
            this.newbx3 = new System.Windows.Forms.TextBox();
            this.newcb5 = new System.Windows.Forms.ComboBox();
            this.newcb6 = new System.Windows.Forms.ComboBox();
            this.newcb7 = new System.Windows.Forms.ComboBox();
            this.newmtb4 = new System.Windows.Forms.MaskedTextBox();
            this.newdb4eckDataSet1 = new Project1.newdb4eckDataSet1();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter = new Project1.newdb4eckDataSet1TableAdapters.АвтомобилиTableAdapter();
            this.newdb4eckDataSet2 = new Project1.newdb4eckDataSet2();
            this.классBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.классTableAdapter = new Project1.newdb4eckDataSet2TableAdapters.КлассTableAdapter();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            this.egoldsFormStyle2 = new Project1.Components.EgoldsFormStyle(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newlbl
            // 
            this.newlbl.AutoSize = true;
            this.newlbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlbl.Location = new System.Drawing.Point(208, 9);
            this.newlbl.Name = "newlbl";
            this.newlbl.Size = new System.Drawing.Size(301, 25);
            this.newlbl.TabIndex = 0;
            this.newlbl.Text = "Форма добавления автомобиля";
            // 
            // newbx1
            // 
            this.newbx1.Location = new System.Drawing.Point(12, 62);
            this.newbx1.Name = "newbx1";
            this.newbx1.Size = new System.Drawing.Size(165, 20);
            this.newbx1.TabIndex = 5;
            this.newbx1.Enter += new System.EventHandler(this.newbx1_Enter);
            this.newbx1.Leave += new System.EventHandler(this.newbx1_Leave);
            // 
            // newbx2
            // 
            this.newbx2.Location = new System.Drawing.Point(200, 62);
            this.newbx2.Name = "newbx2";
            this.newbx2.Size = new System.Drawing.Size(165, 20);
            this.newbx2.TabIndex = 6;
            this.newbx2.Enter += new System.EventHandler(this.newbx2_Enter);
            this.newbx2.Leave += new System.EventHandler(this.newbx2_Leave);
            // 
            // newbx3
            // 
            this.newbx3.Location = new System.Drawing.Point(383, 62);
            this.newbx3.Name = "newbx3";
            this.newbx3.Size = new System.Drawing.Size(165, 20);
            this.newbx3.TabIndex = 8;
            this.newbx3.Enter += new System.EventHandler(this.newbx3_Enter);
            this.newbx3.Leave += new System.EventHandler(this.newbx3_Leave);
            // 
            // newcb5
            // 
            this.newcb5.FormattingEnabled = true;
            this.newcb5.Items.AddRange(new object[] {
            "Седан",
            "Хэтчбек",
            "Кроссовер",
            "Купе"});
            this.newcb5.Location = new System.Drawing.Point(56, 110);
            this.newcb5.Name = "newcb5";
            this.newcb5.Size = new System.Drawing.Size(121, 21);
            this.newcb5.TabIndex = 13;
            this.newcb5.Text = "Седан";
            this.newcb5.SelectedIndexChanged += new System.EventHandler(this.newcb5_SelectedIndexChanged);
            this.newcb5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newcb5_KeyPress);
            // 
            // newcb6
            // 
            this.newcb6.FormattingEnabled = true;
            this.newcb6.Items.AddRange(new object[] {
            "АКПП",
            "МКПП"});
            this.newcb6.Location = new System.Drawing.Point(292, 110);
            this.newcb6.Name = "newcb6";
            this.newcb6.Size = new System.Drawing.Size(121, 21);
            this.newcb6.TabIndex = 14;
            this.newcb6.Text = "АКПП";
            this.newcb6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newcb6_KeyPress);
            // 
            // newcb7
            // 
            this.newcb7.FormattingEnabled = true;
            this.newcb7.Items.AddRange(new object[] {
            "Эконом",
            "Комфорт",
            "Бизнес"});
            this.newcb7.Location = new System.Drawing.Point(533, 110);
            this.newcb7.Name = "newcb7";
            this.newcb7.Size = new System.Drawing.Size(121, 21);
            this.newcb7.TabIndex = 15;
            this.newcb7.Text = "Эконом";
            this.newcb7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newcb7_KeyPress);
            // 
            // newmtb4
            // 
            this.newmtb4.Location = new System.Drawing.Point(563, 62);
            this.newmtb4.Mask = "L000LL000";
            this.newmtb4.Name = "newmtb4";
            this.newmtb4.Size = new System.Drawing.Size(137, 20);
            this.newmtb4.TabIndex = 16;
            // 
            // newdb4eckDataSet1
            // 
            this.newdb4eckDataSet1.DataSetName = "newdb4eckDataSet1";
            this.newdb4eckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.newdb4eckDataSet1;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // newdb4eckDataSet2
            // 
            this.newdb4eckDataSet2.DataSetName = "newdb4eckDataSet2";
            this.newdb4eckDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // классBindingSource
            // 
            this.классBindingSource.DataMember = "Класс";
            this.классBindingSource.DataSource = this.newdb4eckDataSet2;
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
            this.Exitbtn1.Location = new System.Drawing.Point(608, 167);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(92, 36);
            this.Exitbtn1.TabIndex = 17;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(272, 167);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(161, 36);
            this.button21.TabIndex = 18;
            this.button21.Text = "Добавить автомобиль";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // egoldsFormStyle2
            // 
            this.egoldsFormStyle2.Form = null;
            this.egoldsFormStyle2.FormStyle = Project1.Components.EgoldsFormStyle.fStyle.None;
            // 
            // newauto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(712, 215);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.newmtb4);
            this.Controls.Add(this.newcb7);
            this.Controls.Add(this.newcb6);
            this.Controls.Add(this.newcb5);
            this.Controls.Add(this.newbx3);
            this.Controls.Add(this.newbx2);
            this.Controls.Add(this.newbx1);
            this.Controls.Add(this.newlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "newauto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить автомобиль";
            this.Load += new System.EventHandler(this.newauto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdb4eckDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.классBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newlbl;
        private System.Windows.Forms.TextBox newbx1;
        private System.Windows.Forms.TextBox newbx2;
        private System.Windows.Forms.TextBox newbx3;
        private System.Windows.Forms.ComboBox newcb5;
        private System.Windows.Forms.ComboBox newcb6;
        private System.Windows.Forms.ComboBox newcb7;
        private System.Windows.Forms.MaskedTextBox newmtb4;
        private newdb4eckDataSet1 newdb4eckDataSet1;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private newdb4eckDataSet1TableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private newdb4eckDataSet2 newdb4eckDataSet2;
        private System.Windows.Forms.BindingSource классBindingSource;
        private newdb4eckDataSet2TableAdapters.КлассTableAdapter классTableAdapter;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private button1 Exitbtn1;
        private Button2 button21;
        private Components.EgoldsFormStyle egoldsFormStyle2;
    }
}