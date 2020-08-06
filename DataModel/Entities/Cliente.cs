using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.DataModel.Entities
{
    [Table("Clientes")]
    public  class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Apellido { get; set; }
        [StringLength(500)]
        public string Direccion { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(100)]
        public string Correo { get; set; }
        [StringLength(11)]
        public string Cedula { get; set; }
        [StringLength(2)]
        public string Estatus { get; set; }
        public bool Borrado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }

    



    }
}
