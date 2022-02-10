using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_enumeracao_composicao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, string birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
