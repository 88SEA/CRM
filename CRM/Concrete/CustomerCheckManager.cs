﻿using CRM.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
