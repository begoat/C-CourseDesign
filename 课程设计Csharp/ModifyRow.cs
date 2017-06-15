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
    public partial class ModifyRow : Form
    {
        public ModifyRow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.ToString();
            string str2 = textBox2.Text.ToString();
            string str3 = textBox3.Text.ToString();
            string str4 = textBox4.Text.ToString();
            string str5 = textBox5.Text.ToString();

            string SQL_statement = "update contacttest set name = @newname, telnumber = @telnumber, classifier = @classifier, email = @email where name = @name;";
            SQL sql = new SQL();
            string[] paralist = { "@newname", "@telnumber", "@classifier", "@email", "@name" };
            string[] paravalue = { str2, str3, str4, str5, str1 };
            int row_affected = SQL.ExecuteOperate(SQL_statement, paralist, paravalue);
            if (row_affected < 1)
            {
                MessageBox.Show("操作失败！");
            }
            else
            {
                MessageBox.Show("操作成功！");
                this.Close();
            }

        }

        private void ModifyRow_Load(object sender, EventArgs e)
        {

        }
    }
}
