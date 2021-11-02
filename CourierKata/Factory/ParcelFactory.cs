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
            var maxDimension = parcelAttributes.GetMaxDimension();

            if (maxDimension < 10)
            {
                return new SmallParcel(parcelAttributes);
            }
            else if (maxDimension >= 10 && maxDimension < 50)
            {
                return new MediumParcel(parcelAttributes);
            }
            else
            {
                return new LargeParcel(parcelAttributes);
            }
        }

    }
}
