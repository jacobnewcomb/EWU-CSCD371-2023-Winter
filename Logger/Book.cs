using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Book(string Title, FullName Author) : Entity
    {
        public override string Name => Title + " - " + Author;
    }
}
