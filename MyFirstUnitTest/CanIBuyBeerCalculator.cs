using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstUnitTest;

public static class CanIBuyBeerCalculator
{
    public enum BuyBeerResultEnum
    {
        Ok,
        CannotBuyBeer
    }

    public static BuyBeerResultEnum CalculateBeerBuy(int age, string place, decimal promille)
    {

        if ((age > 18 && place == "Bar" ||
            age > 20 && place == "Systembolaget") &&
            promille < 1.5m)
        {
            return BuyBeerResultEnum.Ok;
        }
        return BuyBeerResultEnum.CannotBuyBeer;
    }

}