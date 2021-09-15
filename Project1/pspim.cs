using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    public partial class pspim : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public pspim()
        {
            InitializeComponent();
        }

        private void pspim_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet3.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.newdb4eckDataSet3.Клиенты);
            pstb1.Text = "Введите имя клиента";
            pstb1.ForeColor = Color.Gray;
        }

        private void pstb1_Leave(object sender, EventArgs e)
        {
            if (pstb1.Text != string.Empty)
            {
                pstb1.Text = pstb1.Text;
            }
            else
            {
                pstb1.Text = "Введите фамилию клиента";
                pstb1.ForeColor = Color.Gray;
            }
        }

        private void pstb1_Enter(object sender, EventArgs e)
        {
            pstb1.Text = null;
            pstb1.ForeColor = Color.Black;
        }

        private void pstb1_KeyPress(object sender, KeyPressEventArgs e)
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
            Connect = new OleDbConnection(connectString);
            Connect.Open();
            string Name = pstb1.Text;
            string query = "SELECT * FROM Клиенты WHERE Имя LIKE '%" + Name + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connect);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            pstb1.Text = null;
            Connect.Close();
        }
    }
}
