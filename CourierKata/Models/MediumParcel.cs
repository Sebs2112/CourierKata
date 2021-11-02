using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    internal class MediumParcel : Parcel
    {
        public MediumParcel(ParcelAttributes parcelAttributes) : base(parcelAttributes, "Medium Parcel", 8)
        {
        }
    }
}
