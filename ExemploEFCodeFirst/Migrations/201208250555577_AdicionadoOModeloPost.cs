namespace ExemploEFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoOModeloPost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 100),
                        Conteudo = c.String(maxLength: 2000),
                        ParentPost_Id = c.Int(),
                        Autor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.ParentPost_Id)
                .ForeignKey("dbo.Usuarios", t => t.Autor_Id, cascadeDelete: true)
                .Index(t => t.ParentPost_Id)
                .Index(t => t.Autor_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "Autor_Id" });
            DropIndex("dbo.Posts", new[] { "ParentPost_Id" });
            DropForeignKey("dbo.Posts", "Autor_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Posts", "ParentPost_Id", "dbo.Posts");
            DropTable("dbo.Posts");
        }
    }
}
