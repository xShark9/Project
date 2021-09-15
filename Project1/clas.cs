using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class clas : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public clas()
        {
            InitializeComponent();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }

        private void clas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet5.Класс". При необходимости она может быть перемещена или удалена.
            this.классTableAdapter.Fill(this.newdb4eckDataSet5.Класс);
            tbt1.Text = "Введите название класса";
            tbt1.ForeColor = Color.Gray;
            tbt2.Text = "Введите наценку";
            tbt2.ForeColor = Color.Gray;
        }

        private void addt1_Click(object sender, EventArgs e)
        {
            newcl c2 = new newcl();
            c2.Owner = this;
            c2.ShowDialog();
            this.классTableAdapter.Fill(this.newdb4eckDataSet5.Класс);
        }

        private void tbt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void tbt2_Leave(object sender, EventArgs e)
        {
            if (tbt2.Text != string.Empty)
            {
                tbt2.Text = tbt2.Text;
            }
            else
            {
                tbt2.Text = "Введите наценку";
                tbt2.ForeColor = Color.Gray;
            }
        }

        private void tbt2_Enter(object sender, EventArgs e)
        {
            tbt2.Text = null;
            tbt2.ForeColor = Color.Black;
        }

        private void tbt1_Leave(object sender, EventArgs e)
        {
            if (tbt1.Text != string.Empty)
            {
                tbt1.Text = tbt1.Text;
            }
            else
            {
                tbt1.Text = "Введите название класса";
                tbt1.ForeColor = Color.Gray;
            }
        }

        private void tbt1_Enter(object sender, EventArgs e)
        {
            tbt1.Text = null;
            tbt1.ForeColor = Color.Black;
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if ((tbt1.Text.Equals("")) || (tbt1.Text.Equals("Введите название класса")))
                MessageBox.Show("Введите новое название Класса!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if ((tbt2.Text.Equals("")) || (tbt2.Text.Equals("Введите наценку")))
                MessageBox.Show("Введите новую наценку!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                int del1 = Convert.ToInt32(tbt3.Text);
                string query = "UPDATE Класс SET Класс = '" + tbt1.Text + "' WHERE ID_Класс = " + del1;
                OleDbCommand command = new OleDbCommand(query, Connect);
                command.ExecuteNonQuery();
                string query1 = "UPDATE Класс SET Наценка = '" + tbt2.Text + "' WHERE ID_Класс = " + del1;
                OleDbCommand command1 = new OleDbCommand(query1, Connect);
                command1.ExecuteNonQuery();
                this.классTableAdapter.Fill(this.newdb4eckDataSet5.Класс);
                MessageBox.Show("Класс изменен");
                this.классTableAdapter.Fill(this.newdb4eckDataSet5.Класс);
                tbt1.Text = null;
                tbt2.Text = null;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int del = Convert.ToInt32(addtrcb1.Text);
            //string del = addtrcb1.Text;
            string query = "DELETE FROM Класс WHERE ID_Класс = " + del;
            OleDbCommand command = new OleDbCommand(query, Connect);
            command.ExecuteNonQuery();
            this.классTableAdapter.Fill(this.newdb4eckDataSet5.Класс);
            MessageBox.Show("Тариф удален");
            this.классTableAdapter.Fill(this.newdb4eckDataSet5.Класс);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            newcl c2 = new newcl();
            c2.Owner = this;
            c2.ShowDialog();
            this.классTableAdapter.Fill(this.newdb4eckDataSet5.Класс);
        }
    }
}
