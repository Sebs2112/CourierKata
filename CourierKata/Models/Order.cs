using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    public class Order
    {
        public ICollection<ParcelAttributes> ParcelAttributesList { get; } = new List<ParcelAttributes>();

        public Order() { }
        public Order(ICollection<ParcelAttributes> parcelAttributes)
        {
            ParcelAttributesList = parcelAttributes;
        }

        public void AddParcelAttributes(ParcelAttributes parcelAttributes)
        {
            ParcelAttributesList.Add(parcelAttributes);
        }
    }
}
