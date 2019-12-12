﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {



        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;


            foundCustomer = customerList.FirstOrDefault(c =>
                                c.CustomerId == customerId);

             

            return foundCustomer;

        }




        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
            {
                new Customer()
                {   CustomerId=1,
                    FirstName="Frodo",
                    LastName ="Beggins",
                    EmailAddress = "fb@hob.me",
                    CustomerTypeId=1
                },
                new Customer()
                {   CustomerId=2,
                    FirstName="Bilbo",
                    LastName ="Beggins",
                    EmailAddress = "bb@hob.me",
                    CustomerTypeId=null
                },
                new Customer()
                {   CustomerId=3,
                    FirstName="Samwise",
                    LastName ="Gamgee",
                    EmailAddress = "sg@hob.me",
                    CustomerTypeId=1
                },
                new Customer()
                {   CustomerId=4,
                    FirstName="Rosie",
                    LastName ="Cotton",
                    EmailAddress = "rc@hob.me",
                    CustomerTypeId=2
                }
            };
            return custList;
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(),5);
        }


        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                            .ThenBy(c=> c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //                    .ThenByDescending(c => c.FirstName);

            return SortByName(customerList).Reverse();


        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                                .ThenBy(c =>c.CustomerTypeId); // null value sorted to the top of the list
        }



    }
}


//public Customer Find(List<Customer> customerList, int customerId)
//{
//    Customer foundCustomer = null;
//    foreach (var c in customerList)
//    {
//        if (c.CustomerId == customerId)
//        {
//            foundCustomer = c;
//            break;
//        }
//    }
//    return foundCustomer;

//}

//IEnumerable<customer>

//var query = from c in customerList
//            where c.CustomerId == customerId
//            select c;
//foundCustomer = query.First();

//foundCustomer = customerList.FirstOrDefault(c =>
//                {
//                    Debug.WriteLine(c.LastName);
//                    return c.CustomerId == customerId;
//                });


//search of plusieurs
//foundCustomer = customerList.Where(c =>
//                    c.CustomerId == customerId)
//                    .Skip(1)
//                    .FirstOrDefault();