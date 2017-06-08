using MPP.ISQLiteConn;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MPP.MainPage();
        }
        //  public App()
        //  {
        //      // The root page of your application
        //      ISQLiteConnection connection = DependencyService.Get<ISQLiteConnection>();

        //      if (connection.GetConnection() != nu`ll)
        //      {
        //          Debug.WriteLine("SQLite connection is ready!");
        //      }

        //      MainPage = new ContentPage
        //      {
        //          Content = new StackLayout
        //          {
        //              VerticalOptions = LayoutOptions.Center,
        //              Children = {
        //  new Label {
        //    HorizontalTextAlignment = TextAlignment.Center,
        //    Text = connection.GetDataBasePath()
        //  }
        //}
        //          }
        //      };
        //  }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
