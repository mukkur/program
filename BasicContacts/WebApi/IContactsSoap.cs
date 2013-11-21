using DataLayer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IContactsSoap" in both code and config file together.
    [ServiceContract]
    public interface IContactsSoap
    {
        [OperationContract]
       String DoWork();
        IEnumerable<Contact> GetContacts();
    }
}
