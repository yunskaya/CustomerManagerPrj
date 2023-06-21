using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //builder.hasdata(
            //    new customer { customerıd = 1, name = "yunus", surname = "kaya" },
            //    new customer { customerıd = 2, name = "serkan", surname = "demir" },
            //    new customer { customerıd = 3, name = "demir", surname = "olcay" }
            //    );
        }
    }
}