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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public enum Pol
        {
            Мужской, Женский
        }

        private void Form6_Load(object sender, EventArgs e)
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
            dataGridView1.Columns.Add("Age", "Возраст");
            kot.RefreshDataGrid(dataGridView1);
            var Man = 65;
            var Woman = 60;
            for (var index=0;index<dataGridView1.Rows.Count;++index)
            {
                var pol = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
                string m;
                
                m= "Мужской";
                if (pol != m)
                {
                    goto Sr2;
                }
                else 
                {
                    var DateOfBirth = Convert.ToDateTime(dataGridView1.Rows[index].Cells[4].Value);
                    var Data = DateTime.Now.Year;
                    var age = (Data - DateOfBirth.Year);
                    if(DateTime.Now.Month<DateOfBirth.Month || DateTime.Now.Month==DateOfBirth.Month&&DateTime.Now.Day<DateOfBirth.Day)
                    {
                        age--;
                    }

                    dataGridView1.Rows[index].Cells[8].Value = age;
                    var result = Convert.ToInt32(dataGridView1.Rows[index].Cells[8].Value);
                    if (result>=Man)
                    {
                        dataGridView1.Rows[index].Cells[8].Value = age;
                    }
                    if (result < Man)
                    {
                        if (result != Man)
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
                           
                        }
                    }
                }
            Sr2:
                {
                    string b;
                    b = "Женский";
                    if (pol != b)
                    {
                        continue;
                    }
                    else
                    {
                        var DateOfBirth = Convert.ToDateTime(dataGridView1.Rows[index].Cells[4].Value);
                        var Data = DateTime.Now.Year;
                        var age = (Data - DateOfBirth.Year);
                        if (DateTime.Now.Month < DateOfBirth.Month || DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day)
                        {
                            age--;
                        }
                        dataGridView1.Rows[index].Cells[8].Value = age;
                        var res = Convert.ToInt32(dataGridView1.Rows[index].Cells[8].Value);
                        if (res >= Woman)
                        {
                            dataGridView1.Rows[index].Cells[8].Value = age;
                        }
                        if (res < Woman)
                        {
                            if (res != Woman)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
                            }
                        }
                    }
                }
  
            }
            
        }
    }
}
