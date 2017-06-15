using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课程设计Csharp
{
    public partial class Addrow : Form
    {
        public Addrow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.ToString();
            string str2 = textBox2.Text.ToString();
            string str3 = textBox3.Text.ToString();
            string str4 = textBox4.Text.ToString();

            string SQL = "insert into  contactinfo values(" + str1 + str2 + str3 + str4 + ");" ;

        }

        private void Addrow_Load(object sender, EventArgs e)
        {

        }
    }
}
