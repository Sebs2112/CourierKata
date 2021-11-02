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

        public ParcelAttributes(double length, double height, double width)
        {
            Length = length;
            Height = height;
            Width = width;
        }
    }
}
