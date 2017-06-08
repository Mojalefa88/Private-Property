using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP.Model;
using MPP.Services;
using System.Runtime.CompilerServices;

namespace MPP.ViewModels
{
    public class UsersViewModel : INotifyPropertyChanged
    {

        private List<User> _usersList;

        public List<User> UsersList {
            get { return _usersList; }
            set
            {
                _usersList = value;
                 OnPropertyChanged();
            }
        }

       

        public UsersViewModel()
        {
            InitializeDataAsync();
        }
        
        private async Task InitializeDataAsync()
        {
            var userServices = new UserServices();
            UsersList = await userServices.GetUserAsync();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
