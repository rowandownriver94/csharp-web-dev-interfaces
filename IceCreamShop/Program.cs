using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            Console.WriteLine("(before flavor sort)\n");

            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }

            availableFlavors.Sort(new FlavorComparer());

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.


            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            Console.WriteLine("\n\n(after flavor sort)\n");

            foreach(Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }



            //ConeComparer 

            Console.WriteLine("\n\n(before cone cost sort)\n");

            foreach(Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: {cone.Cost}");
            }



            availableCones.Sort(new ConeComparer());

            Console.WriteLine("\n\n(after cone cost sort)\n");

            foreach(Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: {cone.Cost}");
            }



        }
    }
}
