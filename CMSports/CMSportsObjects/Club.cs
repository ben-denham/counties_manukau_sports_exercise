using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSportsObjects
{
    public class Club : Organisation
    {
        public Club()
        {

        }

        public Club(string name, int size, Address address)
            : base(name, size, address)
        {

        }
    }
}
