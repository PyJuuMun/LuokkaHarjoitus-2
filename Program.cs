using System;
using System.Collections.Generic;

namespace LuokkaHarjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tyhjä objektin luonnin malli copy-pastea varten
            //Person person = new Person();
            //person.Name = "";
            //person.Age = ;
            //person.Salary = ;

            //Luo uuden objektin 'person1' jota voidaan käyttää
            Person person1 = new Person
            //vaihtoehtoinen tapa määrittää attribuutit objektille 'person1', 'helpompi/simppelimpi' tapa Visual Studion mukaan
            {
                Name = "Mikko",
                Age = 25,
                Salary = 2000
            };

            Person person2 = new Person();
            //vanhat attribuutit kommentoitu ulos mutta tallessa
            //person2.Name = "Tommi";
            //person2.Age = 44;
            //person2.Salary = 1750;
            person2.Name = "Raimo";
            person2.Age = 56;
            person2.Salary = 12000;

            Person person3 = new Person();
            //vanhat attribuutit kommentoitu ulos mutta tallessa
            //person3.Name = "Mari";
            //person3.Age = 37;
            //person3.Salary = 2560;
            person3.Name = "Julia";
            person3.Age = 22;
            person3.Salary = 2050;

            //Tyhjä contructori objektin luontiin
            //Person person = new Person(ATTRIBUUTIT/PARAMETRIT TÄHÄN!!);
            Person person4 = new Person("Topias", 65, 11000);
            Person person5 = new Person("Jaana", 38, 1750);

            //Objektit kavereilla, friend-attribuutti jätetty tyhjäksi WriteLine metodia varten, friend attribuutti ulkopuolella contructoria
            Person person6 = new Person("Pekka", 25, 2400);
            Person person7 = new Person("Juuso", 24, 4000000);
            Person person8 = new Person("Antti", 28, 2350);

            person6.Friend = person7;
            person8.Friend = person6;

            //Tyhjä WriteLine metodi copy-pastea varten
            //Console.WriteLine($"Nimi: {person.Name}, Ikä: {person.Age}, Palkka: {person.Salary}.");
            Console.WriteLine($"Nimi: {person1.Name}, Ikä: {person1.Age}, Palkka: {person1.Salary}.");
            Console.WriteLine($"Nimi: {person2.Name}, Ikä: {person2.Age}, Palkka: {person2.Salary}.");
            Console.WriteLine($"Nimi: {person3.Name}, Ikä: {person3.Age}, Palkka: {person3.Salary}.");
            Console.WriteLine();
            Console.WriteLine($"Nimi: {person4.Name}, Ikä: {person4.Age}, Palkka: {person4.Salary}.");
            Console.WriteLine($"Nimi: {person5.Name}, Ikä: {person5.Age}, Palkka: {person5.Salary}.");
            Console.WriteLine();
            Console.WriteLine($"Nimi: {person6.Name}, Ikä: {person6.Age}, Palkka: {person6.Salary}, Kaveri: {person6.Friend.Name}.");
            Console.WriteLine($"Nimi: {person8.Name}, Ikä: {person8.Age}, Palkka: {person8.Salary}, Kaveri: {person8.Friend.Name}.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nimet 'foreach' looppia käyttäen:");
            Console.WriteLine();

            //Lista aiemmista 'person' tyypin objecteista
            //HOX!! Lista objecteista tule AINA OBJEKTIEN JÄLKEEN

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person6);
            people.Add(person8);

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Iät lasketty yhteen 'foreach' looppia käyttäen:");            

            int Iät = 0;

            foreach (var person in people)
            {
                Iät += person.Age;
            }

            Console.WriteLine(Iät);
        }
    }
}
