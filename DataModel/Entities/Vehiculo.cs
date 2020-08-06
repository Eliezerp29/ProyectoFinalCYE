using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.DataModel.Entities
{
    [Table("Vehiculos")]
    public  class Vehiculo
    {
        [Key]
        public int VehiculoId { get; set; }
      [Required]
        public int TipoTransmisionId { get; set; }
        [Required]
        public int TipoCombustibleId { get; set; }
        [Required]
        public int   ModeloId { get; set; }
        [StringLength(100)]
        public string Chasis { get; set; }
        [StringLength(20)]
        public string Placa { get; set; }
        [StringLength(4)]
        public string Anio { get; set; }
        [StringLength(20)]
        public string Color  { get; set; }
        [StringLength(10)]
        public string Cilindraje { get; set; }
        [StringLength(50)]
        public string KmenTablero { get; set; }

        public int CantidadPuertas { get; set; }
        public decimal Precio { get; set; }
        public string Estatus { get; set; }

        public bool Borrado { get; set; }


        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }

        public TipoTransmision TipoTransmision { get; set; }

        public TipoCombustible TipoCombustible { get; set; }

        public Modelo Modelo { get; set; }

    }


}
