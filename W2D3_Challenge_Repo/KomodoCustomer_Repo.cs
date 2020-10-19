using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W2D3_Challenge_Repo;

namespace W2D3_Challenge_Repo
{
    public class KomodoCustomer_Repo
    {

        private List<KomodoCustomer> _customerDirectory = new List<KomodoCustomer>();
        List<KomodoCustomer> customerDirectory = new List<KomodoCustomer>();

        //Create

        public bool AddCustomerToDirectory(KomodoCustomer customer)
        {
            int startingCount = _customerDirectory.Count;

            _customerDirectory.Add(customer);

            bool wasAdded = (_customerDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<KomodoCustomer> GetContent()
        {
            return _customerDirectory;
        }

        public KomodoCustomer GetCustomerByLastName(string lastname)
        {
            foreach (KomodoCustomer customer in _customerDirectory)
            {
                if (customer.LastName.ToLower() == lastname.ToLower())
                {
                    return customer;
                }
            }
            return null;
        }

        public KomodoCustomer GetCustomerByID(int id)
        {
            foreach (KomodoCustomer customer in _customerDirectory)
            {
                if (customer.CustomerID == id)
                {
                    return customer;
                }
            }
            return null;
        }

        //public void MessageCustomers()
        //{
        //    foreach (KomodoCustomer customer in _customerDirectory)
        //    {
        //        if (customer.GoldMember == true)
        //        {
        //            Console.WriteLine($"Message{customer.LastName}: Thanks for being a Gold Member!");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Message{customer.LastName}: Thanks for being a member for {customer.YearsOfEnrollment} years!");
        //        }
        //    }
        //}

        // Update
        public bool UpdateExistingCustomerByID(int customerID, KomodoCustomer newCustomer)
        {
            KomodoCustomer oldCustomer = GetCustomerByID(customerID);

            if (oldCustomer != null)
            {
                oldCustomer.CustomerID = newCustomer.CustomerID; //Read Only
                oldCustomer.LastName = newCustomer.LastName;
                oldCustomer.EnrollmentDate = newCustomer.EnrollmentDate;
                oldCustomer.BirthDate = newCustomer.BirthDate;
                return true;
            }
            else { return false; }
        }
        public bool UpdateExistingCustomerByLastName(string lastname, KomodoCustomer newCustomer)
        {
            KomodoCustomer oldCustomer = GetCustomerByLastName(lastname);

            if (oldCustomer != null)
            {
                oldCustomer.CustomerID = newCustomer.CustomerID; //Read Only
                oldCustomer.LastName = newCustomer.LastName;
                oldCustomer.EnrollmentDate = newCustomer.EnrollmentDate;
                oldCustomer.BirthDate = newCustomer.BirthDate;
                return true;
            }
            else { return false; }
        }

        // Delete
        public bool DeleteExistingCustomer(KomodoCustomer existingCustomer)
        {
            bool deleteResult = _customerDirectory.Remove(existingCustomer);
            return deleteResult;
        }
    }
}
