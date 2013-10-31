﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicContacts
{
    class ContactsVM: BaseVM
    {
        CSharpContext_DB;
        public ContactsVM()
        {
           var db = new CSharpContext();
            Contacts = db.Contacts.Local;
            db.Contacts.Load();
            AddCommand = new DelegateCommand(
                () => {
                    Contacts.Add(new ContactsVM { FirstName = this.FirstName });
                    FirstName = null;
                }
            () => !String.IsNullOrWhiteSpace(FirstName)
                );
            var db = new CSharpContext();
            Contacts = db.Contacts.Local;
            db.
        }
        private String _FirstName;
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public DelegateCommand AddCommand { get; private set; }
        public observableCollection<Contacts>Contacts {get; private set;}
    }
}
