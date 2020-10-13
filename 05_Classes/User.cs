using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class User
    {

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserID { get; }

        public DateTime BirthDate { get; set; }

        //Setters

        public User(string firstName, string lastName, DateTime bday, int userID)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = bday;
            UserID = userID;
        }

        public User() { }

        // Classes

        public string FullName //Return the User's full name
        {
            get { return FirstName + " " + LastName; }
        }
        
        public int AgeInYears // Return the User's Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - BirthDate;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

    }
}
