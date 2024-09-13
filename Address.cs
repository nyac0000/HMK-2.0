using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HMK_2._0
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public int Zipcode { get; set; }

        public Address()
        {
            StreetNumber = 0;
            StreetName = string.Empty;
            State = string.Empty;
            City = string.Empty;
            Zipcode = 0;
        }

        public Address(int StreetNumber, string StreetName, string State, string City, int Zipcode)
        {
            StreetNumber = StreetNumber;
            StreetName = StreetName;
            State = State;
            City = City;
            Zipcode = Zipcode;

        }

    }
}
