using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyABPPractise.Authorization.Person
{
    public class Person : Entity
    {
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
