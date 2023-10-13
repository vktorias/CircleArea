using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    //Skapar en klass som heter Circle
    public class Circle
    {
        //Skapar två variabler
        float _pi; //en variabel i klassen float för att kunna deklarera decimaltal
        float _radius; //en variabel i klassen int för att deklarera heltal

        //Konstruktor med två parametrar
        public Circle(float pi, float radius)
        {
            _pi = pi;
            _radius = radius;
        }

        //Skapar en metod som ska returnera arean på cirkeln utifrån radiens storlek
        public float GetArea() 
        {
            //Skapar en variabel i klassen float där uträkningen av arean sparas
            return _pi * _radius * _radius;
        }

        //Skapar en metod som ska retunernera omkretsen på cirkeln
        public float GetCircumference()
        {
            //O=2⋅π⋅r
            return 2 * _pi * _radius;
        }

        //Skapar en metod som ska returnera beräkningen av volymen
        public double GetVolume()
        {
            //Vklot = 4⋅π⋅r3 /3

            return ( 4 * _pi * _radius * _radius * _radius ) / 3 ;
            
        }
    }
}
