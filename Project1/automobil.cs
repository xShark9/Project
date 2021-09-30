using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class automobil : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public automobil()
        {
            InitializeComponent();
          
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }

        private void automobil_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet1.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet1.Автомобили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet.Автомобили);
            textBox1.Text = "Введите id авто";
            textBox1.ForeColor = Color.Gray;


        }

        private void automobil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connect.Close();
        }

        private void dellabel_Click(object sender, EventArgs e)
        {

        }

        private void automobil_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
            textBox1.Text = "Введите id авто";
            textBox1.ForeColor = Color.Gray;
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            newauto a2 = new newauto();
            a2.Owner = this;
            a2.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text.Equals("")) || (textBox1.Text.Equals("Введите id авто")))
                    MessageBox.Show("Введите id авто!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    int del = Convert.ToInt32(textBox1.Text);
                    string query = "DELETE FROM Автомобили WHERE ID_Авто = " + del;
                    OleDbCommand command = new OleDbCommand(query, Connect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Автомобиль удален");
                    this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet.Автомобили);
                    textBox1.Text = null;
                }
            }

            catch
            {
                MessageBox.Show("Не возможно удалить автомобиль, так как он участвует в заказе!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
           
        }
    }
}
