using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    //Skapar en klass som heter Triangle
    public class Triangle
    {   //Skapar 5 variabler i klassen int eftersom jag endast kommer använda heltal för triangelns storlek
        int _a;
        int _b;
        int _c;
        int _trianglebase;
        int _triangleheight;

        //Skapar en konstruktor med 3 parametrar för triangelns sidor
        public Triangle(int a, int b, int c)
            {
                _a = a;
                _b = b;
                _c = c;
            }

        //Skapar en till konstruktor med 2 parametrar för triangelns bas och höjd
        public Triangle(int trianglebase, int triangleheight)
            {
                _trianglebase = trianglebase;
                _triangleheight = triangleheight;
            }

        //Skapar en metod som returnerar triangelns omkrets
        public int GetCircumference()
            {
                return _a + _b + _c;
            }

        //En metod som returnerar beräkningen av triangelns area
        public int GetArea()
            {
                return (_trianglebase * _triangleheight) / 2;
            }

        //Omkrets = a + b + c
        //Area = (b * h) /3
    }
}
