using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public int Age;
        public double Weight;
        public double Height;
        public bool HasAuto;
        public bool HasBike;
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }

        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }

        public string GetHeightCategory()
        {
            if (Height >= 1.8)
            {
                return "Високий зріст";
            }
            else if (Height <= 1.6)
            {
                return "Низький зріст";
            }
            else
            {
                return "Середній зріст";
            }
        }
    }
}
