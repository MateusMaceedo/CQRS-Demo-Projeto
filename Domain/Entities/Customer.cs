using System;

namespace Domain.Entities
{
    public class Customer
    {
        public Customer(Guid id, string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        protected Customer() { }

        public string Name { get; private set; }

        public string  Email { get; private set; }

        public  DateTime BirthDate{ get; private set; }
    }
}
