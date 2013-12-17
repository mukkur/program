using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfFinal
{
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
