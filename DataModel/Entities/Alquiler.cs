using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.DataModel.Entities
{

    [Table ("Alquiler")]
    public class Alquiler


    {

        public Alquiler()
        {
            this.Vehiculos = new HashSet<Vehiculo>();
        }
        [Key]
        public int AlquilerId { get; set; }
        
        public int ClienteId { get; set; }
        
        public int VehiculoId { get; set; }
        [StringLength(50)]
        public string MetodoDePago { get; set; }
        
        public decimal Costo { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public DateTime FechaDevolucion { get; set; }
        public decimal Penalidad { get; set; }
        [StringLength(2)]
        public string Estatus { get; set; }
        public bool Borrado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }

        public ICollection<Vehiculo>Vehiculos { get; set; }
    }
}
