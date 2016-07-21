namespace Identification.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatek1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Audits", "idQuestionnaire", "dbo.Questionnaires");
            DropIndex("dbo.Audits", new[] { "idQuestionnaire" });
            AddColumn("dbo.Reponses", "idQuestionnaire", c => c.Int(nullable: false));
            CreateIndex("dbo.Reponses", "idQuestionnaire");
            AddForeignKey("dbo.Reponses", "idQuestionnaire", "dbo.Questionnaires", "idQuestionnaire", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reponses", "idQuestionnaire", "dbo.Questionnaires");
            DropIndex("dbo.Reponses", new[] { "idQuestionnaire" });
            DropColumn("dbo.Reponses", "idQuestionnaire");
            CreateIndex("dbo.Audits", "idQuestionnaire");
            AddForeignKey("dbo.Audits", "idQuestionnaire", "dbo.Questionnaires", "idQuestionnaire", cascadeDelete: true);
        }
    }
}
