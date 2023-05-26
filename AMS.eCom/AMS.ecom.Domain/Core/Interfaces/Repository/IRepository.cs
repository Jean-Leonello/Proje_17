using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task Delete();
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
    }
}
