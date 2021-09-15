
namespace Project1
{
    partial class addtarif
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
            this.lbcl1 = new System.Windows.Forms.Label();
            this.addcltb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addcltb2 = new System.Windows.Forms.TextBox();
            this.egoldsFormStyle1 = new Project1.Components.EgoldsFormStyle(this.components);
            this.Exitbtn1 = new Project1.button1();
            this.button21 = new Project1.Button2();
            this.SuspendLayout();
            // 
            // newlbl
            // 
            this.newlbl.AutoSize = true;
            this.newlbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlbl.Location = new System.Drawing.Point(12, 9);
            this.newlbl.Name = "newlbl";
            this.newlbl.Size = new System.Drawing.Size(259, 25);
            this.newlbl.TabIndex = 2;
            this.newlbl.Text = "Форма добавления тарифа";
            // 
            // lbcl1
            // 
            this.lbcl1.AutoSize = true;
            this.lbcl1.Location = new System.Drawing.Point(35, 52);
            this.lbcl1.Name = "lbcl1";
            this.lbcl1.Size = new System.Drawing.Size(43, 13);
            this.lbcl1.TabIndex = 10;
            this.lbcl1.Text = "Тариф:";
            // 
            // addcltb1
            // 
            this.addcltb1.Location = new System.Drawing.Point(84, 49);
            this.addcltb1.Name = "addcltb1";
            this.addcltb1.Size = new System.Drawing.Size(171, 20);
            this.addcltb1.TabIndex = 9;
            this.addcltb1.Enter += new System.EventHandler(this.addcltb1_Enter);
            this.addcltb1.Leave += new System.EventHandler(this.addcltb1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Стоимость:";
            // 
            // addcltb2
            // 
            this.addcltb2.Location = new System.Drawing.Point(84, 75);
            this.addcltb2.Name = "addcltb2";
            this.addcltb2.Size = new System.Drawing.Size(171, 20);
            this.addcltb2.TabIndex = 11;
            this.addcltb2.Enter += new System.EventHandler(this.addcltb2_Enter);
            this.addcltb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addcltb2_KeyPress);
            this.addcltb2.Leave += new System.EventHandler(this.addcltb2_Leave);
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
            this.Exitbtn1.Location = new System.Drawing.Point(174, 129);
            this.Exitbtn1.Name = "Exitbtn1";
            this.Exitbtn1.Rounding = 40;
            this.Exitbtn1.RoundingEnable = true;
            this.Exitbtn1.Size = new System.Drawing.Size(97, 40);
            this.Exitbtn1.TabIndex = 26;
            this.Exitbtn1.Text = "Закрыть";
            this.Exitbtn1.TextHover = "";
            this.Exitbtn1.Click += new System.EventHandler(this.Exitbtn1_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DimGray;
            this.button21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(22, 129);
            this.button21.Name = "button21";
            this.button21.Rounding = 40;
            this.button21.RoundingEnable = true;
            this.button21.Size = new System.Drawing.Size(97, 40);
            this.button21.TabIndex = 27;
            this.button21.Text = "Добавить ";
            this.button21.TextHover = null;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // addtarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(290, 193);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Exitbtn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addcltb2);
            this.Controls.Add(this.lbcl1);
            this.Controls.Add(this.addcltb1);
            this.Controls.Add(this.newlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addtarif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тариф";
            this.Load += new System.EventHandler(this.addtarif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newlbl;
        private System.Windows.Forms.Label lbcl1;
        private System.Windows.Forms.TextBox addcltb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addcltb2;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private button1 Exitbtn1;
        private Button2 button21;
    }
}