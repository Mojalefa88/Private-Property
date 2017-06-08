using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Model
{
    public class Property
    {
        [PrimaryKey, AutoIncrement]
        public int propertyID { get; set; }
        
        public string title { get; set; }
       
        public string Desc { get; set; }

        public int categoryID { get; set; }
       
        public double price { get; set; }

        public string location { get; set; }
        public string status { get; set; }

        public DateTime date { get; set; }
        public int userID { get; set; }

        public byte[] image { get; set; }
    }
}
