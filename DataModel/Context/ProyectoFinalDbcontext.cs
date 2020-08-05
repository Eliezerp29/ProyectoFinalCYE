using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoFinal.DataModel.Entities;

namespace ProyectoFinal.DataModel.Context
{
    public class ProyectoFinalDbcontext:DbContext
    {

        public ProyectoFinalDbcontext()
            : base("name=ProyectoFinalconn")
        {

        }

        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        public virtual DbSet<Alquiler> Alquiler { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Marca> Marcas { get; set; }

        public virtual DbSet<Modelo> Modelos { get; set; }

        public virtual DbSet<TipoCombustible> TipoCombustibles { get; set; }

        public virtual DbSet<TipoTransmision> TipoTransmisions { get; set; }



    }
}
