using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPBasicConceptsPractice
{
    public class Doctor
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Doctor()
        {
            
        }
        public Doctor(string fullName, int age, string eMail, string address)
        {
            FullName = fullName;
            Age = age;
            Email = eMail;
            Address = address;
        }

       
    }
}
