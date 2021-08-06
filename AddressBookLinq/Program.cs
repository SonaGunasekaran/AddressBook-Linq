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
            Console.WriteLine("1.Add Details\n2.Insert New Data");
            Console.WriteLine("Enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    repo.AddDetails();
                    break;
                case 2:
                    repo.InsertData();
                    break;
            }
            
        }
    }
}
