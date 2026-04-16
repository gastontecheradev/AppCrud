using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AppCrud.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        [MaxLength(50)]
        public string Correo { get; set; }
        public DateOnly FechaContrato { get; set; }
        public bool Activo { get; set; }

    }
}
