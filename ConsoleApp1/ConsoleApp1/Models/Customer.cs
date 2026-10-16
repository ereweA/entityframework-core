using System;
using System.Collections.Generic;
using System.Text;

namespace Orderframework.Models
{
    public partial class Customer
    {
        public string FirstLast
        {
            get => $"{FirstName} {LastName}";
        }
    }
}
