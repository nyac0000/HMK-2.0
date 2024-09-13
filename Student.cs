using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMK_2._0
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major {  get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student() 
        { 
            FirstName = string.Empty; 
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0;
            Address = new Address(); // - null

        }

        public Student(string FirstName, string  LastName, string Major, double GPA)
        {
            FirstName = FirstName;
            LastName = LastName;
            Major = Major;
            GPA = GPA;
            Address = new Address();

        }

        public string CalculateDistinction()
        {
            string distinction;
            if (GPA >= 3.80)
            {
                distinction = "Summa Cum Laude";
            }
            else if(GPA >= 3.60)
            {
                distinction = "Magna Cum Laude";
            }
            else if (GPA >= 3.40)
            {
                distinction = "Cum Laude";
            }
            else
            {
                distinction = "No Special Distinction";
            }

            return distinction;
        }

        public void SetAddress(int StreetNumber, string StreetName, string State, string City, int Zipcode)
        {
            Address = new Address(StreetNumber, StreetName, State, City, Zipcode);
            // Address.StreetNumber = StreetNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName},{Major}, {CalculateDistinction()}";
        }
    }
}
