namespace CircleArea
{
    internal class Program
    {   //Viktoria Wallström .NET23
        static void Main(string[] args)
        {
            Console.WriteLine("* Nedan kommer uträkningar på två olika cirklars area, omkrets och volym *");

            Console.WriteLine(); //En tom Console.WriteLine(); för att skapa space i konsollen.

            //Skapar ett nytt objekt för första cirkeln och en konstruktor med två parametrar som konstruktorn begär från filen circle
            Circle c1 = new Circle(3.141f, 5);

            //Skapar en variabel (area1) och anropar metoden GetArea() för att beräkna första cirkelns area. 
            //Beräkningen sparas i area1 variabeln.
            float area1 = c1.GetArea();

            //Skapar en variabel (circumference1) och anropar metoden GetCircumference(); för att beräkna 
            //cirkelns omkrets. Beräkningen sparas i circumference1 variabeln. 
            float circumference1 = c1.GetCircumference();

            //Skapar en variabel (volume1) och anropar metoden GetVolyme(); för att beräkna första cirkelns volym.
            //Beräkningen sparas i volume1 variabeln.
            double volume1 = c1.GetVolume();

            //Skriver ut information om cirkeln och med hjälp av att beräkningarna sparats i olika variabler så 
            //kan man enkelt hämta all beräkning med variablerna. 
            Console.WriteLine("Cirkel 1 med en radie på 5 cm\n" +
                "================================\n" +
                "Area: " + area1 + " cm^2. \n" +
                "Omkrets: " + circumference1 + " cm. \n" +
                "Volym: " + volume1 + " cm^3.\n" +
                "================================\n");

            Console.WriteLine(); //En tom Console.WriteLine(); för att skapa space i konsollen.

            //Skapar ett nytt obekt för andra cirkeln och en konstruktor
            Circle c2 = new Circle(3.141f, 6);

            
            float area2 = c2.GetArea();

            //Skapar ett nytt objekt för andra cirkeln och en konstruktor med två parametrar som konstruktorn begär från filen circle
            Circle circle2 = new Circle(3.141f, 6);
            float circumference2 = circle2.GetCircumference();
            double volume2 = c2.GetVolume();
            Console.WriteLine("Cirkel 2 med en radie på 6 cm\n" +
                "================================\n" +
                "Area: " + area2 + " cm^2.\n" +
                "Omkrets: " + circumference2 + " cm.\n" +
                "Volym: " + volume2 + " cm^3.\n" +
                "================================\n");

            Console.WriteLine(); //En tom Console.WriteLine(); för att skapa space i konsollen.

            Console.WriteLine("* Nedan kommer en uträkning av en specifik triangels omkrets och area *");

            Console.WriteLine(); //En tom Console.WriteLine(); för att skapa space i konsollen.

            //Skapar ett nytt objekt för triangeln och en konstruktor med tre parametrar som konstruktorn begär från filen triangle
            Triangle triangleCircumference = new Triangle(5, 12, 13);

            //Skapar en variabel (triangleCircumferenceValue) och anropar metoden GetCircumference() för att beräkna triangelns omkrets. 
            //Beräkningen sparas variabeln.
            int triangleCircumfercenceValue = triangleCircumference.GetCircumference();
            Triangle triangleArea = new Triangle(10, 15);
            //Skapar en variabel (triangleAreaValue) och anropar metoden GetArea() för att beräkna triangelns area. 
            //Beräkningen sparas variabeln.
            int triangleAreaValue = triangleArea.GetArea();

            //Skriver ut information om triangeln och med hjälp av att beräkningarna sparats i olika variabler så 
            //kan man enkelt hämta all beräkning med variablerna. 
            Console.WriteLine("Denna triangel är rätvinklig och har sidorna 5, 12 och 13 cm. \n" +
                "================================\n" +
            "Triangelns omkrets är " + triangleCircumfercenceValue + " cm. \n" +
                "Triangelns area är " + triangleAreaValue + " cm^2.\n" +
                "================================");
            Console.WriteLine();
            Console.WriteLine("Ha en trevlig dag!");
        }
    }
}