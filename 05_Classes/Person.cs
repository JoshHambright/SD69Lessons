﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {
        // A Class can represent a data table
        public string FirstName { get; set; }
        // private field
        private string _lastName;
        public string LastName
        {
            get { return _lastName[0].ToString(); }
            set { _lastName = value; }
        }

        public  string FullName
        {
            get { return FirstName + " " + _lastName; }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears)); //Rounds out totalAgeInYears with floor to lowest rounding, then converts to int32
                return yearsOfAge;
            }
        }
        public Vehicle Transport { get; set; }

        public Person() { }

        public Person ( string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;

        }

        //public void Ager(DateTime Birthday)
        //{
        //    double totalAgeInYears = ageSpan.TotalDays / 365.241;
        //    int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
        //    Console.WriteLine(yearsOfAge);
        //}

        public double Quotient(int num1, int num2)
        {
            double aResult = num1 / num2;
            return aResult;
        }
    }
}
