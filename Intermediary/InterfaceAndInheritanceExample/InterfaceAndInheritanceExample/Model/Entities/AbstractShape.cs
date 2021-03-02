using InterfaceAndInheritanceExample.Model.Enums;

namespace InterfaceAndInheritanceExample.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }

}
