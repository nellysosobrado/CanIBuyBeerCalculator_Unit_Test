using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstUnitTest.Tests;

public class CanIBuyBeerCalculatorTests
{
    // Test 1 //////////////////////////////////////////////////////////////////////////
    public static void If_User_Is_Under18_And_Pub_Fail()
    {
        try
        {
            // Arrange 
            var age = 20;
            var place = "Krogen";
            var proMille = 1.2m;

            // Act
            var result = CanIBuyBeerCalculator.CalculateBeerBuy(age, place, proMille);

            // Assert
            if (result == CanIBuyBeerCalculator.BuyBeerResultEnum.Ok)
            {
                Console.WriteLine("PASSED: PASSED: Person can drink beer in a pub!");
            }
            else if (result == CanIBuyBeerCalculator.BuyBeerResultEnum.CannotBuyBeer)
            {
                Console.WriteLine("FAILED: Person cannot drink beer in a pub!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    // Test 2 ////////////////////////////////////////////////////////////////////////////
    public static void If_User_Is_Under20_And_Systemet_Fail()
    {
        try
        {
            // Arrange 
            var age = 21;
            var place = "Systemet";
            var proMille = 1.2m;

            // Act
            var result = CanIBuyBeerCalculator.CalculateBeerBuy(age, place, proMille);

            // Assert
            if (result == CanIBuyBeerCalculator.BuyBeerResultEnum.Ok)
            {
                Console.WriteLine("PASSED: Person can buy beer at Systemet!");
            }
            else
            {
                Console.WriteLine("FAILED: Person cannot buy beer at Systemet!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    // Test 3 ////////////////////////////////////////////////////////////////////////////
    public static void If_User_Is_Too_Drunk_Fail()
    {
        try
        {
            // Arrange 
            var age = 21;
            var place = "Systemet";
            var proMille = 1.6m;

            // Act
            var result = CanIBuyBeerCalculator.CalculateBeerBuy(age, place, proMille);

            // Assert
            if (result == CanIBuyBeerCalculator.BuyBeerResultEnum.Ok)
            {
                Console.WriteLine("PASSED: Person can buy beer anywhere!");
            }
            else
            {
                Console.WriteLine("FAILED: Person is too drunk!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    // Test 4 ////////////////////////////////////////////////////////////////////////////
    public static void If_User_Is_Old_Enough_Not_Drunk_Pass()
    {
        try
        {
            // Arrange 
            var age = 21;
            var place = "Systemet";
            var proMille = 1.4m;

            // Act
            var result = CanIBuyBeerCalculator.CalculateBeerBuy(age, place, proMille);

            // Assert
            if (result == CanIBuyBeerCalculator.BuyBeerResultEnum.Ok)
            {
                Console.WriteLine("PASSED: Person can buy beer anywhere!");
            }
            else
            {
                Console.WriteLine("FAILED: Person cannot buy beer anywhere!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}


