using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Project1
{
    public partial class pavcl : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = newdb4eck.mdb";
        private OleDbConnection Connect;
        public pavcl()
        {
            InitializeComponent();
        }

        private void pavcl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet11.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter1.Fill(this.newdb4eckDataSet11.Автомобили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet8.Класс". При необходимости она может быть перемещена или удалена.
            this.классTableAdapter.Fill(this.newdb4eckDataSet8.Класс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet6.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this.newdb4eckDataSet6.Автомобили);
        }


        private void pstb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            pstb1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Connect = new OleDbConnection(connectString);
            Connect.Open();
            string mod = pstb1.Text;
            string query = "SELECT * FROM Автомобили WHERE Класс LIKE '%" + mod + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connect);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
