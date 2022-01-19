using System;
using IDE_DIO; 

namespace IDE_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Diogo";
            person.Idade = 18;
            person.Estado = "PE";

            var person2 = new Pessoa();

            person2.Nome = "Maria";
            person2.Idade = 17;
            person2.Estado = "SP";

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Flávio";
            animal.Especie = "Cachorro";

            Console.WriteLine("Hello World!");
        }
    }
}
