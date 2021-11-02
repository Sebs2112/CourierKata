using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    internal class XLParcel : Parcel
    {
        public XLParcel(ParcelAttributes parcelAttributes) : base(parcelAttributes, "XL Parcel", 25)
        {
        }
    }
}
