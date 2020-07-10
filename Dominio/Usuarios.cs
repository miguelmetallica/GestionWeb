using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuarios : IdentityUser 
    {
        public string NombreCompleto{ get; set; }

        public string SucursalId { get; set; }

        public Sucursales Sucursal { get; set; }
    }
}
