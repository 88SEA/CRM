using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
