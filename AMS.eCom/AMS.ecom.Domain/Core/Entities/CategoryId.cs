using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Entities
{ 
    public class CategoryId
    { 
        public  CategoryId() { }

    public  CategoryId(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

public Guid Id { get; set; }
public string Name { get; set; }
    }
}
