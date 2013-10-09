using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistanceConverter
{
    public class DistanceConverter
    {
        public double FromMilesToKm(double miles)
        {
            return miles * 1.609344;
        }


        public double FromKMtoMiles(double km)
        {
            return km / 1.609344;
        }

        public void OtherConverter()
        {
            double unusedvariable = 11.55;
        }


       
    }
}