﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             //actb.Filter = Filter;
    }
 
    private bool Filter(object obj, string text)
    {
        XmlElement element = (XmlElement)obj;
        string CityName = 
		element.SelectSingleNode("City_name").InnerText.ToLower();
        if (CityName.Contains(text.ToLower())) return true;
        return false;
    }
 
    private void XmlDataProvider_DataChanged(object sender, EventArgs e)
    {
        //StatusLabel.Text = "Xml Data Loaded.";
    }
        }

    class ViewModel
    {
        private List<string> _WaitMessage = new List<string>() { "Please Wait..." };
        public IEnumerable WaitMessage { get { return _WaitMessage; } }

        private string _QueryText;
        public string QueryText
        {
            get { return _QueryText; }
            set
            {
                if (_QueryText != value)
                {
                    _QueryText = value;
                    OnPropertyChanged("QueryText");
                    _QueryCollection = null;
                    OnPropertyChanged("QueryCollection");
                }
            }
        }

        public IEnumerable _QueryCollection = null;
        public IEnumerable QueryCollection
        {
            get
            {
                QueryGoogle(QueryText);
                return _QueryCollection;
            }
        }

        private void QueryGoogle(string SearchTerm)
        {
            //string sanitized = HttpUtility.HtmlEncode(SearchTerm);
            string url = @"http://cs.newpaltz.edu/~plotkinm/2012Grad/Final/api/Cities.php" + sanitized;
            WebRequest httpWebRequest = HttpWebRequest.Create(url);
            var webResponse = httpWebRequest.GetResponse();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(webResponse.GetResponseStream());
            var result = xmlDoc.SelectNodes("//CompleteSuggestion");
            _QueryCollection = result;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public string sanitized { get; set; }
    }
}

    }



