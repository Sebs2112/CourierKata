using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    public class Invoice
    {
        private ICollection<Parcel> Parcels = new List<Parcel>();
        public decimal TotalCost { get; set; }

        public void addParcel(Parcel parcel)
        {
            Parcels.Add(parcel);
            TotalCost += parcel.Cost;
        }
        public override string ToString()
        {
            var returnString = "";

            if (Parcels.Count > 0)
            {
                foreach (Parcel parcel in Parcels)
                {
                    returnString += parcel.ParcelType + ": $" + parcel.Cost + "\n";
                }
                return returnString + "Total Cost: $" + TotalCost;
            }
            return "No Parcels, 0 cost";
        }
    }
}
