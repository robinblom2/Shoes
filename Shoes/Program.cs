using System;

namespace Shoes
{
    class Program
    {
        static ShoeCloset shoeCloset = new ShoeCloset();

        static void Main(string[] args)
        {
            while (true)
            {
                shoeCloset.PrintShoes();
                Console.Write($"\nPress 'a' to add or 'r' to remove a shoe: ");
                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case 'a':
                    case 'A':                               // There's no break statement after the 'a' case, so it falls through to the 'A' case - so they're both handled by shoeCloset.AddShoe. 
                        shoeCloset.AddShoe();
                        break;
                    case 'r':
                    case 'R':
                        shoeCloset.RemoveShoe();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
