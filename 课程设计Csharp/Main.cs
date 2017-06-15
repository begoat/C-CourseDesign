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
    public partial class Main : Form
    {

        public static Main f0 = null; //用来引用主窗口
        public Main()
        {
            InitializeComponent();
            f0 = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Enter Register Function");
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Enter Login Function");
            Login login = new Login();
            this.Hide();
            Main.f0.Hide();
            login.Show();
        }

        private void button_mainexit_Click(object sender, EventArgs e)
        {

        }
    }
}
