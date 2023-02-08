using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public readonly record struct FullName(string FName, string LName, string? MName = null)
    {
        public string FName { get; } = FName ?? throw new ArgumentNullException(null);
        public string LName { get; } = LName ?? throw new ArgumentNullException(null);
        public string? MName { get; } = MName;

        public override string ToString()
        {
            return MName == null ? FName + " " + LName : FName + " " + MName + " " + LName;
        }
    }
}
