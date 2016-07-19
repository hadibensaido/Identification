namespace Identification.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Prestations", "libelleSejour", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prestations", "libelleSejour", c => c.Int());
        }
    }
}
