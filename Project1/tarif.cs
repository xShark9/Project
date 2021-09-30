using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project1
{
    public partial class tarif : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public tarif()
        {
            InitializeComponent();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }
        private void tarif_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet7.Тариф". При необходимости она может быть перемещена или удалена.
            this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
            tbt1.Text = "Введите название тарифа";
            tbt1.ForeColor = Color.Gray;
            tbt2.Text = "Введите стоимость";
            tbt2.ForeColor = Color.Gray;

        }
        private void exitt1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tbt3_TextChanged(object sender, EventArgs e)
        {

        }
        private void addt1_Click(object sender, EventArgs e)
        {
            addtarif t2 = new addtarif();
            t2.Owner = this;
            t2.ShowDialog();
            this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int del = Convert.ToInt32(addtrcb1.Text);
            //string del = addtrcb1.Text;
            string query = "DELETE FROM Тариф WHERE ID_Тариф = " + del;
            OleDbCommand command = new OleDbCommand(query, Connect);
            command.ExecuteNonQuery();
            this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
            MessageBox.Show("Тариф удален");
            this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
            
        }

        private void addtrcb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if ((addcltb1.Text.Equals("")) || (addcltb2.Text.Equals("")) || (addcltb1.Text.Equals("Введите название тарифа")) || (addcltb2.Text.Equals("Введите стоимость тарифа")))  /// проверка на заполненность
            //    MessageBox.Show("Вы заполнили не все поля!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void updt1_Click(object sender, EventArgs e)
        {
            if ((tbt1.Text.Equals("")) || (tbt1.Text.Equals("Введите название тарифа")))
                MessageBox.Show("Введите новое название тарифа!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if ((tbt2.Text.Equals("")) || (tbt2.Text.Equals("Введите стоимость")))
                MessageBox.Show("Введите новую стоимость!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                int del1 = Convert.ToInt32(tbt3.Text);
                string query = "UPDATE Тариф SET Тариф = '" + tbt1.Text + "' WHERE ID_Тариф = " + del1;
                OleDbCommand command = new OleDbCommand(query, Connect);
                command.ExecuteNonQuery();
                string query1 = "UPDATE Тариф SET Стоимость_тарифа = '" + tbt2.Text + "' WHERE ID_Тариф = " + del1;
                OleDbCommand command1 = new OleDbCommand(query1, Connect);
                command1.ExecuteNonQuery();
                this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
                MessageBox.Show("Тариф изменен");
                this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
            }        
        }

        private void tbt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void tbt3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void tbt1_Enter(object sender, EventArgs e)
        {
            tbt1.Text = null;
            tbt1.ForeColor = Color.Black;
        }

        private void tbt1_Leave(object sender, EventArgs e)
        {
            if (tbt1.Text != string.Empty)
            {
                tbt1.Text = tbt1.Text;
            }
            else
            {
                tbt1.Text = "Введите название тарифа";
                tbt1.ForeColor = Color.Gray;
            }
        }

        private void tbt2_Enter(object sender, EventArgs e)
        {
            tbt2.Text = null;
            tbt2.ForeColor = Color.Black;
        }

        private void tbt2_Leave(object sender, EventArgs e)
        {
            if (tbt2.Text != string.Empty)
            {
                tbt2.Text = tbt2.Text;
            }
            else
            {
                tbt2.Text = "Введите стоимость";
                tbt2.ForeColor = Color.Gray;
            }
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            addtarif t2 = new addtarif();
            t2.Owner = this;
            t2.ShowDialog();
            this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
        }

        private void button22_Click(object sender, EventArgs e)
        {

            try
            {
                int del = Convert.ToInt32(addtrcb1.Text);
                //string del = addtrcb1.Text;
                string query = "DELETE FROM Тариф WHERE ID_Тариф = " + del;
                OleDbCommand command = new OleDbCommand(query, Connect);
                command.ExecuteNonQuery();
                this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
                MessageBox.Show("Тариф удален");
                this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
            }
            catch
            {
                MessageBox.Show("Не возможно удалить тариф, так как он используется!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if ((tbt1.Text.Equals("")) || (tbt1.Text.Equals("Введите название тарифа")))
                MessageBox.Show("Введите новое название тарифа!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if ((tbt2.Text.Equals("")) || (tbt2.Text.Equals("Введите стоимость")))
                MessageBox.Show("Введите новую стоимость!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                int del1 = Convert.ToInt32(tbt3.Text);
                string query = "UPDATE Тариф SET Тариф = '" + tbt1.Text + "' WHERE ID_Тариф = " + del1;
                OleDbCommand command = new OleDbCommand(query, Connect);
                command.ExecuteNonQuery();
                string query1 = "UPDATE Тариф SET Стоимость_тарифа = '" + tbt2.Text + "' WHERE ID_Тариф = " + del1;
                OleDbCommand command1 = new OleDbCommand(query1, Connect);
                command1.ExecuteNonQuery();
                this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
                MessageBox.Show("Тариф изменен");
                this.тарифTableAdapter2.Fill(this.newdb4eckDataSet7.Тариф);
            }
        }
    }
}
