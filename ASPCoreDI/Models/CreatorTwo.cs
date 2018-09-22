using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreDI.Models
{
    public class CreatorTwo : ICreator
    {
        public string Name => "two";
        public string CreateById(int id)
        {
            return "Created by CreatorTwo";
        }

        public void CreateById(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
