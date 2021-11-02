using CourierKata.Factory;
using CourierKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Services
{
    public class CostCalculator : ICostCalculator
    {
        public virtual Invoice CalculateInvoice(Order order)
        {
            var invoice = new Invoice();
            foreach (ParcelAttributes parcelAttribute in order.ParcelAttributesList)
            {
                var parcel = ParcelFactory.GetParcel(parcelAttribute);
                invoice.Parcels.Add(parcel);
                invoice.TotalCost += parcel.Cost;

            }
            return invoice;
        }
    }
}
