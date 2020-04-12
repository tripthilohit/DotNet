using System;
namespace test.Algo
{
    public class CatAndMouse
    {
        public static void catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(z - x) < Math.Abs(z - y))
                Console.WriteLine("Cat A");

            else if (Math.Abs(z - x) > Math.Abs(z - y))
                Console.WriteLine("Cat B");

            else
                Console.WriteLine("Mouse C");
        }
    }
}
