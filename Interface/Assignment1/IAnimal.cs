using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface IAnimal
    {
        public string Name{get;set;}
        public string Habitat{get;set;}
        public string Eating{get;set;}
        string DisplayName();
        
    }
}