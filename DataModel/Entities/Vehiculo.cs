using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.DataModel.Entities
{
    [Table("TiposDeVehiculos")]
    public  class Vehiculo
    {
        [Key]
        public int VehiculoID { get; set; }
        public int TipoTransmisionId { get; set; }
        public int TipoCombustibleId { get; set; }
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

        public Vehiculo Vehiculos { get; set; }
    }
}
