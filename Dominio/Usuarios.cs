using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuarios : IdentityUser 
    {
        public string NombreCompleto{ get; set; }
    }
}
