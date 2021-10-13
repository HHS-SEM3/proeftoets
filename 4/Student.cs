using System;
using System.Collections.Generic;

class Student
{
    public string Naam { get; set; }
    public int Gewicht { get; set; }
    public int Lengte { get; set; }
    public bool Vrouw { get; set; }
    public List<String> Huisdieren { get; set; }
    public Student(string Naam, int Gewicht, int Lengte, bool Vrouw, List<String> Huisdieren)
    {
        this.Naam = Naam;
        this.Gewicht = Gewicht;
        this.Lengte = Lengte;
        this.Vrouw = Vrouw;
        this.Huisdieren = Huisdieren;
    }
    public static List<Student> Studenten { get; set; } = new List<Student>() {
        new Student("Bob", 75, 182, false, new List<String>() {}),
        new Student("Alice", 55, 161, true, new List<String>() {"Poes", "Hond"}),
        new Student("Eve", 60, 165, true, new List<String>() {"Hond"}),
        new Student("Axel", 105, 190, false, new List<String>() {"Cavia"}),
        new Student("John", 85, 165, false, new List<String>() {"Cavia", "Cavia", "Cavia"}),
        new Student("Alex", 90, 195, false, new List<String>() {"Hond", "Poes"})
    };
}
