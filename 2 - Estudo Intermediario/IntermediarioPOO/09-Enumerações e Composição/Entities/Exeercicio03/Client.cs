using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO.Entities.ExeercicioEC
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime date) 
        {
            Name = name;
            Email = email;
            BirthDate = date;
        }
    }
}
