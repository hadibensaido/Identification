namespace Identification.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tt1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionnaireForms",
                c => new
                    {
                        idQuestionnaireForm = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.idQuestionnaireForm);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuestionnaireForms");
        }
    }
}
