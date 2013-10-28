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
   public class MainWindowVM:BaseVM
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

public class BaseVM : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName]string propertyName = null)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}
