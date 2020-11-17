using System;
using System.Collections.Generic;
using System.Text;

namespace GUIH2
{
    class Prices
    {
        private static double Planeprice = 2500;
        private static double Bombprice = 30000;
        private static double Soldierprice = 500;
        private static double Tankprice = 1200;

        double[] priceArray = { Planeprice, Bombprice, Soldierprice, Tankprice };
        public double[] ReturnPrices(double gange)
        {
            for (int i = 0; i < 3; i++)
            {
                priceArray[i] = priceArray[i] * gange;
            }
            return priceArray;
        }

        public double[] ReturnSellprices(double gange)
        {
            for(int i = 0; i < 3; i++)
            {
                priceArray[i] = priceArray[i] * gange;
            }
            return priceArray;
        }
    }
}
