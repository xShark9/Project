using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form //ShadowedForm
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public Form1()
        {
            InitializeComponent();
            Animator.Start();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
            this.menuStrip1.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
            {
                x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
            });
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            automobil a1 = new automobil();
            this.Hide();
            a1.ShowDialog();
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connect.Close();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client c1 = new client();
            this.Hide();
            c1.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet13.Тариф". При необходимости она может быть перемещена или удалена.
            this.тарифTableAdapter.Fill(this.newdb4eckDataSet13.Тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet4.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.newdb4eckDataSet4.Заказы);
            f1tb1.Text = "";
            f1cb1.Text = "";
        }

        private void тарифToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tarif t1 = new tarif();
            this.Hide();
            t1.ShowDialog();
            this.Show();
        }

        private void классToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clas l1 = new clas();
            this.Hide();
            l1.ShowDialog();
            this.Show();
        }

        private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pspfam p1 = new pspfam();
            this.Hide();
            p1.ShowDialog();
            this.Show();
        }

        private void поИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pspim p2 = new pspim();
            this.Hide();
            p2.ShowDialog();
            this.Show();
        }

        private void поОтчествуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pspot p3 = new pspot();
            this.Hide();
            p3.ShowDialog();
            this.Show();
        }

        private void поПаспортуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            psppacs p4 = new psppacs();
            this.Hide();
            p4.ShowDialog();
            this.Show();
        }

        private void поТелефонуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            psptp p5 = new psptp();
            this.Hide();
            p5.ShowDialog();
            this.Show();
        }

        private void поУдостоверениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            psped p6 = new psped();
            this.Hide();
            p6.ShowDialog();
            this.Show();
        }

        private void поМаркеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pavpm p7 = new pavpm();
            this.Hide();
            p7.ShowDialog();
            this.Show();
        }

        private void поМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pavmod p8 = new pavmod();
            this.Hide();
            p8.ShowDialog();
            this.Show();
        }

        private void поКлассуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pavcl p9 = new pavcl();
            this.Hide();
            p9.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  
        private void f1tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            f1tb1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void f1cb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            f1cb1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void автомобилиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            opz1cs p9 = new opz1cs();
            this.Hide();
            p9.ShowDialog();
            this.Show();
        }

        private void f1btn1_Click_1(object sender, EventArgs e)
        {
            if ((f1tb1.Text.Equals("")))
                MessageBox.Show("Выберите id заказа!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if ((f1tb2.Text.Equals("")))
                MessageBox.Show("Введите время заказа!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if ((f1cb1.Text.Equals("")))
                MessageBox.Show("Выберите тариф заказа!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                int del1 = Convert.ToInt32(f1tb1.Text);
                string query = "UPDATE Заказы SET [Время заказа (сутки)] = '" + f1tb2.Text + "' WHERE ID_Заказа = " + del1;
                OleDbCommand command = new OleDbCommand(query, Connect);
                command.ExecuteNonQuery();
                string query1 = "UPDATE Заказы SET Тариф = '" + f1cb1.Text + "' WHERE ID_Заказа = " + del1;
                OleDbCommand command1 = new OleDbCommand(query1, Connect);
                command1.ExecuteNonQuery();
                f1tb1.Text = null;
                f1tb2.Text = null;
                f1cb1.Text = null;
                this.заказыTableAdapter.Fill(this.newdb4eckDataSet4.Заказы);
                MessageBox.Show("Заказ изменен");
                this.заказыTableAdapter.Fill(this.newdb4eckDataSet4.Заказы);
            }
        }
    }
}
