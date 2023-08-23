using house_builder_pattern_example.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder_pattern_example.builder
{
    public interface IBuilder
    {
        void BuildFoundation(String material);

        void PickFacadeColor(String color);

        void BuildWalls(String material);

        void AddBaseRooms();

        void AddRoom(String room);

        Structure GetStructure();
    }
}
