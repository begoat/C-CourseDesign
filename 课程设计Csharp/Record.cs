using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 课程设计Csharp
{
    public class Record
    {
        public string name = "";
        public string telnumber = "";
        public string classifier = "";
        public string email = "";

        public string returninfo()
        {
            string returnstring = "name = " + name + " telnumber = " + telnumber + " classifier = " + classifier + " email = " + email;
            return returnstring;
        }
        public void setinfo() { }



    }
}
