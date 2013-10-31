using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DataLayer1;
using System.Windows;


namespace WpfApplication1
{
    public class MainWindowVM : BaseVM
    {
        private ObservableCollection<Book> myBook;
        public ObservableCollection<Book> MyBook
        {
            get { return myBook; }
            set
            {
                myBook = value;
                OnPropertyChanged("MyBook");
            }
        }
        private ObservableCollection<Campus> myCampus;
        public ObservableCollection<Campus> MyCampus
        {
            get { return myCampus; }
            set
            {
                myCampus = value;
                OnPropertyChanged("MyCampus");
            }
        }
        private ObservableCollection<Branch> myBranches;
        public ObservableCollection<Branch> MyBranches
        {
            get { return myBranches; }
            set
            {
                myBranches = value;
                OnPropertyChanged("MyBranches");
            }
        }
        //Constructor
        public MainWindowVM()
        {
            GetData();
        }

        public void GetData()
        {
            try
            {

                var db = new TabelContainer();
                this.MyBook = new ObservableCollection<Book>();
                var db2 = new TabelContainer();
                this.MyCampus = new ObservableCollection<Campus>();
                var campus = db2.Campus;
                foreach (var camp in campus)
                {
                    this.MyCampus.Add(camp);
                }

                var db3 = new TabelContainer();
                this.MyBranches = new ObservableCollection<Branch>();
                var branches = db3.Branches;
                foreach (var branch in branches)
                {
                    this.MyBranches.Add(branch);
                }



                //MyBook = db.Books.Local;
                //var books = MyBook.ToList();


                var books = db.Books;
                foreach (var book in books)
                {
                    this.MyBook.Add(book);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }


    }
    }


   /* public class CampusesVM : BaseVM
   {
       private ObservableCollection<Campus> myCampus;
       public ObservableCollection<Campus> MyCampus
       {
           get { return myCampus; }
           set
           {
               myCampus = value;
               OnPropertyChanged("MyCampus");
           }
       }

       //Constructor
       public CampusesVM()
       {
           OnData();
       }

       public void OnData()
       {
           try
           {

               var db = new TabelContainer();
               this.MyCampus = new ObservableCollection<Campus>();

               //MyBook = db.Books.Local;
               //var books = MyBook.ToList();


               var campus = db.Campus;
               foreach (var camp in campus)
               {
                   this.MyCampus.Add(camp);
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.StackTrace.ToString());
           }
       }

   }
}*/
/* public class CampusesVM : BaseVM
   {
       private ObservableCollection<Cars> myCars;
       public ObservableCollection<Cars> MyCars
       {
           get { return myCars; }
           set
           {
               myCampus = value;
               OnPropertyChanged("MyCars");
           }
       }

       //Constructor
       public CampusesVM()
       {
           OnData();
       }

       public void OnData()
       {
           try
           {

               var db3 = new TabelContainer();
               this.MyCars = new ObservableCollection<Cars>();

               //MyBook = db.Books.Local;
               //var books = MyBook.ToList();


               var car = db3.Cars;
               foreach (var car in cars)
               {
                   this.MyCars.Add(car);
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.StackTrace.ToString());
           }
       }
*/

