using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // (3p) is de langste student een vrouw?
        if (Student.Studenten...)
            Console.WriteLine("De langste student is een vrouw!");
        
        // (3p) print de lengte van Eve uit, en geef een error als er meer dan Eve bestaat
        Console.WriteLine(Student.Studenten...);
        
        // (3p) wat is de laagste BMI? (BMI = gewicht (kg) / lengte (cm) / lengte (cm))
        Console.WriteLine(Student.Studenten...);
        
        // (3p) print een lijst van de studenten met het aantal huisdieren
        foreach (var a in Student.Studenten...)
            Console.WriteLine(a.Naam + " heeft " + a.HuisdierenAantal + " huisdieren. "); 
        
        // (4p) geef een lijst van gemiddeld gewicht per lengte categorie
        foreach (var a in Student.Studenten...)
            Console.WriteLine("Het gemiddelde gewicht in de categorie [" 
                + a.CategorieLengte + " tot " + (a.CategorieLengte + 10)
                + "] is " + a.GemiddeldGewicht); 
        /*
            De uitvoer moet zijn:
            Het gemiddelde gewicht in de categorie [180 tot 190] is 75
            Het gemiddelde gewicht in de categorie [160 tot 170] is 66.66666666666667
            Het gemiddelde gewicht in de categorie [190 tot 200] is 97.5
        */
        
        // (4p) is er een student met een slang als huisdier?
        if (Student.Studenten...)
            Console.WriteLine("Er is een student met een slang als huisdier!");
    }
}