using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreDI.Models
{
    public class CreatorFactory:ICreatorFcatory
    {
        private IEnumerable<ICreator> _creators;
        public CreatorFactory(IEnumerable<ICreator> creators) 
        {
            _creators = creators;
        }
        public ICreator GetCreator(string Key)
        {
            return this._creators.FirstOrDefault(s => s.Name == Key);
        }
    }
}
