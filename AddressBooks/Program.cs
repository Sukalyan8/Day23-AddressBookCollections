using System;

namespace AddressBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    AddressBooks.AddressBook.GetCustomer();
                    AddressBooks.AddressBook.ListingPeople();
                    break;
                case "2":
                    AddressBooks.AddressBook.GetCustomer();
                    AddressBooks.AddressBook.Modify();
                    AddressBooks.AddressBook.ListingPeople();
                    break;
                case "3":
                    AddressBooks.AddressBook.GetCustomer();
                    AddressBooks.AddressBook.ListingPeople();
                    break;
                case "4":
                    AddressBooks.AddressBook.GetCustomer();
                    AddressBooks.AddressBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }





        }
    }
}