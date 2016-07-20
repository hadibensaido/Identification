namespace Identification.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Questionnaire_idQuestionnaire", c => c.Int());
            CreateIndex("dbo.Questions", "Questionnaire_idQuestionnaire");
            AddForeignKey("dbo.Questions", "Questionnaire_idQuestionnaire", "dbo.Questionnaires", "idQuestionnaire");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Questionnaire_idQuestionnaire", "dbo.Questionnaires");
            DropIndex("dbo.Questions", new[] { "Questionnaire_idQuestionnaire" });
            DropColumn("dbo.Questions", "Questionnaire_idQuestionnaire");
        }
    }
}
