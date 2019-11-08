using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Lab5_WPF.Classes
{
    internal class Company : PhoneBook
    {
        public Company(string firstName, string lastName, string phoneNumber, string address, string nip,
            string  companyName) : base(firstName, lastName, phoneNumber, nip, companyName, address) { }

        public override string ToString()
        {
            return $"\n[Company]\n-First name : {FirstName}\n-Last Name : {LastName}\n-Phone Number : {PhoneNumber}\n-Company Name: {CompanyName}\n-Company NIP: {Nip}\n-Company Address : {Address ?? "None"}\n";
        }
    }
}
