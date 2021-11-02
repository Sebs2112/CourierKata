using CourierKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Services
{
    public class CostCalculatorWithSpeedyShipping : CostCalculator
    {
        public int SPEEDY_SHIPPING_MULTIPLIER = 2;

        public override Invoice CalculateInvoice(Order order)
        {
            var invoice = base.CalculateInvoice(order);
            if (order.SpeedyShipping)
            {
                invoice.SpeedyShippingCost = invoice.TotalCost;
                invoice.TotalCost *= (decimal)SPEEDY_SHIPPING_MULTIPLIER;
            }
            return invoice;
        }
    }
}
