using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.DataModel.Entities
{
    [Table("TiposDeCombustibles")]
    public class TipoCombustible
    {
        [Key]
        public int TipoCombustibleId { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(2)]
        public string Estatus { get; set; }
        public bool Borrado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }
    }
}
