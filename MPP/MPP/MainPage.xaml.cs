using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MPP.MenuItems;
using MPP.Views.PropertyCategory;
using MPP.Views.Users;
using MPP.Views.Properties;
using MPP.Views.Home;

namespace MPP
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }
        public MainPage()
        {

            InitializeComponent();

            MenuList = new List<MasterPageItem>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var login = new MasterPageItem() { Title = "Login", TargetType = typeof(Login)};
            var register = new MasterPageItem() { Title = "Register", TargetType = typeof(Register)};
           // var PropertiesGroup = new MasterPageItem() { Title = "PROPERTY" };
            
            var forSale = new MasterPageItem() { Title = "Property For Sale", TargetType = typeof(PropertyForSale) };
            var toRent = new MasterPageItem() { Title = "Property To Rent", TargetType = typeof(PropertiesToRent)};
            var comSales= new MasterPageItem() { Title = "Commercial Sales", TargetType = typeof(CommercialSales)};
            var comRent = new MasterPageItem() { Title = "Commercial Rentals", TargetType = typeof(CommercialRentals) };
            var onShow = new MasterPageItem() { Title = "Property On Show", TargetType = typeof(PropertiesOnshow) };
            var development = new MasterPageItem() { Title = "Developments", TargetType =  typeof(NewDevelopments) };
            var bankProperties = new MasterPageItem() { Title = "Bank Properties", TargetType = typeof(BankProperties) };
           
            //var page2 = new MasterPageItem() { Title = "User Management", Icon = "itemIcon2.png", TargetType = typeof(ManageUsers) };
            //var page3 = new MasterPageItem() { Title = "Admin Management", Icon = "itemIcon2.png", TargetType = typeof(ManageAdmins) };
            //var page4 = new MasterPageItem() { Title = "Products", Icon = "itemIcon2.png", TargetType = typeof(ViewProducts) };
            //var page5 = new MasterPageItem() { Title = "Products Management", Icon = "burger.jpg", TargetType = typeof(ManageProducts) };




            // Adding menu items to menuList
            MenuList.Add(login);
            MenuList.Add(register);
            //MenuList.Add(PropertiesGroup);
            MenuList.Add(forSale);
            MenuList.Add(toRent);
            MenuList.Add(comSales);
            MenuList.Add(comRent);
            MenuList.Add(onShow);
            MenuList.Add(development);
            MenuList.Add(bankProperties);
            

            //MenuList.Add(page3);
            //MenuList.Add(page4);
            //MenuList.Add(page5);


            // Setting the list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Index)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
