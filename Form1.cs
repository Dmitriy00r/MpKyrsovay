using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using ExcelDataReader;


namespace MpKurs1
{
    enum RowState
    {
        Exicted, New, Modified, ModifiedNew, Deleted
    }
    public partial class Form11 : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        private string filename = string.Empty;
        private DataTableCollection tableCollection = null;
        public DataGridView Grid
        {
            get { return dataGridView1; }
        }
        public Form11()
        {
            InitializeComponent();
        }
        public void CreateColumns()
        {
            dataGridView1.Columns.Add("Number", "№");
            dataGridView1.Columns.Add("ForName", "Фамилия");
            dataGridView1.Columns.Add("Pol", "Пол");
            dataGridView1.Columns.Add("NameOtdela", "Название Отдела");
            dataGridView1.Columns.Add("DateOfBirth", "Дата рождения");
            dataGridView1.Columns.Add("DateOfPostyp", "Дата поступления на работу");
            dataGridView1.Columns.Add("Position", "Должность");
            dataGridView1.Columns.Add("Oklad", "Оклад");
            dataGridView1.Columns.Add("IsNew", string.Empty);
            
        }
        public void ClearDann()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
                
        }

        public void ReadSingleRow(DataGridView ds, IDataRecord record)
        {
            var pattern = "dd.MM.yyyy";
            var birthDate = record.GetDateTime(4).ToString(pattern);
            var postupDate = record.GetDateTime(5).ToString(pattern);
            ds.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), birthDate, postupDate, record.GetString(6), record.GetInt32(7), RowState.ModifiedNew);
        }
        public void RefreshDataGrid (DataGridView ds)
        {
            ds.Rows.Clear();
            string queryString = $"select * from MpKyrsah_db";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(ds, reader);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
            }
        }
        private void добавлениеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Form addfm = new Add_Form();
            addfm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearDann();
        }
        public void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string SearchD = $"select * from MpKyrsah_db where concat (Number, ForName, Pol, NameOtdela, DateOfBirth, DateOfPostyp, Position, Oklad) like '%" + textBox9.Text +"%'";
            SqlCommand com = new SqlCommand(SearchD, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        public void RemoveRow()
        {
            

            int Number = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[Number].Visible = false;
            if (dataGridView1.Rows[Number].Cells[0].Value.ToString()==string.Empty)
            {
                dataGridView1.Rows[Number].Cells[8].Value = RowState.Deleted;

                return;
            }
            dataGridView1.Rows[Number].Cells[8].Value = RowState.Deleted;
        }
        private void Updater()
        {
            dataBase.openConnection();
            for (int index=0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;
                if (rowState == RowState.Exicted)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var Number = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var delete = $"delete from MpKyrsah_db where Number = {Number} ";
                    var command = new SqlCommand(delete,dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var Number = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var ForName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var Pol = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var NameOtdela = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var DateOfBirth = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var DateOfPostyp = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var Position = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var Oklad = dataGridView1.Rows[index].Cells[7].Value.ToString();

                    var RedactQuery = $"update MpKyrsah_db set ForName = '{ForName}', Pol = '{Pol}', NameOtdela = '{NameOtdela}', DateOfBirth = '{DateOfBirth}', DateOfPostyp = '{DateOfPostyp}', Position = '{Position}', Oklad = '{Oklad}' where Number = '{Number}'";
                    var command = new SqlCommand(RedactQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RemoveRow();
            ClearDann();
        }


        private void Redact()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var Number = textBox1.Text;
            var ForName = textBox2.Text;
            var Pol = textBox3.Text;
            var NameOtdela = textBox4.Text;
            var DateOfBirth = textBox5.Text;
            var DateOfPostyp = textBox6.Text;
            var Position = textBox7.Text;
            int Oklad;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox8.Text,out Oklad))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(Number, ForName, Pol, NameOtdela, DateOfBirth, DateOfPostyp, Position, Oklad);
                    dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена указана на верно!");
                }
            }


    }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Updater();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Redact();
            ClearDann();
        }

        private void стажРаботыВсехСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            Form3 add = new Form3();
            add.Show();
            MessageBox.Show("Стаж отображается в днях");
        }

        public void среднийСтажРаботыСотрудниковЗаданногоОтделаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double SrednStag = 0;
            double result = 0;
            var amount = 1;
            
            for (var index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var DatePostyp = Convert.ToDateTime(dataGridView1.Rows[index].Cells[5].Value);
                var TimeNow = DateTime.Today;
                var StageWork = (TimeNow - DatePostyp).TotalDays;
                result += StageWork;
                SrednStag = Math.Round(result / amount);
                amount++;
            }

            MessageBox.Show("Средний стаж по заданному отделу= " + SrednStag);
        }
        public delegate void OkladWritting(int OkladWr);
        public void meta (int OkladWr)
        {
            int count = 0;
            for (var index = 0; index < dataGridView1.Rows.Count; index++)
            {
               var oklad = Convert.ToInt32(dataGridView1.Rows[index].Cells[7].Value);
                if (oklad < OkladWr)
                {
                    count++;
                }
            }
            MessageBox.Show("Сотрудников с окладом ниже заданного - "+ count);
        }

        public void количествоСотрудниковСОкладомНижеЗаданногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите требуемый оклад!");
            Form4 add = new Form4(new OkladWritting(meta));
            add.Show();
        }

        private void режимЗагрузкиДанныхИзСтороннегоФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    Text = filename;
                    OpenExcel(filename);
                }
                else
                {
                    throw new Exception("Выберите файл!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenExcel (string path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
            DataSet pov = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            tableCollection = pov.Tables;
            toolStripComboBox1.Items.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            foreach (DataTable tabe in tableCollection)
            {
                toolStripComboBox1.Items.Add(tabe.TableName);
            }
            toolStripComboBox1.SelectedIndex = 0;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];
            dataGridView1.DataSource = table;
        }
 
        public delegate void Stag(int stag, double moneyProc);
        
        public void RashetOklada(int stag, double moneyProc)
        {
            for (var index = 0; index < dataGridView1.Rows.Count;index++)
            {
             
                    var DatePostyp = Convert.ToDateTime(dataGridView1.Rows[index].Cells[5].Value);

                    var TimeNow = DateTime.Today;

                    var StageWork = (TimeNow - DatePostyp).TotalDays;
                    if (StageWork > stag)
                    {

                    var rez = (Convert.ToInt32(dataGridView1.Rows[index].Cells[7].Value));
                    double prover = moneyProc / 100;
                    var Okl = rez * (1 + prover);
                    dataGridView1.Rows[index].Cells[7].Value = Okl;
                    
                }
            }
            Updater();
            MessageBox.Show("Оклад увеличен на - " + moneyProc + " %");

        }

        private void увеличитьОкладЛицамСоСтажемРаботыВышеЗаданногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите на сколько хотите увеличить оклад");
            Form5 add = new Form5(new Stag (RashetOklada));
            add.Show();
        }
        private void сToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 add = new Form6();
            add.Show();
        }

        private void сохранениеДанныхВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                    ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                    ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                    ExcelApp.Cells[1, 1] = "Number";
                    ExcelApp.Cells[1, 2] = "ForName";
                    ExcelApp.Cells[1, 3] = "Pol";
                    ExcelApp.Cells[1, 4] = "NameOtdela";
                    ExcelApp.Cells[1, 5] = "DateOfBirth";
                    ExcelApp.Cells[1, 6] = "DateOfPostyp";
                    ExcelApp.Cells[1, 7] = "Position";
                    ExcelApp.Cells[1, 8] = "Oklad";

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    ExcelApp.AlertBeforeOverwriting = false;
                    ExcelWorkBook.SaveAs(@"D:\ResKurs\Test.xlsx");
                    ExcelApp.Quit();
                }
                catch (Exception )
                {
                    MessageBox.Show("Ошибка сохранения файла");
                }
            }
        }

        private void удалитьДанныеОСотрудникахПенсионногоВозрастаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Man = 65;
            var Woman = 60;

            for (var index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var pol = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
                string m;

                m = "Мужской";
                if (pol == m)
                {
                    var DateOfBirth = Convert.ToDateTime(dataGridView1.Rows[index].Cells[4].Value);
                    var Data = DateTime.Now.Year;
                    var age = (Data - DateOfBirth.Year);
                    if (DateTime.Now.Month < DateOfBirth.Month || DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day)
                    {
                        age--;
                    }
                    if (age >= Man)
                    {

                        dataGridView1.Rows[index].Visible = false;
                        if (dataGridView1.Rows[index].Index.ToString() == string.Empty)
                        {
                            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;

                    }
                }
                   
                string b;
                b = "Женский";
                if (pol == b)
                {
                    var DateOfBirth = Convert.ToDateTime(dataGridView1.Rows[index].Cells[4].Value);
                    var Data = DateTime.Now.Year;
                    var age = (Data - DateOfBirth.Year);
                    if (DateTime.Now.Month < DateOfBirth.Month || DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day)
                    {
                        age--;
                    }

                    if (age >= Woman)
                    {
                        dataGridView1.Rows[index].Visible = false;
                        if (dataGridView1.Rows[index].Index.ToString() == string.Empty)
                        {
                            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                    }
                }
               
            }

        }
    }
}
