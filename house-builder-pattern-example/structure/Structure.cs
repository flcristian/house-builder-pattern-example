using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder_pattern_example.structure
{
    public abstract class Structure
    {
        private String _foundationMaterial;
        private String _facadeColor;
        private String _wallMaterials;
        private List<String> _rooms;
        
        // Constructors

        public Structure(String foundationMaterial, String facadeColor, String wallMaterials, List<String> rooms)
        {
            _foundationMaterial = foundationMaterial;
            _facadeColor = facadeColor;
            _wallMaterials = wallMaterials;
            _rooms = rooms;
        }

        public Structure()
        {
            _foundationMaterial = "default";
            _facadeColor = "default";
            _wallMaterials = "default";
            _rooms = new List<String>();
        }

        // Accessors

        public String FoundationMaterial
        {
            get { return _foundationMaterial; }
            set
            {
                _foundationMaterial = value;
            }
        }

        public String FacadeColor
        {
            get { return _facadeColor; }
            set
            {
                _facadeColor = value;
            }
        }

        public String WallMaterials
        {
            get { return _wallMaterials; }
            set
            {
                _wallMaterials = value;
            }
        }

        public List<String> Rooms
        {
            get { return _rooms; }
            set
            {
                _rooms = value;
            }
        }

        // Methods

        public override bool Equals(object? obj)
        {
            return (obj as Structure)._foundationMaterial == _foundationMaterial && (obj as Structure)._facadeColor == _facadeColor && (obj as Structure)._wallMaterials == _wallMaterials && (obj as Structure)._rooms == _rooms;
        }

        public void AddRoom(String room)
        {
            _rooms.Add(room);
        }

        public void ShowStructure()
        {
            Console.WriteLine(this);
        }
    }
}
