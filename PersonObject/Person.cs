using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonObject
{
    internal class Person
    {
        private bool isUpper;
        private bool isLower;
        private bool isNumber;
        private string email = "";
        private string password = "";
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public int Age { get { return GetAge(); } }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DoB.Year;
            if (today < new DateTime(today.Year, DoB.Month, DoB.Day)) age--;
            return age;
        }
        public string Email 
        {
            get { return email; }
            set
            {
                if (value.Contains("@") && value.Contains("."))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine(value + " Email must contain @ and .");
                    email = null;
                }
            } 
        }
        public string Password 
        {
            get { return password; }
            set
            {
                if(value.Length < 6)
                {
                    Console.WriteLine("Must be at least 6 characters");
                    password = null;
                }

                foreach(char c in value)
                {
                    if (char.IsUpper(c)) { isUpper = true; }
                    if (char.IsLower(c)) { isLower = true; }
                    if (char.IsDigit(c)) { isNumber = true; }
                }

                if(isUpper == true && isLower == true && isNumber == true)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine(value + " Password must contain small and big letters and numbers");
                    password = null;
                }
            }
        }
    }
}
