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
    public partial class Form5 : Form
    {
        Form1.Stag j;
        public Form5(Form1.Stag sender)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            j = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stag = Convert.ToInt32(textBox1.Text);
            double moneyProc = Convert.ToInt32(textBox2.Text);
            j(stag,moneyProc);
            Close();
        }
    }
}
