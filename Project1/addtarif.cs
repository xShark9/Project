using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class addtarif : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public addtarif()
        {
            InitializeComponent();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }

        private void addtarif_Load(object sender, EventArgs e)
        {
            addcltb1.Text = "Введите название тарифа";
            addcltb1.ForeColor = Color.Gray;
            addcltb2.Text = "Введите стоимость тарифа";
            addcltb2.ForeColor = Color.Gray;
        }

        private void addcltb1_Enter(object sender, EventArgs e)
        {
            addcltb1.Text = null;
            addcltb1.ForeColor = Color.Black;
        }

        private void addcltb1_Leave(object sender, EventArgs e)
        {
            if (addcltb1.Text != string.Empty)
            {
                addcltb1.Text = addcltb1.Text;
            }
            else
            {
                addcltb1.Text = "Введите название тарифа";
                addcltb1.ForeColor = Color.Gray;
            }
        }
        private void addcltb2_Enter(object sender, EventArgs e)
        {
            addcltb2.Text = null;
            addcltb2.ForeColor = Color.Black;
        }

        private void addcltb2_Leave(object sender, EventArgs e)
        {
            if (addcltb2.Text != string.Empty)
            {
                addcltb2.Text = addcltb2.Text;
            }
            else
            {
                addcltb2.Text = "Введите стоимость тарифа";
                addcltb2.ForeColor = Color.Gray;
            }
        }

        private void addcltb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string tar = addcltb1.Text;
            string cost = addcltb2.Text;
            string query = "INSERT INTO Тариф (Тариф, Стоимость_тарифа) VALUES ('" + tar + "','" + cost + "')";
            OleDbCommand command = new OleDbCommand(query, Connect);
            if ((addcltb1.Text.Equals("")) || (addcltb2.Text.Equals("")) || (addcltb1.Text.Equals("Введите название тарифа")) || (addcltb2.Text.Equals("Введите стоимость тарифа")))  /// проверка на заполненность
                MessageBox.Show("Вы заполнили не все поля!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Тариф добавлен");
                addcltb1.Text = null;
                addcltb2.Text = null;
                Close();
            }
        }
    }
}
