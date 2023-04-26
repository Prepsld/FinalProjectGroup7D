using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create by Markus Luthi
//On April 25th, 2023
//For OOP2 Final Project

namespace FinalProjectGroup7D.Tables
{
    public class User
    {

        public int AccountNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailingAddress { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string CreditCard { get; set; }

        public User()
        {

        }

        public User(int accountNum, string firstName, string lastName, string mailingAddress, string phoneNum, string email, string creditCard)
        {
            AccountNum= accountNum;
            FirstName= firstName;
            LastName= lastName;
            MailingAddress= mailingAddress;
            PhoneNum= phoneNum;
            Email= email;
            CreditCard= creditCard;

        }
    }
}
