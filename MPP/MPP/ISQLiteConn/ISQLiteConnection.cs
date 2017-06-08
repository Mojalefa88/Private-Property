using SQLite.Net.Async;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP.ISQLiteConn
{
    public interface ISQLiteConnection
    {
        string GetDataBasePath();
        SQLiteAsyncConnection GetConnection();
    }
}
