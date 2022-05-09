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
    public partial class Form4 : Form
    {
        Form11.OkladWritting k;
        public Form4(Form11.OkladWritting sender)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            k = sender;
        }


        private void Ввод_Click(object sender, EventArgs e)
        {
            
           var OkladWr = Convert.ToInt32(textBox1.Text);
            k(OkladWr);
            
        }
    }
}
