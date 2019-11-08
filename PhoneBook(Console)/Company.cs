using System.Collections.Generic;

namespace Lab5_Sol
{
    class Company : PhoneBook
    {
        public Company(List<string> dataList, List<PhoneBook> phoneBook) : base(dataList[0], dataList[1], dataList[2], dataList[3], dataList[4], phoneBook)
        {
            if (dataList.Count == 6)
                CompanyAddress = dataList[5];
        }

        public override string ToString()
        {
            return $"First name : {FirstName}\nLast Name : {LastName}\nPhone Number : {PhoneNumber}\nNIP : {Nip}\nCompany Name : {CompanyName}\nAddress : {CompanyAddress?? "None"}";
        }
    }
}