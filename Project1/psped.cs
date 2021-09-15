using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Project1
{
    public partial class psped : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public psped()
        {
            InitializeComponent();
        }

        private void psped_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.newdb4eckDataSet3.Клиенты);
        }

        private void pstb1_KeyPress(object sender, KeyPressEventArgs e)
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
            Connect = new OleDbConnection(connectString);
            Connect.Open();
            string vod = pstb1.Text;
            string query = "SELECT * FROM Клиенты WHERE Водительское_удостоверение LIKE '%" + vod + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connect);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            pstb1.Text = null;
            Connect.Close();
        }
    }
}
