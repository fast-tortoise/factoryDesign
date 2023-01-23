namespace FactoryMethod_Varun
{
    internal interface IClothesFactory
    {
        (IClothes,IClothes) GetClothes(string typeOfShirt);
    }
}