using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D3_Challenge_Repo
{
    public class KomodoCustomer
    {


        public int CustomerID { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - BirthDate;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

        public DateTime EnrollmentDate { get; set; }

        public int YearsOfEnrollment
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - EnrollmentDate;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsOfEnrollment = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfEnrollment;
            }
        }

        //public bool GoldMember
        //{
        //    get
        //    {
        //        if(YearsOfEnrollment >= 5)
        //        {
        //            return true;
        //        }
        //        else { return false; }
        //    }
        //}

        //public bool IsGoldMember
        //{
        //    get
        //    {
        //        if (YearsOfEnrollment >= 5)
        //        {
        //            Console.WriteLine("Thank you for being a gold member");
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

        public KomodoCustomer() { }

        public KomodoCustomer(int customerID, string lastName, DateTime birthday, DateTime enrollmentdate)
        {
            CustomerID = customerID;
            LastName = lastName;
            BirthDate = birthday;
            EnrollmentDate = enrollmentdate;
        }
        
        //public string GetGreetingMessage()
        //{
        //    if (IsGoldMember)
        //    {
        //        return "Hello Gold Member, Thank you for being a loyal Gold Customer!!";
        //    }
        //    return "Thanks for being a customer!";
        //}
    }
}