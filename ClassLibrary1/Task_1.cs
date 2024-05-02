using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OceanariumLibrary
{
    public class Inhabitant
    {
        private string AnimalClass { get; set; }
        private string AnimalType { get; set; }
        private string AnimalName { get; set; }
        private int AnimalAge { get; set; }

        public Inhabitant(string animalClass, string animalType, string animalName, int animalAge)
        {
            AnimalClass = animalClass;
            AnimalType = animalType;
            AnimalName = animalName;
            AnimalAge = animalAge;
        }
        public override string ToString()
        {
            return  $"class:\t\t{AnimalClass}\n" +
                    $"type:\t\t{AnimalType}\n" +
                    $"name:\t\t{AnimalName}\n" +
                    $"age:\t\t{AnimalAge}\n";
        }

    }
    public class Oceanarium : IEnumerable
    {
        private List<Inhabitant> habitants;
        public Oceanarium()
        {
            habitants = new List<Inhabitant>();
        }
        public void ToAddHabitant(Inhabitant habitant)
        {
            habitants.Add(habitant);
        }
        public IEnumerator GetEnumerator()
        {
            return habitants.GetEnumerator();
        }
    }
}
