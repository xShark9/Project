using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Project1
{
    public partial class pavmod : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public pavmod()
        {
            InitializeComponent();
        }

        private void pavmod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet10.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter1.Fill(this.newdb4eckDataSet10.Автомобили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet9.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet9.Автомобили);
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Connect = new OleDbConnection(connectString);
            Connect.Open();
            string clas = pstb1.Text;
            string query = "SELECT * FROM Автомобили WHERE Модель LIKE '%" + clas + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connect);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            Connect.Close();
        }
    }
}
