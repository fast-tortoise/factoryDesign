using System;
namespace FactoryMethod_Varun
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // the cutomer wants checked shirt
            // the customer wants designed jeans

            Console.WriteLine("Plain or Designer");
            var userChoice = Console.ReadLine();
            
            IClothesFactory clothesFactory = new FactoryClothes();
            (var jeans, var shirt) = clothesFactory.GetClothes(userChoice);
            jeans.create();
            shirt.create();
            //Console.WriteLine($"{selectedCloth} -> {selectedCloth.clothType}");
        }
    }
}