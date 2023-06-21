using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AddressManager : IAddressRepository
    {
        private readonly IRepositoryManager _manager;

        public AddressManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void Create(Address entity)
        {
            throw new NotImplementedException();
        }

        public Address CreateOneAddress(Address address)
        {
            _manager.address.Create(address);
            _manager.Save();

            return address;
        }

        public void Delete(Address entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteOneAddress(Address Address)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Address> FindAll(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Address> FindByCondition(Expression<Func<Address, bool>> expression, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
