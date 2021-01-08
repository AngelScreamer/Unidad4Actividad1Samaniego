using System;
using System.Collections.Generic;

namespace ControlUsuarioSamaniego.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public ulong? Activo { get; set; }
        public int Codigo { get; set; }
    }
}
