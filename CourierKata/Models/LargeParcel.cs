using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    public class LargeParcel : Parcel
    {
        public LargeParcel(ParcelAttributes parcelAttributes) : base(parcelAttributes, "Large Parcel", 15)
        {
        }
    }
}
