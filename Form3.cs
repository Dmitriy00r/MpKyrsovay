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

        public void StageTest(DateTime Postup,DateTime Now)
        {
            for (var index = 0; index < dataGridView1.Rows.Count; index++)
            {
                Postup = Convert.ToDateTime(dataGridView1.Rows[index].Cells[5].Value);

                Now = DateTime.Today;

                var StageWork = (Now - Postup).TotalDays;

                dataGridView1.Rows[index].Cells[8].Value = StageWork;

            }
        }
        public void Stage()
        {
            for (var index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var DatePostyp = Convert.ToDateTime(dataGridView1.Rows[index].Cells[5].Value);

                var TimeNow = DateTime.Today;

                var StageWork = (TimeNow - DatePostyp).TotalDays;

                dataGridView1.Rows[index].Cells[8].Value = StageWork;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           Form11 kot = new Form11();
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
              dataGridView1.AllowUserToAddRows = false;
            Stage();


        }
    }
}
