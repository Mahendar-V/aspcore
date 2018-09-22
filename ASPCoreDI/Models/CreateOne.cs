using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreDI.Models
{
    public class CreatorOne : ICreator
    {
        public string Name => "one";

        public string CreateById(int id)
        {
            return "Created by CreatorOne";
        }

        public void CreateById(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
