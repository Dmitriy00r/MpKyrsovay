using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MpKurs1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           Form1 kot = new Form1();
            dataGridView1.Columns.Add("Number", "№");
            dataGridView1.Columns.Add("ForName", "Фамилия");
            dataGridView1.Columns.Add("Pol", "Пол");
            dataGridView1.Columns.Add("NameOtdela", "Название Отдела");
            dataGridView1.Columns.Add("DateOfBirth", "Дата рождения");
            dataGridView1.Columns.Add("DateOfPostyp", "Дата поступления на работу");
            dataGridView1.Columns.Add("Position", "Должность");
            dataGridView1.Columns.Add("Oklad", "Оклад");
            dataGridView1.Columns.Add("Stag", "Стаж работы");
            kot.RefreshDataGrid(dataGridView1);
            for (var index = 0; index < dataGridView1.Rows.Count-1; index++)
            {
                var DatePostyp = Convert.ToDateTime(dataGridView1.Rows[index].Cells[5].Value);
                
                var TimeNow = DateTime.Today;

                var StageWork = (TimeNow - DatePostyp).TotalDays;

                
                
                dataGridView1.Rows[index].Cells[8].Value = StageWork;
                
            }


        }
    }
}
