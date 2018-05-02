using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100458008
{
    public interface IConfiguration
    {
        IEnumerable<string> Lines { get; }
    }
}
