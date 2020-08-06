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
                .PrimaryKey(t => t.AlquilerId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculos", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.VehiculoId);
            
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
                "dbo.Vehiculos",
                c => new
                    {
                        VehiculoId = c.Int(nullable: false, identity: true),
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
                    })
                .PrimaryKey(t => t.VehiculoId)
                .ForeignKey("dbo.Modelos", t => t.ModeloId, cascadeDelete: true)
                .ForeignKey("dbo.TiposDeCombustibles", t => t.TipoCombustibleId, cascadeDelete: true)
                .ForeignKey("dbo.TiposDeTransmision", t => t.TipoTransmisionId, cascadeDelete: true)
                .Index(t => t.TipoTransmisionId)
                .Index(t => t.TipoCombustibleId)
                .Index(t => t.ModeloId);
            
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
                .PrimaryKey(t => t.ModeloId)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Estatus = c.String(maxLength: 2),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MarcaId);
            
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
            DropForeignKey("dbo.Alquiler", "VehiculoId", "dbo.Vehiculos");
            DropForeignKey("dbo.Vehiculos", "TipoTransmisionId", "dbo.TiposDeTransmision");
            DropForeignKey("dbo.Vehiculos", "TipoCombustibleId", "dbo.TiposDeCombustibles");
            DropForeignKey("dbo.Vehiculos", "ModeloId", "dbo.Modelos");
            DropForeignKey("dbo.Modelos", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Alquiler", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Modelos", new[] { "MarcaId" });
            DropIndex("dbo.Vehiculos", new[] { "ModeloId" });
            DropIndex("dbo.Vehiculos", new[] { "TipoCombustibleId" });
            DropIndex("dbo.Vehiculos", new[] { "TipoTransmisionId" });
            DropIndex("dbo.Alquiler", new[] { "VehiculoId" });
            DropIndex("dbo.Alquiler", new[] { "ClienteId" });
            DropTable("dbo.TiposDeTransmision");
            DropTable("dbo.TiposDeCombustibles");
            DropTable("dbo.Marcas");
            DropTable("dbo.Modelos");
            DropTable("dbo.Vehiculos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Alquiler");
        }
    }
}
