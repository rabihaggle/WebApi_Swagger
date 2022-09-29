using System;
using System.Collections.Generic;

namespace WebApi1.Models
{
    public partial class OperacionesAProcesar
    {
        public int Id { get; set; }
        public string? NumeroOperacion { get; set; }
        public string? Navieras { get; set; }
        public string? Flujo { get; set; }
        public string? CodMatriculaContenedor { get; set; }
    }
}
