using System;
using System.Collections.Generic;
using System.Text;

namespace Dulce.Heladeria.Services.Dtos
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }
    }
}
