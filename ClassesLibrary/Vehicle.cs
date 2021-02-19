using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;
        
        //properties
        public string Make
        {
            get { return Make; }
            set { Make = value; }
        }

        public string Model
        {
            get { return Model; }
            set { Model = value; }
        }

        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }

        public float Weight
        {
            get { return Weight; }
            set { Weight = value; }
        }
   
        //ctors
        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public Vehicle()
        {

        }
        
        //methods
        public override string ToString()
        {
            return string.Format("Make: {0}\n" +
                "Model: {1}\n" +
                "Year: {2}\n" +
                "Weight: {3}\n",
                Make, Model, Year, Weight);
        }
    }
}
