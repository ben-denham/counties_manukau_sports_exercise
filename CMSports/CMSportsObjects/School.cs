using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSportsObjects
{
    public class School : Organisation
    {
        public School(string name) : base(name)
        {

        }

        public School(string name, int size, Address address)
            : base(name, size, address)
        {

        }
    }
}
