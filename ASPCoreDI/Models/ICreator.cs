using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreDI.Models
{
   public interface ICreator
    {
        string Name { get; }
        string CreateById(int id);
        void CreateById(Guid guid);
    }
}
