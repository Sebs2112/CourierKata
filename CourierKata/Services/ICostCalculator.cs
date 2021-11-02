using CourierKata.Models;

namespace CourierKata.Services
{
    public interface ICostCalculator
    {
        Invoice CalculateInvoice(Order order);
    }
}