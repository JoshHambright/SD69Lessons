﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.People
{
    //                  inheritance
    public class Employee : Person
    {
        public int EmployeeNumber { get; }

        public Employee(int number)
        {
            EmployeeNumber = number;

        }

    }
    // Inherits from employee
    // derived from employee
    // employee is inherited from people

    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
        public HourlyEmployee(int number) : base(number)
        {
            Console.WriteLine("Hourly employee hired!");
        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int number, decimal salary) : base(number)
        {
            Salary = salary;
        }
    }
      
            
        
        
    
}
