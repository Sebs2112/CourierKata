using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    public class Invoice
    {
        public ICollection<Parcel> Parcels { get; } = new List<Parcel>();
        public decimal SpeedyShippingCost { get; set; }
        public decimal TotalCost { get; set; }

        public override string ToString()
        {
            var returnString = "";

            if (Parcels.Count > 0)
            {
                foreach (Parcel parcel in Parcels)
                {
                    returnString += parcel.ParcelType + ": $" + parcel.Cost + "\n";
                }
                if (SpeedyShippingCost > 0)
                    returnString += "Speedy Shipping: $" + SpeedyShippingCost + "\n";

                return returnString + "Total Cost: $" + TotalCost;
            }
            return "No Parcels, 0 cost";
        }
    }
}
