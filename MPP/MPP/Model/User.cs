using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Model
{
   public class User
    {
        //[PrimaryKey, AutoIncrement]
        //public int ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }
        public string phone { get; set; }
        
        public string password { get; set; }
       
        public string confirmPassword { get; set; }
     
        public bool subscribe { get; set; }

        public string status { get; set; }
        public string reason { get; set; }
    }
}
