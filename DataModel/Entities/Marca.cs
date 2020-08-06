using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.DataModel.Entities
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(2)]
        public string Estatus { get; set; }
        public bool Borrado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }


    }
}
