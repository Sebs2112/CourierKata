using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierKata.Models
{
    public class ParcelAttributes
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }

        public ParcelAttributes() { }

        public ParcelAttributes(double length, double height, double width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public ParcelAttributes(double length, double height, double width, double weight)
        {
            Length = length;
            Height = height;
            Width = width;
            Weight = weight;
        }

        public double GetMaxDimension()
        {
            var dimensionsArray = new[] { Length, Height, Width };

            return dimensionsArray.Max();
        }
    }
}
