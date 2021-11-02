using CourierKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Factory
{
    public static class ParcelFactory
    {
        public static Parcel GetParcel(ParcelAttributes parcelAttributes)
        {
            if (parcelAttributes.GetMaxDimension() < 10)
            {
                return new SmallParcel(parcelAttributes);
            }
            else { return new MediumParcel(parcelAttributes); }
        }

    }
}
