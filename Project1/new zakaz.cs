using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class new_zakaz : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public new_zakaz()
        {
            InitializeComponent();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }

        private void new_zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet7.Тариф". При необходимости она может быть перемещена или удалена.
            this.тарифTableAdapter.Fill(this.newdb4eckDataSet7.Тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.newdb4eckDataSet3.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet11.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet11.Автомобили);

            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            string auto = comboBox1.Text;
            string client = comboBox3.Text;
            string tarif = comboBox2.Text;
            string data = Convert.ToString(dateTimePicker1.Text);
            string vrzakaza = textBox1.Text;
            string query = "INSERT INTO Заказы ([Паспорт клиента],[Гос номер автомобиля],[Дата заказа],[Время заказа (сутки)],Тариф) VALUES ('" + client + "','" + auto + "','" + data + "','" + vrzakaza + "','" + tarif + "')";
            OleDbCommand command = new OleDbCommand(query, Connect);
            if ((comboBox1.Text.Equals("")) || (comboBox3.Text.Equals("")) || (comboBox2.Text.Equals("")) || (textBox1.Text.Equals("")) || (dateTimePicker1.Text.Equals("")))  /// проверка на заполненность
                MessageBox.Show("Вы заполнили не все поля!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Заказ добавлен");
            }
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
