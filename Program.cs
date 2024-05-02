using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ClafeLibrary;
using OceanariumLibrary;
using TeamLibrary;

//Тема: Вступ у Generics
//Модуль 10. Part 2


namespace _25._04._24_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            //Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму.
            //Створіть клас для кожної істоти Океанаріуму. Вони мають містити інформацію
            //про кожну морську істоту. Реалізуйте підтримку ітератора для класу
            //«Океанаріум». Протестуйте можливість використання foreach для Океанаріуму.

            Console.WriteLine($"Task 1\n");

            Oceanarium habitants = new Oceanarium();
            habitants.ToAddHabitant(new Inhabitant("Fish", "Spiny dogfish", "Acanthias", 2));
            habitants.ToAddHabitant(new Inhabitant("Reptile", "Sea Turtle", "Shelly", 10));
            habitants.ToAddHabitant(new Inhabitant("Mollusk", "Octopus", "Inky", 3));
            habitants.ToAddHabitant(new Inhabitant("Fish", "Pontic shad", "Immaculata", 1));
            habitants.ToAddHabitant(new Inhabitant("Invertebrate", "Jellyfish", "Aurelia", 1));

            foreach (Inhabitant i in habitants)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();

            //Завдання 2
            //Створіть клас «Футбольна Команда». Клас має містити
            //інформацію про гравців футбольної команди. Реалізуйте
            //підтримку ітератора для класу «Футбольна Команда».
            //Протестуйте можливість використання foreach для класу
            //«Футбольна Команда».

            Console.WriteLine($"Task 2\n");

            Team players = new Team();
            players.ToAddPlayer(new Player("Lionel", "forward", 10, 10));
            players.ToAddPlayer(new Player("Olivia", "center-back", 5, 8));
            players.ToAddPlayer(new Player("Diego", "midfielder", 8, 9));
            players.ToAddPlayer(new Player("Sophia", "right winger", 7, 10));
            players.ToAddPlayer(new Player("Max", "attacking midfielder", 11, 9));
            players.ToAddPlayer(new Player("Isabella", "left-back", 3, 11));
            players.ToAddPlayer(new Player("Lucas", "striker", 9, 9));
            players.ToAddPlayer(new Player("Emma", "defensive midfielder", 6, 8));
            players.ToAddPlayer(new Player("Gabriel", "goalkeeper", 1, 10));
            players.ToAddPlayer(new Player("Mia", "central midfielder", 4, 9));
            players.ToAddPlayer(new Player("Noah ", "right-back", 2, 9));

            Console.WriteLine("forwards\n");
            foreach (Player p in players)
            {
                if (p.GetPosition() == "forward" || 
                    p.GetPosition() == "striker")
                {
                    Console.WriteLine(p);
                }
            }

            Console.WriteLine("\nNext . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("midfielders\n");
            foreach (Player p in players)
            {
                if (p.GetPosition() == "midfielder" || 
                    p.GetPosition() == "right winger" || 
                    p.GetPosition() == "attacking midfielder" || 
                    p.GetPosition() == "defensive midfielder" || 
                    p.GetPosition() == "central midfielder")
                {
                    Console.WriteLine(p);
                }
            }

            Console.WriteLine("\nNext . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("defenders\n");
            foreach (Player p in players)
            {
                if (p.GetPosition() == "center-back" || 
                    p.GetPosition() == "left-back" || 
                    p.GetPosition() == "right-back" || 
                    p.GetPosition() == "goalkeeper")
                {
                    Console.WriteLine(p);
                }
            }

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();

            //Завдання 3
            //Створіть клас «Кафе» з інформацією про працівників кафе.
            //Реалізуйте підтримку ітератора для класу «Кафе».
            //Протестуйте можливість використання foreach для «Кафе».

            Console.WriteLine($"Task 3\n");

            Cafe employees = new Cafe();
            employees.ToAddEmployee(new Employee("Diego", "waiter"));
            employees.ToAddEmployee(new Employee("Gabriel", "chef"));
            employees.ToAddEmployee(new Employee("Noah", "barista"));
            employees.ToAddEmployee(new Employee("Max", "waiter"));
            employees.ToAddEmployee(new Employee("Isabella", "waiter"));

            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
        }
    }
}
