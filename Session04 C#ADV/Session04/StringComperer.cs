using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Session04
{
    internal class StringComperer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return y?.CompareTo(x) ?? -1;
        }
    }
}
