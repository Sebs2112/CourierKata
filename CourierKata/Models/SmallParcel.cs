using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    public class SmallParcel : Parcel
    {

        public SmallParcel(ParcelAttributes parcelAttributes) : base(parcelAttributes, "Small Parcel", 3)
        {
        }

    }
}
