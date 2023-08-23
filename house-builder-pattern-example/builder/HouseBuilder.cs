using house_builder_pattern_example.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder_pattern_example.builder
{
    public class HouseBuilder : IBuilder
    {
        private Structure _house;

        // Constructors

        public HouseBuilder()
        {
            _house = new House();
        }

        // Methods

        public void BuildFoundation(String material)
        {
            _house.FoundationMaterial = material;
        }

        public void PickFacadeColor(String color)
        {
            _house.FacadeColor = color;
        }

        public void BuildWalls(String materials)
        {
            _house.WallMaterials = materials;
        }

        public void AddBaseRooms()
        {
            _house.AddRoom("Bedroom");
            _house.AddRoom("Bathroom");
            _house.AddRoom("Kitchen");
        }

        public void AddRoom(String room)
        {
            _house.AddRoom(room);
        }

        public Structure GetStructure()
        {
            return _house;
        }
    }
}
