using CourierKata.Models;
using CourierKata.Services;
using System;
using Xunit;

namespace CourierKata.Tests
{
    public class CostCalculatorTest
    {
        [Fact]
        public void CalculateInvoice_MaxDimensionLessThan10_SmallParcelOnSummary()
        {
            //Arrange
            const string EXPECTED_INVOICE_SUMMARY = "Small Parcel: $3\nTotal Cost: $3";
            var order = new Order();
            order.AddParcelAttributes(new ParcelAttributes(1, 1, 1));
            var costCalulator = new CostCalculator();
            //Act
            var invoice = costCalulator.CalculateInvoice(order);
            //Assert
            Assert.Equal(EXPECTED_INVOICE_SUMMARY, invoice.ToString());
        }

        [Fact]
        public void CalculateInvoice_MaxDimensionLessThan50Above9_MediumParcelOnSummary()
        {
            //Arrange
            const string EXPECTED_INVOICE_SUMMARY = "Medium Parcel: $8\nTotal Cost: $8";
            var order = new Order();
            order.AddParcelAttributes(new ParcelAttributes(10, 10, 10));
            var costCalulator = new CostCalculator();
            //Act
            var invoice = costCalulator.CalculateInvoice(order);
            //Assert
            Assert.Equal(EXPECTED_INVOICE_SUMMARY, invoice.ToString());
        }

        [Fact]
        public void CalculateInvoice_MaxDimensionLessThan100Above49_LargeParcelOnSummary()
        {
            //Arrange
            const string EXPECTED_INVOICE_SUMMARY = "Large Parcel: $15\nTotal Cost: $15";
            var order = new Order();
            order.AddParcelAttributes(new ParcelAttributes(50, 50, 50));
            var costCalulator = new CostCalculator();
            //Act
            var invoice = costCalulator.CalculateInvoice(order);
            //Assert
            Assert.Equal(EXPECTED_INVOICE_SUMMARY, invoice.ToString());
        }

        [Fact]
        public void CalculateInvoice_MaxDimensionAbove99_XLParcelOnSummary()
        {
            //Arrange
            const string EXPECTED_INVOICE_SUMMARY = "XL Parcel: $25\nTotal Cost: $25";
            var order = new Order();
            order.AddParcelAttributes(new ParcelAttributes(100, 100, 100));
            var costCalulator = new CostCalculator();
            //Act
            var invoice = costCalulator.CalculateInvoice(order);
            //Assert
            Assert.Equal(EXPECTED_INVOICE_SUMMARY, invoice.ToString());
        }

        [Fact]
        public void CalculateInvoice_OneOfEachParcelSize_CombinedListAndTotalCost()
        {
            //Arrange
            const string EXPECTED_INVOICE_SUMMARY = "Small Parcel: $3\n" +
                                                    "Medium Parcel: $8\n" +
                                                    "Large Parcel: $15\n" +
                                                    "XL Parcel: $25\n" +
                                                    "Total Cost: $51";
            var order = new Order();
            order.AddParcelAttributes(new ParcelAttributes(1, 1, 1));
            order.AddParcelAttributes(new ParcelAttributes(10, 10, 10));
            order.AddParcelAttributes(new ParcelAttributes(50, 50, 50));
            order.AddParcelAttributes(new ParcelAttributes(100, 100, 100));
            var costCalculator = new CostCalculator();
            //Act
            var invoice = costCalculator.CalculateInvoice(order);
            //Assert

            Assert.Equal(EXPECTED_INVOICE_SUMMARY, invoice.ToString());
        }

    }
}
