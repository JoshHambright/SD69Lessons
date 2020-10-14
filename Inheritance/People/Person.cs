using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.People
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Name
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                return (!string.IsNullOrWhiteSpace(fullName) ? fullName : "Unnamed");
            }
        }

    }
}
