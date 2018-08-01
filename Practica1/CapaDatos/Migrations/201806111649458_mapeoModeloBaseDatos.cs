namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mapeoModeloBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cat_Empresas",
                c => new
                    {
                        empresaId = c.Int(nullable: false, identity: true),
                        nombreEmpresa = c.String(maxLength: 100),
                        fechaRegistro = c.DateTime(nullable: false),
                        pais = c.String(),
                        telefono = c.String(),
                        estado = c.Boolean(nullable: false),
                        nombreTitular = c.String(),
                    })
                .PrimaryKey(t => t.empresaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cat_Empresas");
        }
    }
}
