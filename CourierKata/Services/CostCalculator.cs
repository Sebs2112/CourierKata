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
        public Invoice CalculateInvoice(ParcelAttributes parcelAttributes)
        {
            var invoice = new Invoice();
            invoice.addParcel(new SmallParcel(parcelAttributes));
            return invoice;
        }
    }
}
