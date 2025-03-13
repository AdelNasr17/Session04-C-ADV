using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Session04
{
    internal class StringEqualityComperer : IEqualityComparer<string>
    {
        //public new bool Equals(object? x, object? y)
        //{
        //    string? X = x as string;
        //    string? Y = y as string;

        //    return X?.ToUpper().Equals(Y?.ToUpper()) ?? false;
        //}

        public bool Equals(string? x, string? y)
        {
            return x?.ToUpper().Equals(y?.ToUpper()) ?? false;
        }

        //public int GetHashCode(object obj)
        //{
        //    string? value = obj as string;
        //    return value?.ToUpper().GetHashCode() ?? throw new ArgumentException("obj is not string ");
        //}

        public int GetHashCode([DisallowNull] string value)
        {
            return value.ToUpper().GetHashCode();
        }
    }
}
