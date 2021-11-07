using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMappings.Managers
{
    public class PersonManager
    {
        private  List<Person> _persons = new();
        private static PersonManager _instance = null;
        private PersonManager()
        {

        }
        public static PersonManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonManager();
                }
                return _instance;
            }
        }
        public List<Person> List()
        {
            return _persons;
        }
        public void Create(Person person)
        {
            _persons.Add(person);
        }
        public Person Get(int personId)
        {
            foreach (Person person in _persons)
            {
                if (person.Id == personId)
                {
                    return person;
                }
            }            
            return null;
            
        }
    }
}
