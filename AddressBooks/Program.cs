using System;

namespace AddressBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            AddressBook.GetCustomer();
            AddressBooks.AddressBook.Modify();
            AddressBook.ListingPeople();
        }
    }
}
