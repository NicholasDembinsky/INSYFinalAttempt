using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INSYFinalAttempt
{
    internal class Client
    {

        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string SocialSecurityNumber { get; set; }
            public int Age { get; set; }
            public int CreditScore { get; set; }

            // Constructor
            public Client(int id, string name, string address, string phoneNumber, string ssn, int age, int creditScore)
            {
                ID = id;
                Name = name;
                Address = address;
                PhoneNumber = phoneNumber;
                SocialSecurityNumber = ssn;
                Age = age;
                CreditScore = creditScore;
            }

        }
    }
