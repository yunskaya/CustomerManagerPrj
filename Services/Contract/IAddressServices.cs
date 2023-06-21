using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contract
{
    public interface IAddressServices
    {
        IEnumerable<Address> GetAllCustomers(bool trackChanges);
        Address GetOneAddressById(int id, bool trackChanges);
        Address AddAddressToAddress(int addressId, Address address);
        Address CreateOneAddress(Address address);
        void UpdateOneAddress(int id, Address address, bool trackChanges);
        void DeleteAddress(int id, bool trackChanges);
    }
}
