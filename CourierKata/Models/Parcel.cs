using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    public class Parcel
    {
        public ParcelAttributes parcelAttributes;
        public string ParcelType { get; set; }
        public decimal Cost { get; set; }
        public double MaxWeight { get; set; }

        public Parcel(ParcelAttributes parcelAttributes, string parcelType, decimal cost)
        {
            this.parcelAttributes = parcelAttributes;
            ParcelType = parcelType;
            Cost = cost;
        }

        public Parcel(ParcelAttributes parcelAttributes, string parcelType, decimal cost, double maxWeight)
        {
            this.parcelAttributes = parcelAttributes;
            ParcelType = parcelType;
            Cost = cost;
            MaxWeight = maxWeight;
        }
    }
}
