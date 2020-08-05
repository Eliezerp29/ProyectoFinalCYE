namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alquiler",
                c => new
                    {
                        AlquilerId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        MetodoDePago = c.String(maxLength: 50),
                        Costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaDesde = c.DateTime(nullable: false),
                        FechaHasta = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        Penalidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estatus = c.String(maxLength: 2),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AlquilerId);
            
            CreateTable(
                "dbo.TiposDeVehiculos",
                c => new
                    {
                        VehiculoID = c.Int(nullable: false, identity: true),
                        TipoTransmisionId = c.Int(nullable: false),
                        TipoCombustibleId = c.Int(nullable: false),
                        ModeloId = c.Int(nullable: false),
                        Chasis = c.String(maxLength: 100),
                        Placa = c.String(maxLength: 20),
                        Anio = c.String(maxLength: 4),
                        Color = c.String(maxLength: 20),
                        Cilindraje = c.String(maxLength: 10),
                        KmenTablero = c.String(maxLength: 50),
                        CantidadPuertas = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estatus = c.String(),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                        Vehiculos_VehiculoID = c.Int(),
                        Alquiler_AlquilerId = c.Int(),
                    })
                .PrimaryKey(t => t.VehiculoID)
                .ForeignKey("dbo.TiposDeVehiculos", t => t.Vehiculos_VehiculoID)
                .ForeignKey("dbo.Alquiler", t => t.Alquiler_AlquilerId)
                .Index(t => t.Vehiculos_VehiculoID)
                .Index(t => t.Alquiler_AlquilerId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Apellido = c.String(maxLength: 100),
                        Direccion = c.String(maxLength: 500),
                        Telefono = c.String(maxLength: 20),
                        Correo = c.String(maxLength: 100),
                        Cedula = c.String(maxLength: 11),
                        Estatus = c.String(maxLength: 2),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        TipoMarcaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Estatus = c.String(maxLength: 2),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoMarcaId);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        ModeloId = c.Int(nullable: false, identity: true),
                        MarcaId = c.Int(nullable: false),
                        Nombre = c.String(maxLength: 100),
                        Estatus = c.String(maxLength: 2),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ModeloId);
            
            CreateTable(
                "dbo.TiposDeCombustibles",
                c => new
                    {
                        TipoCombustibleId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Estatus = c.String(maxLength: 2),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoCombustibleId);
            
            CreateTable(
                "dbo.TiposDeTransmision",
                c => new
                    {
                        TipoTransmisionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Estatus = c.String(maxLength: 2),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoTransmisionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TiposDeVehiculos", "Alquiler_AlquilerId", "dbo.Alquiler");
            DropForeignKey("dbo.TiposDeVehiculos", "Vehiculos_VehiculoID", "dbo.TiposDeVehiculos");
            DropIndex("dbo.TiposDeVehiculos", new[] { "Alquiler_AlquilerId" });
            DropIndex("dbo.TiposDeVehiculos", new[] { "Vehiculos_VehiculoID" });
            DropTable("dbo.TiposDeTransmision");
            DropTable("dbo.TiposDeCombustibles");
            DropTable("dbo.Modelos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Clientes");
            DropTable("dbo.TiposDeVehiculos");
            DropTable("dbo.Alquiler");
        }
    }
}
