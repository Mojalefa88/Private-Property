using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MPP.Views.PropertyCategory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageCategories : ContentPage
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddCategory());
        }
    }
}
