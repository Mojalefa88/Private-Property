using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.Model
{
    class Category
    {
        [PrimaryKey, AutoIncrement]
        public int categoryID { get; set; }

        public string category { get; set; }
    }
}
