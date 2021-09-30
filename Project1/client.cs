using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class client : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public client()
        {
            InitializeComponent();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }

        private void client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.newdb4eckDataSet3.Клиенты);
            cltxt1.Text = "Введите id клиента";
            cltxt1.ForeColor = Color.Gray;
        }

        private void cltxt1_Enter(object sender, EventArgs e)
        {
            cltxt1.Text = null;
            cltxt1.ForeColor = Color.Black;
        }

        private void cltxt1_Leave(object sender, EventArgs e)
        {
            if (cltxt1.Text != string.Empty)
            {
                cltxt1.Text = cltxt1.Text;
            }
            else
            {
                cltxt1.Text = "Введите id клиента";
                cltxt1.ForeColor = Color.Gray;
            }
        }

        private void cltxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            addclient c2 = new addclient();
            c2.Owner = this;
            c2.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            try
            {
   if ((cltxt1.Text.Equals("")) || (cltxt1.Text.Equals("Введите id клиента")))
                MessageBox.Show("Введите id клиента!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                int del = Convert.ToInt32(cltxt1.Text);
                string query = "DELETE FROM Клиенты WHERE ID_Клиент = " + del;
                OleDbCommand command = new OleDbCommand(query, Connect);
                command.ExecuteNonQuery();
                MessageBox.Show("Клиент удален");
                this.клиентыTableAdapter.Fill(this.newdb4eckDataSet3.Клиенты);
                cltxt1.Text = null;
            }
            }

            catch
            {
                MessageBox.Show("Не возможно удалить клиента, так как он участвует в заказе!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
         
        }
    }
}
