using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.ecom.Domain.Core.Entities
{
    public class ColorId
    {
        public  ColorId (){}

    public ColorId (Guid id, string description,bool isActive)
    {
        Id = id;
        Description = description;
        IsActive = isActive;
    }

    public Guid Id { get; set; }
    public string Description { get; set; }

    bool IsActive { get; set; }
    }
   
}
