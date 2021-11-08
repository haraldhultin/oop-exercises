﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMappings.Managers;
namespace WebApiMappings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        

        [HttpGet("{personId}")]
        public Person GetPerson(int personId)
        {
            return PersonManager.Instance.Get(personId);
            
        }


        [HttpGet()]
        public List<Person> ListPersons()
        {
            return PersonManager.Instance.List();
            //return new List<Person>
            //{
            //    new Person("Banan", 25),
            //    new Person("Jeff", 12),
            //    new Person("Omar", 23)
            //};
        }

        [HttpPost()]
        public bool CreatePerson([FromBody] Person person)
        {
            PersonManager.Instance.Create(person);
            return true;
        }


    }
}
