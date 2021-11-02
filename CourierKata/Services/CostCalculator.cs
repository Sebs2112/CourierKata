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
        public virtual Invoice CalculateInvoice(ParcelAttributes parcelAttributes)
        {
            var invoice = new Invoice();
            var parcel = ParcelFactory.GetParcel(parcelAttributes);
            invoice.AddParcel(parcel);
            return invoice;
        }
    }
}
