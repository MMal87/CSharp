using System;

    namespace PriceDisplay
    {
        public class PriceDisplay
        {

            public string GetPriceLabel(string item, double price)
            {
                return $"The price for item: {item} is {price}";
            }
        }
    }
