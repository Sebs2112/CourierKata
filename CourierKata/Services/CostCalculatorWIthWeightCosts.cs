using CourierKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Services
{
    public class CostCalculatorWithWeightCosts : CostCalculatorWithSpeedyShipping
    {
        public decimal OVERWEIGHT_CHARGE = 2;

        public override Invoice CalculateInvoice(Order order)
        {
            var invoice = base.CalculateInvoice(order);
            foreach (Parcel parcel in invoice.Parcels)
            {
                var overweightValue = parcel.parcelAttributes.Weight - parcel.MaxWeight;
                if (overweightValue > 0)
                {
                    var additionalParcelCost = OVERWEIGHT_CHARGE * (decimal)overweightValue;
                    parcel.Cost += additionalParcelCost;
                    invoice.TotalCost += additionalParcelCost;
                }
            }
            return invoice;
        }

    }
}
