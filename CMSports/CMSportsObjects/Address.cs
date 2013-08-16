using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMSportsObjects
{
    public struct Address
    {
        private string streetName;
        private string streetNumber;
        private string suburb;
        private int postcode;

        public Address(string streetName, string streetNumber, string suburb, int postcode)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.suburb = suburb;
            this.postcode = postcode;
        }

        public string StreetName
        {
            get
            {
                return streetName;
            }
            set
            {
                streetName = value;
            }
        }

        public string StreetNumber
        {
            get
            {
                return streetNumber;
            }
            set
            {
                streetNumber = value;
            }
        }

        public string Suburb
        {
            get
            {
                return suburb;
            }
            set
            {
                suburb = value;
            }
        }

        public int Postcode
        {
            get
            {
                return postcode;
            }
            set
            {
                postcode = value;
            }
        }

        public override string ToString()
        {
            return StreetNumber + " " + StreetName + ", " + Suburb + " " + Postcode;
        }
    }
}
