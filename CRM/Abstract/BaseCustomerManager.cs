﻿using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CRM.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName);
        }
    }
}
