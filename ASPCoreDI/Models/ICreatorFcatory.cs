using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreDI.Models
{
   public interface ICreatorFcatory
    {
        ICreator GetCreator(string Key);
    }
}
