using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Student(FullName FullName, string Major) : Person(FullName)
    {
    }
}
