using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicContacts
{
   public class TodoVM:BaseVM
    {
       public TodoVM()
       {
           List = new ObservableCollection<String>();
       }
       private string _Text;
       public string Text
       {
           get { return _Text; }
           set {
               _Text = value;
               OnPropertyChanged("Text");
           }
    }
       public ObservalCollection<string> List { get; set;}
       public void

            public class BaseVM:INotifyPropertyChanged
    {
                public event PropertyChangedEventHandler PropertyChanged;
                public void OnPropertyChanged(string PropertyName)
                {
                    if(PropertyChanged !=null) PropertyChanged(this
}
