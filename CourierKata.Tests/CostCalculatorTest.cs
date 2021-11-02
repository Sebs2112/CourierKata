using CourierKata.Models;
using CourierKata.Services;
using System;
using Xunit;

namespace CourierKata.Tests
{
    public class CostCalculatorTest
    {
        [Fact]
        public void CalculateInvoice_MaxDimensionLessThan10_SmallPackageOnSummary()
        {
            //Arrange
            const string EXPECTED_INVOICE_SUMMARY = "Small Parcel: $3\nTotal Cost: $3";
            var parcelAttributes = new ParcelAttributes(1, 1, 1);
            var costCalulator = new CostCalculator();
            //Act
            var invoice = costCalulator.CalculateInvoice(parcelAttributes);
            //Assert
            Assert.Equal(EXPECTED_INVOICE_SUMMARY, invoice.ToString());
        }
    }
}
