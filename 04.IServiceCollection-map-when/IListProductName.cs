using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04.IServiceCollection_map_when
{
    public interface IListProductName
    {
        IEnumerable<string> GetNames();
    }
}
