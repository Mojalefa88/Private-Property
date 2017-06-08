using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using MPP.ISQLiteConn;
using SQLite.Net.Async;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Dependency(typeof(MPP.Droid.DroidConn.SQLiteConnectionDroid))]
namespace MPP.Droid.DroidConn
{
    public class SQLiteConnectionDroid : ISQLiteConnection
    {
        private SQLiteAsyncConnection _connection;

        public string GetDataBasePath()
        {
            string filename = "MPP.db3";
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }

        public SQLiteAsyncConnection GetConnection()
        {
            if (_connection != null)
            {
                return _connection;
            }

            SQLiteConnectionWithLock connectioonWithLock =
            new SQLiteConnectionWithLock(new SQLitePlatformAndroid(), new SQLiteConnectionString(GetDataBasePath(), true));
            return _connection = new SQLiteAsyncConnection(() => connectioonWithLock);
        }
    }
}