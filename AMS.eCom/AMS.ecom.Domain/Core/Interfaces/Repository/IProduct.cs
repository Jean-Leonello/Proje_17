using AMS.ecom.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Interfaces.Repository
{
    public interface IProduct : IRepository<Product>
    {
        void Delete(Guid id);
    }
}
