using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class newauto : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public newauto()
        {
            InitializeComponent();
            Connect = new OleDbConnection(connectString);
            Connect.Open();
        }

        private void newcb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            newcb5.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void newcb6_KeyPress(object sender, KeyPressEventArgs e)
        {
            newcb6.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void newcb7_KeyPress(object sender, KeyPressEventArgs e)
        {
            newcb7.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void newauto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet2.Класс". При необходимости она может быть перемещена или удалена.
            this.классTableAdapter.Fill(this.newdb4eckDataSet2.Класс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet1.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet1.Автомобили);
            newbx1.Text = "Введите марку автомобиля";
            newbx1.ForeColor = Color.Gray;
            newbx2.Text = "Введите модель автомобиля";
            newbx2.ForeColor = Color.Gray;
            newbx3.Text = "Введите цвет автомобиля";
            newbx3.ForeColor = Color.Gray;
        }

        private void newbx1_Enter(object sender, EventArgs e)
        {
            newbx1.Text = null;
            newbx1.ForeColor = Color.Black;
        }

        private void newbx2_Enter(object sender, EventArgs e)
        {
            newbx2.Text = null;
            newbx2.ForeColor = Color.Black;
        }

        private void newbx3_Enter(object sender, EventArgs e)
        {
            newbx3.Text = null;
            newbx3.ForeColor = Color.Black;
        }

        private void newbx1_Leave(object sender, EventArgs e)
        {
            if (newbx1.Text != string.Empty)
            {
                newbx1.Text = newbx1.Text;
            }
            else
            {
                newbx1.Text = "Введите марку автомобиля";
                newbx1.ForeColor = Color.Gray;
            }
        }

        private void newbx2_Leave(object sender, EventArgs e)
        {
            if (newbx2.Text != string.Empty)
            {
                newbx2.Text = newbx2.Text;
            }
            else
            {
                newbx2.Text = "Введите модель автомобиля";
                newbx2.ForeColor = Color.Gray;
            }
        }

        private void newbx3_Leave(object sender, EventArgs e)
        {
            if (newbx3.Text != string.Empty)
            {
                newbx3.Text = newbx3.Text;
            }
            else
            {
                newbx3.Text = "Введите цвет автомобиля";
                newbx3.ForeColor = Color.Gray;
            }
        }

        private void newcb5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string marka = newbx1.Text;
            string model = newbx2.Text;
            string color = newbx3.Text;
            string nomer = newmtb4.Text;
            string kyzov = newcb5.Text;
            string korobka = newcb6.Text;
            string clas = newcb7.Text;
            string query = "INSERT INTO Автомобили (Марка, Модель, Цвет, Гос_номера, Тип_кузова, Коробка_передач, Класс) VALUES ('" + marka + "','" + model + "','" + color + "','" + nomer + "','" + kyzov + "','" + korobka + "','" + clas + "')";
            OleDbCommand command = new OleDbCommand(query, Connect);
            if ((newbx1.Text.Equals("")) || (newbx2.Text.Equals("")) || (newbx3.Text.Equals("")) || (newmtb4.Text.Equals("_________")) || (newbx1.Text.Equals("Введите марку автомобиля")) || (newbx2.Text.Equals("Введите модель автомобиля")) || (newbx3.Text.Equals("Введите цвет автомобиля")))  /// проверка на заполненность
                MessageBox.Show("Вы заполнили не все поля!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Автомобиль добавлен");
                this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet1.Автомобили);
                newbx1.Text = null;
                newbx2.Text = null;
                newbx3.Text = null;
                newmtb4.Text = null;
            }
        }
    }
}
