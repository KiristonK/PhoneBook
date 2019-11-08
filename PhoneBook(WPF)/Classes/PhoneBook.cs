using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Lab5_WPF.Classes
{
    public class PhoneBook
    {
        public static List<PhoneBook> Book { get; } = new List<PhoneBook>();

        protected string FirstName { get; }
        protected string LastName { get; }
        public int PhoneNumber { get; protected set; }
        protected string Address { get;  }
        protected int Nip { get; }
        protected string CompanyName { get; }

        protected PhoneBook(string firstName, string lastName, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address == "" ? "None" : address;
            PhoneNumber = int.Parse(phoneNumber);
        }

        protected PhoneBook(string firstName, string lastName, string phoneNumber, string nip, string companyName, string address) : this(firstName, lastName, phoneNumber, address)
        {
            CompanyName = companyName;
            Nip = int.Parse(nip);
        }

#pragma warning disable 659
        public override bool Equals(object obj)
#pragma warning restore 659
        {
            if (obj == null) return false;
            return obj.ToString() == LastName || obj.ToString() == PhoneNumber.ToString() || obj.ToString() == CompanyName;
        }
    }
}
