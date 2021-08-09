using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookLinq
{
    public class AddressBookDetails
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public double ZipCode { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressBookName { get; set; }
        public string AddressBookType { get; set; }
    }
}
