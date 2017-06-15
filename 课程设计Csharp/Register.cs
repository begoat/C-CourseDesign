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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Resister_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button_register_Click(object sender, EventArgs e)
        {


            String str1 = textBox1.Text.ToString();
            String str2 = textBox2.Text.ToString();
            String str3 = textBox3.Text.ToString();

            if (!str2.Equals(str3)) {
                MessageBox.Show("两次输入的密码不一样");
                return ;
            }

            // 查询数据库 对应 用户名 判断
            // 注册成功 

            if (true) {
                MessageBox.Show("注册成功");
                Main.f0.Show();
                this.Hide();
                this.Close(); 
            }

        }

        private void button_return_Click(object sender, EventArgs e)
        {

        }
    }
}
