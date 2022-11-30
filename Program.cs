using Object_oriented_program;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        People person1 = new People("PETRUS", "MALE", "BLACK", 23);
        People person2 = new People("PRECIOUS", "FEMALE", "BLACK", 22);
        People person3 = new People("DINEO", "FEMALE", "BLACK", 16);

        Console.WriteLine(person1.Name + " " + person1.Gender + " " + person1.Race + " " + person1.Age);
        Console.WriteLine(person2.Name + " " + person2.Gender + " " + person2.Race + " " + person2.Age);
        Console.WriteLine(person3.Name + " " + person3.Gender + " " + person3.Race + " " + person3.Age);

    }
}
