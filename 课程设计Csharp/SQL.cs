using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.Types;
using System.Data;
using System.Data.SqlClient;

namespace 课程设计Csharp
{
    public class SQL
    {
        // 考虑防止SQL 注入 SQL PAR
        // 数据库 column 中文 是要出问题的！
        public static List<Account> ExecuteQuery(string SQL, string [] paralist, string [] paravalue)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = null;
            Console.WriteLine("Start to ExecuteQuery");
            string myConnectionString = "server=begoat.cn;Uid=william;Pwd=123456;Database=contactinfo";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlCommand cmd = new MySqlCommand(SQL,conn);
            for (int i = 0; i<paralist.Length;i++)
            {
                cmd.Parameters.AddWithValue(paralist[i], paravalue[i]);
            }
            List<Account> accountlist = new List<Account>(20);
            
            MySqlDataReader reader = cmd.ExecuteReader();
            Account account = new Account();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                account.setinfo(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                accountlist.Add(account);
                Console.WriteLine("This is a demo connecting to the database");
            }
            conn.Close();
            return accountlist;
            
                int  rowCount = cmd.ExecuteNonQuery();
            if (rowCount < 1)
            {
                MessageBox.Show("操作失败");
                conn.Close();
                return accountlist;
            }
            else
            {
                MessageBox.Show("成功操作!");
                conn.Close();
                return accountlist;
            }
        }



        public static int ExecuteOperate(string SQL, string[] paralist, string[] paravalue)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = null;
            Console.WriteLine("Start to ExecuteOperate");
            string myConnectionString = "server=begoat.cn;Uid=william;Pwd=123456;Database=contactinfo";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            for (int i = 0; i < paralist.Length; i++)
            {
                cmd.Parameters.AddWithValue(paralist[i], paravalue[i]);
            }

            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount < 1)
            {
                conn.Close();
                return rowCount;
            }
            else
            {
                conn.Close();
                return rowCount;
            }

        }



    }
}
