using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Project1
{
    public partial class pavpm : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public pavpm()
        {
            InitializeComponent();
        }

        private void pavpm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet11.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet11.Автомобили);
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Connect = new OleDbConnection(connectString);
            Connect.Open();
            string mar = pstb1.Text;
            string query = "SELECT * FROM Автомобили WHERE Марка LIKE '%" + mar + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connect);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            Connect.Close();
        }
    }
}
