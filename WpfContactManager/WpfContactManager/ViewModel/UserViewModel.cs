using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfContactManager.Model;

namespace WpfContactManager.ViewModel
{
    class UserViewModel
    {
         private IList<User1> _UsersList;
        public UserViewModel()
        {
            _UsersList = new List<User1>
            {
                new User1{UserId = 1,FirstName="Raj",LastName="Mukku",City="NewPaltz",State="NY",Country="USA"},
                new User1{UserId=2,FirstName="Mark",LastName="henry",City="New York", State="NY", Country="USA"},
                new User1{UserId=3,FirstName="Mahesh",LastName="Chand",City="Philadelphia", State="PHL", Country="USA"},
                new User1{UserId=4,FirstName="Vikash",LastName="Nanda",City="Noida", State="UP", Country="INDIA"},
                new User1{UserId=5,FirstName="Harsh",LastName="Kumar",City="Ghaziabad", State="UP", Country="INDIA"},
                new User1{UserId=6,FirstName="Aditya",LastName="Krishna",City="Mumbai", State="MP", Country="INDIA"},
                new User1{UserId=7,FirstName="Rakesh",LastName="Verma",City="Palwal", State="AP", Country="INDIA"},
                new User1{UserId=8,FirstName="Ravi",LastName="Teja",City="Delhi", State="DEL", Country="INDIA"}            
            };
        }
        public IList<User1> Users
        {
            get { return _UsersList; }
            set { _UsersList = value; }
        }
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
        private class Updater : ICommand
        {
            #region ICommand Members
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter)
            {
            }
            #endregion
        }

    }
}
