using System;

namespace Assignment4
{
    public class TShirt
    {
        public Color Color;
        public Size Size;
        public Fabric Fabric;
        public decimal Price { get; set; }

        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
    }
}
