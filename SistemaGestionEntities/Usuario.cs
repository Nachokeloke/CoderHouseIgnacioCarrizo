﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities

{
    public class Usuario

    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
        public string NombreUsuario { get; set; }

    }
}
