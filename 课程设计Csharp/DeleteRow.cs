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
    public partial class DeleteRow : Form
    {
        public DeleteRow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.ToString();
            string SQL_statement = "delete from contacttest where name = @name;";

            SQL sql = new 课程设计Csharp.SQL();
            string[] paralist = { "name" };
            string[] paravalue = { str1 };
            int row_affected = SQL.ExecuteOperate(SQL_statement, paralist, paravalue);
            if (row_affected < 1)
            {
                MessageBox.Show("操作失败!");
            }
            else
            {
                MessageBox.Show("操作成功");
                this.Close();
            }



        }

        private void DeleteRow_Load(object sender, EventArgs e)
        {

        }
    }
}
