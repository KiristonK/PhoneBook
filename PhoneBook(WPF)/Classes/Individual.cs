using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_WPF.Classes
{
    internal class Individual : PhoneBook
    {
        public Individual(string firstName, string lastName, string phoneNumber, string address) : base(firstName,
            lastName, phoneNumber, address) {}

        public override string ToString()
        {
            return $"\n[Individual]\n-First name : {FirstName}\n-Last Name : {LastName}\n-Phone Number : {PhoneNumber}\n-Address : {Address ?? "None"}\n";
        }

    }
}
