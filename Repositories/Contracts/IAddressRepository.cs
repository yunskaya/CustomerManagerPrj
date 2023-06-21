using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        Address CreateOneAddress(Address Address);
        void DeleteOneAddress(Address Address);
    }
}
