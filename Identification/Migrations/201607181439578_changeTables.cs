namespace Identification.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        idUtilisateur = c.String(nullable: false, maxLength: 128),
                        nomUtilisateur = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idUtilisateur);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilisateurs");
        }
    }
}
