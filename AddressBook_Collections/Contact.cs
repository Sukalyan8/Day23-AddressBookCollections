using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_Collections
{
    class Contact
    {
        //variables
        string first_name;
        string last_name;
        string address;
        string city;
        string state;
        int zip;
        long phone;
        string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public Contact(string first_name, string last_name, string address, string city, string state, int zip, long phone, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }
    }
}