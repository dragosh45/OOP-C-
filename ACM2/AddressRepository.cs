using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM2
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "bag end";
                address.StreetLine2 = "harcha parcha";
                address.City = "buca";
                address.State = "ilfov";
                address.Country = "lol";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerID)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "bag end",
                StreetLine2 = "harcha parcha",
                City = "buca",
                State = "ilfov",
                Country = "lol",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "2bag end",
                StreetLine2 = "2harcha parcha",
                City = "2buca",
                State = "2ilfov",
                Country = "2lol",
                PostalCode = "2144"
            };
            addressList.Add(address);
            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;
            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
