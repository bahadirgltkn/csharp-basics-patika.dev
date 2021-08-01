using System;

namespace _23_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.LongEdge = 4;
            rect.ShortEdge = 3;
            Console.WriteLine("Class Area: {0}", rect.AreaCalculate());


            // Rectangle_Struct rect_struct = new Rectangle_Struct(3,4);
            Rectangle_Struct rect_struct;
            rect_struct.LongEdge = 4;
            rect_struct.ShortEdge = 3;
            Console.WriteLine("Struct Area: {0}", rect_struct.AreaCalculate());

        }
    }

    class Rectangle
    {
        public int ShortEdge;
        public int LongEdge;

        public long AreaCalculate(){
            return this.ShortEdge * this.LongEdge; 
        }
    }

    struct Rectangle_Struct
    {
        public int ShortEdge;
        public int LongEdge;

        // cannot be empty
        public Rectangle_Struct(int shortEdge, int longEdge)
        {
            ShortEdge = shortEdge;
            LongEdge = longEdge;
        }

        public long AreaCalculate(){
            return this.LongEdge * this.ShortEdge;
        }
    }
}
