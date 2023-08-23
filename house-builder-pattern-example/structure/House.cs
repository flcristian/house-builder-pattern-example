using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder_pattern_example.structure
{
    public class House : Structure
    {
        public House(String foundationMaterial, String facadeColor, String wallMaterials, List<String> rooms) : base(foundationMaterial, facadeColor, wallMaterials, rooms) { }

        public House() { }

        // Methods

        public override string ToString()
        {
            String desc = "House\n";
            desc += $"Foundation Material : {FoundationMaterial}\n";
            desc += $"Facade Color : {FacadeColor}\n";
            desc += $"Wall Materials : {WallMaterials}\n";
            desc += "Rooms :\n";
            foreach(String room in Rooms)
            {
                desc += $"{room}\n";
            }
            return desc;
        }
    }
}
