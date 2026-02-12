using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicConceptsPractice
{
    internal class User
    {
        private string _id;
        public string UserName
        {
            get
            {
                return _id;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(_id)) _id = value;
                else Console.WriteLine("istifadeci adi bos ola bilmez");
            }
        }

        private int _age;
        public int Age 
        {
            get { return _age; }
            set 
            { 
                if (-Age < 0) Console.WriteLine("yash menfi ola bilmez");
                else _age = value;
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set 
            {
                bool hasUpper = false;
                bool hasDigit = false;
                foreach (char item in value)
                {
                    if(char.IsDigit(item)) hasDigit = true;
                    if (char.IsUpper(item)) hasUpper = true;

                }
                if (hasUpper&&hasDigit) _password = value;
                else Console.WriteLine("Shifre en az 1 reqem ve boyuk herf qebul etmelidi");

                if(_password.Length < 8) Console.WriteLine("Shifre 8 xarakterden az olmamalidir");
                else _password = value;
            } 
        }
    }
}
