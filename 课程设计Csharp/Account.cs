using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 课程设计Csharp
{
    public class Account
    {
        private string name = "";
        private string telnumber = "";
        private string classifier = "";
        private string email = "";

        public string ToString()
        {
            return "name:"+name+" telnumber:"+telnumber+" classifier:"+classifier+" email:"+email;

        }
        public void setinfo(string name,string telnumber, string classifier, string email)
        {
            this.name = name;
            this.telnumber = telnumber;
            this.classifier = classifier;
            this.email = email;
        }

    }
}
