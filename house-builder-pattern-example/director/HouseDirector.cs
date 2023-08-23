using house_builder_pattern_example.builder;
using house_builder_pattern_example.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder_pattern_example.director
{
    public class HouseDirector : IDirector
    {
        public Structure Instruct(IBuilder builder)
        {
            Console.WriteLine("Choose foundation material or leave empty for default :");
            String foundationMaterial = Console.ReadLine();
            if (foundationMaterial == null || foundationMaterial == "")
            {
                foundationMaterial = "default";
            }
            builder.BuildFoundation(foundationMaterial);

            Console.WriteLine("Pick a facade color or leave empty for default :");
            String facadeColor = Console.ReadLine();
            if (facadeColor == null || facadeColor == "")
            {
                facadeColor = "default";
            }
            builder.PickFacadeColor(facadeColor);

            Console.WriteLine("Choose wall materials or leave empty for default :");
            String wallMaterials = Console.ReadLine();
            if (wallMaterials == null || wallMaterials == "")
            {
                wallMaterials = "default";
            }
            builder.BuildWalls(wallMaterials);

            builder.AddBaseRooms();

            Console.WriteLine("Do you want to add aditional rooms? (Y/N)");
            String choice = Console.ReadLine();
            while(choice.ToLower() == "y")
            {
                Console.WriteLine("Enter the room :");
                String room = Console.ReadLine();
                builder.AddRoom(room);

                Console.WriteLine("Do you want to add aditional rooms? (Y/N)");
                choice = Console.ReadLine();
            }
            Console.WriteLine();

            return builder.GetStructure();
        }
    }
}
