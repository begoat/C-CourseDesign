using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace 课程设计Csharp
{
    public partial class Contact : Form
    {

        public static SQL sql = new SQL();


        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            List <Account> accountlist = new List<Account>(20);
            //SQL sql = new SQL();
            string[] paralist = {"@classify"};
            string[] paravalue = { "A"};
            accountlist = SQL.ExecuteQuery("SELECT * FROM contacttest where classifier = @classify",paralist,paravalue);
            //foreach (Account i in accountlist)
            //{
            //   Console.WriteLine(i.ToString());
            //}
            
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Addrow addrow = new Addrow();
            addrow.Show();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            ModifyRow modifyrow = new ModifyRow();
            modifyrow.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteRow deleterow = new DeleteRow();
            deleterow.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
