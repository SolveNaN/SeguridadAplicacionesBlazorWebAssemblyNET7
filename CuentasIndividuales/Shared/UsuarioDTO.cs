using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasIndividuales.Shared
{
    public class UsuarioDTO
    {
        public string NombreCuenta { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        //Aqui se colocan todos los demas datos que tenga el usuario como nombres, direcciones, fechas, edad, estados etc

        public string Rol { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;

    }
}
