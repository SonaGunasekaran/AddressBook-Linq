using System;
using System.Collections.Generic;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Linq!");
            List<AddressBookDetails> details=new List<AddressBookDetails>();
            AddressBookRepo repo = new AddressBookRepo();
            repo.AddDetails();
            //repo.IterateMethod(details);

        }
    }
}
