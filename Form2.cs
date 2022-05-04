using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MpKurs1
{
    public partial class Add_Form : Form

    {
        DataBase database = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var ForName = textBox1.Text;
            var Pol = textBox2.Text;
            var NameOtdela = textBox3.Text;
            var DateOfBirth = textBox4.Text;
            var DateOfPostyp = textBox5.Text;
            var Position = textBox6.Text;
            int Oklad;

            if (int.TryParse(textBox7.Text, out Oklad)) 
            {
                var addQuery = $"insert into MpKyrsah_db (ForName, Pol, NameOtdela, DateOfBirth, DateOfPostyp, Position, Oklad) values('{ForName}', '{Pol}', '{NameOtdela}', '{DateOfBirth}', '{DateOfPostyp}', '{Position}', {Oklad})";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись внесена!","Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                database.closeConnection();
            }
        }
    }
}
