using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Dog:IAnimal
    {
        private string name;
        private string habitat;
        private string eating;
        public string Name{get{return name;}set{name=value;}}
        public string Habitat{get{return habitat;}set{habitat=value;}}
        public string Eating {get{return eating;}set{eating=value;}}

        public string DisplayName()
        {
            return Name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} \nHabitat: {Habitat} \nEating: {Eating}");
        }

        public Dog(string name,string habitat,string eating)
        {
            Name=name;
            Habitat=habitat;
            Eating=eating;

        }
        
    }
}