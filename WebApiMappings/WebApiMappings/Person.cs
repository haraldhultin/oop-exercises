using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMappings
{

    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        private static int _idCounter = 0;
        public Person()
        {
            Id = _idCounter;
            _idCounter += 1;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    

}
