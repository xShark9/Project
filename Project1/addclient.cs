using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class addclient : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public addclient()
        {
            InitializeComponent();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }

        private void addclient_Load(object sender, EventArgs e)
        {
            addcltb1.Text = "Введите фамилию клиента";
            addcltb1.ForeColor = Color.Gray;
            addcltb2.Text = "Введите имя клиента";
            addcltb2.ForeColor = Color.Gray;
            addcltb3.Text = "Введите отчество клиента";
            addcltb3.ForeColor = Color.Gray;
            addcltb4.Text = "00 00 0000";
            addcltb4.ForeColor = Color.Gray;
            addcltb5.Text = "00 00 0000";
            addcltb5.ForeColor = Color.Gray;
            addcltb6.Text = "(999) 000-00-00";
            addcltb6.ForeColor = Color.Gray;
        }

        private void addcltb1_Enter(object sender, EventArgs e)
        {
            addcltb1.Text = null;
            addcltb1.ForeColor = Color.Black;
        }

        private void addcltb2_Enter(object sender, EventArgs e)
        {
            addcltb2.Text = null;
            addcltb2.ForeColor = Color.Black;
        }

        private void addcltb3_Enter(object sender, EventArgs e)
        {
            addcltb3.Text = null;
            addcltb3.ForeColor = Color.Black;
        }

        private void addcltb4_Enter(object sender, EventArgs e)
        {
            addcltb4.Text = null;
            addcltb4.ForeColor = Color.Black;
        }

        private void addcltb5_Enter(object sender, EventArgs e)
        {
            addcltb5.Text = null;
            addcltb5.ForeColor = Color.Black;
        }

        private void addcltb6_Enter(object sender, EventArgs e)
        {
            addcltb6.Text = null;
            addcltb6.ForeColor = Color.Black;
        }

        private void addcltb1_Leave(object sender, EventArgs e)
        {
            if (addcltb1.Text != string.Empty)
            {
                addcltb1.Text = addcltb1.Text;
            }
            else
            {
                addcltb1.Text = "Введите фамилию клиента";
                addcltb1.ForeColor = Color.Gray;
            }
        }

        private void addcltb2_Leave(object sender, EventArgs e)
        {
            if (addcltb2.Text != string.Empty)
            {
                addcltb2.Text = addcltb2.Text;
            }
            else
            {
                addcltb2.Text = "Введите имя клиента";
                addcltb2.ForeColor = Color.Gray;
            }
        }
        private void addcltb3_Leave(object sender, EventArgs e)
        {
            if (addcltb3.Text != string.Empty)
            {
                addcltb3.Text = addcltb3.Text;
            }
            else
            {
                addcltb3.Text = "Введите отчество клиента";
                addcltb3.ForeColor = Color.Gray;
            }
        }

        private void addcltb4_Leave(object sender, EventArgs e)
        {
            if (addcltb4.Text != string.Empty)
            {
                addcltb4.Text = addcltb4.Text;
            }
            else
            {
                addcltb4.Text = "00 00 0000";
                addcltb4.ForeColor = Color.Gray;
            }
        }

        private void addcltb5_Leave(object sender, EventArgs e)
        {
            if (addcltb5.Text != string.Empty)
            {
                addcltb5.Text = addcltb5.Text;
            }
            else
            {
                addcltb5.Text = "00 00 0000";
                addcltb5.ForeColor = Color.Gray;
            }
        }

        private void addcltb6_Leave(object sender, EventArgs e)
        {
            if (addcltb6.Text != string.Empty)
            {
                addcltb6.Text = addcltb6.Text;
            }
            else
            {
                addcltb6.Text = "(999) 000-00-00";
                addcltb6.ForeColor = Color.Gray;
            }
        }
        private void addcltb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void addcltb6_Click(object sender, EventArgs e)
        {
            //addcltb6.Select(0, 0);
            //addcltb6.SelectionStart = 1;
        }

        private void addcltb5_Click(object sender, EventArgs e)
        {
            //addcltb5.Select(0, 0);
        }

        private void addcltb4_Click(object sender, EventArgs e)
        {
            //addcltb4.Select(0, 0);
        }

        private void addcltb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void addcltb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void addcltb6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void addcltb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void addcltb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
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
            string fam = addcltb1.Text;
            string name = addcltb2.Text;
            string otv = addcltb3.Text;
            string vodyd = addcltb4.Text;
            string pasp = addcltb5.Text;
            string nubmer = addcltb6.Text;
            string query = "INSERT INTO Клиенты (Фамилия, Имя, Отчество, Водительское_удостоверение, Паспорт, Телефон) VALUES ('" + fam + "','" + name + "','" + otv + "','" + vodyd + "','" + pasp + "','" + nubmer + "')";
            OleDbCommand command = new OleDbCommand(query, Connect);
            if ((addcltb1.Text.Equals("")) || (addcltb2.Text.Equals("")) || (addcltb3.Text.Equals("")) || (addcltb4.Text.Equals("__ __ ____")) || (addcltb5.Text.Equals("__ __ ____")) || (addcltb6.Text.Equals("(___) ___-__-__")) || (addcltb1.Text.Equals("Введите фамилию клиента")) || (addcltb2.Text.Equals("Введите имя клиента")) || (addcltb3.Text.Equals("Введите отчество клиента")) || (addcltb4.Text.Equals("00 00 0000")) || (addcltb5.Text.Equals("00 00 0000")) || (addcltb6.Text.Equals("(999) 000-00-00")))  /// проверка на заполненность
                MessageBox.Show("Вы заполнили не все поля!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Клиент добавлен");
                addcltb1.Text = null;
                addcltb2.Text = null;
                addcltb3.Text = null;
                addcltb4.Text = null;
                addcltb5.Text = null;
                addcltb6.Text = null;
            }
        }
    }
}
