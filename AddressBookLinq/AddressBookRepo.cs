using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookLinq
{
    class AddressBookRepo
    {
        List<AddressBookDetails> details;
        
        public AddressBookRepo()
        {
            details = new List<AddressBookDetails>();
        }
        public void  AddDetails()
        {
            details.Add(new AddressBookDetails { ContactId = 1, AddressBookName = "Maanvi", FirstName = "Chandler", LastName = "Bing", Address = "Central Park", State = "Adol", City = "NewYork", ZipCode = 2435465, PhoneNumber = 2432135456, Email = "chan@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 2, AddressBookName = "VIP", FirstName = "Monica", LastName = "Buffay", Address = "Marilon", State = "Kindle", City = "NewJersy", ZipCode = 45678, PhoneNumber = 7987755445, Email = "mon@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 3, AddressBookName = "VIP", FirstName = "Joey", LastName = "Tribiani", Address = "MysticFalls", State = "Gago", City = "London", ZipCode = 34299, PhoneNumber = 543663763, Email = "joe@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 4, AddressBookName = "Maanvi", FirstName = "Damon", LastName = "Salvatore", Address = "Seattle", State = "Boredom", City = "Mexico", ZipCode = 424525, PhoneNumber = 87654543, Email = "damo@gmail.com" });
            details.Add(new AddressBookDetails { ContactId = 5, AddressBookName = "VIP", FirstName = "Rachel", LastName = "Green", Address = "Garland", State = "Disney", City = "Paris", ZipCode = 626101, PhoneNumber = 98766543, Email = "rach@gmail.com" });
            IterateMethod(details);
        }
        public void IterateMethod(List<AddressBookDetails> details)
        {
            foreach (AddressBookDetails d in details)
            {
                Console.WriteLine("Contact Id:{0}\tAddressBookpro Name:{1}\tFirstName{2}\tLastName:{3}\tAddress:{4}\tState:{5}\tCity:{6}\tZipCode:{7}\tPhoneNumber:{8}\tEmail:{9}\n",d.ContactId,d.AddressBookName,d.FirstName,d.LastName,d.Address,d.State,d.City,d.ZipCode,d.PhoneNumber,d.Email );
            }
        }
    }
}