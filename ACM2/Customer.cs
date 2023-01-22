using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM2
{
     class Customer : EntityBase
    {   public int CustomerId { get; set; }
        public string EmaiAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName = fullName + ", ";
                    }
                    fullName = fullName + FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }
        public int CustomerType { get; set; }
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public override bool Validate()
        {
            var isValid = true;
            if (!string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (!string.IsNullOrWhiteSpace(EmaiAddress)) isValid = false;
            return isValid;
        }
    }
}
