using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ContactsSoap" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ContactsSoap.svc or ContactsSoap.svc.cs at the Solution Explorer and start debugging.
    public class ContactsSoap : IContactsSoap
    {
        public String DoWork()
        {
            return "Hello world";
        }
        public IEnumerable<Contact> GetContacts()
        {
            var db = new CSharpContext();
            return db.Contacts.ToList();
        }
    }
}
