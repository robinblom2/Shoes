using System;
using System.Collections.Generic;
using System.Text;

namespace Shoes
{
    class ShoeCloset
    {
        private readonly List<Shoe> shoes = new List<Shoe>();                           // Here's the List that contains the references to the Shoe objects. 

        public void PrintShoes()
        {
            if (shoes.Count == 0)                                                       // The PrintShoes()-method uses the List.Count property to check if the list is empty. 
            {
                Console.WriteLine("\nThe shoe closet is empty.");
            }
            else
            {
                Console.WriteLine("\nThe shoe closet contains:");
                int i = 1;

                foreach (Shoe shoe in shoes)                                            // This foreach loop iterates through the "shoes" list and writes a line to the console for each shoe. 
                {
                    Console.WriteLine($"Shoe #{i++}: {shoe.Description}");
                }
            }
        }

        public void AddShoe()
        {
            Console.WriteLine("\nAdd a shoe");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Press {i} to add a {(Style)i}");                    // The for loop sets "i" to an integer from 0 to 5. The interpolated string uses {(Style)i} to cast it to a Style enum and then calls it's ToString-method to print the member name. 
            }

            Console.Write("Enter a style:");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))       // This is just like code you've seen before: It calls Console.ReadKey, then uses KeyChar to get the character that was pressed. int.TryParse needs a string, not a char, so we call ToString to convert the char to a string. 
            {
                Console.Write("\nEnter the color: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((Style)style, color);                              // Here's where we create a new Shoe instance and add it to the list. The constructor in the Shoe-class takes two parameters, the style of the shoe and the color of the shoe. 
                shoes.Add(shoe);                                                        // The List collection class has an Add-method that adds an item to the end of the list. The AddShoe()-method creates a Shoe-instance, then calls the shoes.Add-method with the reference to that instance. 
            }
        }

        public void RemoveShoe()
        {
            Console.Write("\nEnter the number of the shoe to remove: ");

            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) && (shoeNumber >= 1) && (shoeNumber <= shoes.Count))
            {
                Console.WriteLine($"\nRemoving {shoes[shoeNumber - 1].Description}");
                shoes.RemoveAt(shoeNumber - 1);                                                     // Here's where we remove a Shoe instance from the List. 
                                                                                                    // The List class also has a RemoveAt-method that removes an item from a specific index in the list. Lists, like arrays, are zero-indexed, which means the first item has index 0, the second item has index 1, etc. 
            }
        }

    }
}
