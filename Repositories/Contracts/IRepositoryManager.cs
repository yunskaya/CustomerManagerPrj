﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICustomerRepository customer { get; }
        IAddressRepository address { get; }
        void Save();
    }
}
