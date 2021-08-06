using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AddressBookLinq
{
    public class AddressBookRepo
    {
        List<AddressBookDetails> details;

        public AddressBookRepo()
        {
            details = new List<AddressBookDetails>();
        }
        public List<AddressBookDetails> AddDetails()
        {
            details.Add(new AddressBookDetails { ContactId = 1, AddressBookName = "Maanvi", FirstName = "Chandler", LastName = "Bing", Address = "Central Park", State = "Adol", City = "NewYork", ZipCode = 2435465, PhoneNumber = 2432135456, Email = "chan@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 2, AddressBookName = "VIP", FirstName = "Monica", LastName = "Buffay", Address = "Marilon", State = "Kindle", City = "NewJersy", ZipCode = 45678, PhoneNumber = 7987755445, Email = "mon@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 3, AddressBookName = "VIP", FirstName = "Joey", LastName = "Tribiani", Address = "MysticFalls", State = "Gago", City = "London", ZipCode = 34299, PhoneNumber = 543663763, Email = "joe@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 4, AddressBookName = "Maanvi", FirstName = "Damon", LastName = "Salvatore", Address = "Seattle", State = "Boredom", City = "Mexico", ZipCode = 424525, PhoneNumber = 87654543, Email = "damo@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 5, AddressBookName = "VIP", FirstName = "Rachel", LastName = "Green", Address = "Garland", State = "Disney", City = "Paris", ZipCode = 626101, PhoneNumber = 98766543, Email = "rach@gmail.com" });
            return details;
        }
        public void IterateMethod(List<AddressBookDetails> details)
        {
            foreach (AddressBookDetails d in details)
            {
                Console.WriteLine("Contact Id:{0}\tAddressBookName:{1}\tFirstName:{2}\tLastName:{3}\tAddress:{4}\tState:{5}\tCity:{6}\tZipCode:{7}\tPhoneNumber:{8}\tEmail:{9}\n", d.ContactId, d.AddressBookName, d.FirstName, d.LastName, d.Address, d.State, d.City, d.ZipCode, d.PhoneNumber, d.Email);
            }
        }
        public int InsertData()
        {
            details.Add(new AddressBookDetails { ContactId = 6, AddressBookName = "Maanvi", FirstName = "Ross", LastName = "Kather", Address = "Dalren", State = "Atony", City = "Washington", ZipCode = 626123, PhoneNumber = 98787654121, Email = "ross@gmail.com" });
            IterateMethod(details);
            return details.Count;
        }
        public int EditDetails(int contactId, string firstName, double zipCode)
        {
            AddDetails();
            AddressBookDetails address = (from a in details where a.ContactId == contactId && a.FirstName.Equals(firstName) select a).First();
            if (address != null)
            {
                address.ZipCode = zipCode;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteDetails(string firstName)
        {
            AddDetails();
            AddressBookDetails address = (from a in details where a.FirstName.Equals( firstName )select a).First();
            if (address != null)
            {
                details.Remove(address); 
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string RetrieveOnCityOrState(string city, string state)
        {
            AddDetails();
            string result = "";
            var res = (from a in details where (a.City == city || a.State == state) select a).ToList();
            foreach (var r in res)
            {
                result += r.FirstName ;
            }
            return result;
        }
        public string CountOfAddressBook()
        {
            AddDetails();
            string result = "";
            var res = details.GroupBy(c => c.City).Select(c => new { ContactId = c.Key, count = c.Count() });
            foreach (var r in res)
            {
                result += "" + r.ContactId + " " + r.count + " ";
            }
            return result;
        }
        public string SortNameByCity(string city)
        {
            string result = "";
            var res = details.OrderBy(c => c.FirstName).Where(c => c.City == city).ToList();
            foreach (var r in res)
            {
                result += "" + r.FirstName + " ";
            }
            return result;
        }
    }
}