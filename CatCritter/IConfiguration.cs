using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCritter
{
    public interface IConfiguration
    {
        IEnumerable<string> Lines { get; }
    }
}
