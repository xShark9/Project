using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Project1
{
    public partial class opz1cs : Form
    {
        public opz1cs()
        {
            InitializeComponent();
        }
        private StringFormat SF = new StringFormat();
        
        private void opz1cs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newdb4eckDataSet12.Итого_по_заказам". При необходимости она может быть перемещена или удалена.
            this.итого_по_заказамTableAdapter.Fill(this.newdb4eckDataSet12.Итого_по_заказам);
        }

        private void closebtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void opzbtn1_Click(object sender, EventArgs e)
        {
            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
            DateTime dateTimeValue = DateTime.Now;
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Сохранить в Excel файл";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel files|*.xlsx";
            if ( saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Cells[1, 1].ColumnWidth = 12;
                ExcelApp.Cells[1, 2].ColumnWidth = 20;
                ExcelApp.Cells[1, 3].ColumnWidth = 20;
                ExcelApp.Cells[1, 4].ColumnWidth = 20;
                ExcelApp.Cells[1, 5].ColumnWidth = 23;
                ExcelApp.Cells[1, 6].ColumnWidth = 20;
                ExcelApp.Cells[1, 7].ColumnWidth = 10;
                ExcelApp.Cells[1, 8].ColumnWidth = 18;
                ExcelApp.Columns[6].Numberformat = "0 #,00 ₽";
                ExcelApp.Columns[7].Numberformat = "0,0";
                ExcelApp.Columns[8].Numberformat = "0 #,00 ₽";
                ExcelApp.Rows[1].Font.Bold = true;
                ExcelApp.Rows[1].HorizontalAlignment = HorizontalAlignment.Center;
                ExcelApp.get_Range("K11").Value = dateTimeValue;
                ExcelApp.get_Range("K11").NumberFormat = dtfi.ShortDatePattern;
                ExcelApp.get_Range("J11").Value = "Дата создания отчета: ";
                ExcelApp.get_Range("J11", "K11").Font.Bold = true;
                ExcelApp.get_Range("J11").ColumnWidth = 20;
                ExcelApp.Cells[1, 1] = "ID заказа";
            ExcelApp.Cells[1, 2] = "Паспорт клиента";
            ExcelApp.Cells[1, 3] = "Номер автомобиля";
            ExcelApp.Cells[1, 4] = "Дата заказа";
            ExcelApp.Cells[1, 5] = "Количество дней заказа";
            ExcelApp.Cells[1, 6] = "Стоимость тарифа";
            ExcelApp.Cells[1, 7] = "Наценка";
            ExcelApp.Cells[1, 8] = "Итого по заказу";
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                    ExcelApp.Cells.HorizontalAlignment = Excel.Constants.xlCenter;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                        ExcelApp.Cells.HorizontalAlignment = Excel.Constants.xlCenter;
                        ExcelApp.Cells[j + 2, i + 1] = dataGridView1[i, j].Value.ToString();
                }
            }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
                MessageBox.Show("Сохранено");
                //ExcelApp.Visible = false;
            }     
        }
    }
}

