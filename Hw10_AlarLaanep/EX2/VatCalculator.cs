using System;
namespace EX2
{
    public class VatCalculator
    {

        public double VatRate { get; private set; }

        public VatCalculator()
        {
            VatRate = 0.2;
        }

        public void SetVatRate(double value)
        {
            VatRate = value / 100;
        }

        public double FindVat(double price)
        {
            return price * VatRate;
        }

        public double FindPrice(bool isWithTax, double amount)
        {
            if (isWithTax)
            {
                return amount / (VatRate + 1);
            } else
            {
                return amount + amount * (1 * VatRate);
            }
        }

        public double FindPriceBasedOnTax(double vatValue)
        {
            return vatValue / VatRate;
        }

        public Boolean IsTaxPercent20()
        {
            if(VatRate == 0.2)
            {
                return true;
            }
            return false;
        }
    }
}
