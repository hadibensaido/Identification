namespace Identification.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTables1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        idAudit = c.Int(nullable: false, identity: true),
                        dateAudit = c.DateTime(nullable: false),
                        libelleAudit = c.String(),
                        idEtablissement = c.Int(nullable: false),
                        idQuestionnaire = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idAudit)
                .ForeignKey("dbo.Etablissements", t => t.idEtablissement, cascadeDelete: true)
                .ForeignKey("dbo.Questionnaires", t => t.idQuestionnaire, cascadeDelete: true)
                .Index(t => t.idEtablissement)
                .Index(t => t.idQuestionnaire);
            
            CreateTable(
                "dbo.Etablissements",
                c => new
                    {
                        idEtablissement = c.Int(nullable: false, identity: true),
                        libelleEtablissement = c.String(nullable: false, maxLength: 50),
                        Compte_idCompte = c.Int(),
                    })
                .PrimaryKey(t => t.idEtablissement)
                .ForeignKey("dbo.Comptes", t => t.Compte_idCompte)
                .Index(t => t.Compte_idCompte);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        idClient = c.Int(nullable: false, identity: true),
                        nomClient = c.String(nullable: false, maxLength: 30),
                        idSegment = c.Int(nullable: false),
                        idInvitation = c.Int(nullable: false),
                        Etablissement_idEtablissement = c.Int(),
                    })
                .PrimaryKey(t => t.idClient)
                .ForeignKey("dbo.Invitations", t => t.idInvitation, cascadeDelete: true)
                .ForeignKey("dbo.Segments", t => t.idSegment, cascadeDelete: true)
                .ForeignKey("dbo.Etablissements", t => t.Etablissement_idEtablissement)
                .Index(t => t.idSegment)
                .Index(t => t.idInvitation)
                .Index(t => t.Etablissement_idEtablissement);
            
            CreateTable(
                "dbo.Invitations",
                c => new
                    {
                        idInvitation = c.Int(nullable: false, identity: true),
                        dateEvoi = c.DateTime(nullable: false),
                        libelleInvitation = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.idInvitation);
            
            CreateTable(
                "dbo.Prestations",
                c => new
                    {
                        idPrestation = c.Int(nullable: false, identity: true),
                        datePrestation = c.DateTime(nullable: false),
                        libelleBanquet = c.String(),
                        libelleSejour = c.Int(),
                        libelleSeminaire = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Client_idClient = c.Int(),
                    })
                .PrimaryKey(t => t.idPrestation)
                .ForeignKey("dbo.Clients", t => t.Client_idClient)
                .Index(t => t.Client_idClient);
            
            CreateTable(
                "dbo.Segments",
                c => new
                    {
                        idSegment = c.Int(nullable: false, identity: true),
                        libelleSegment = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.idSegment);
            
            CreateTable(
                "dbo.SousSegments",
                c => new
                    {
                        idSSegment = c.Int(nullable: false, identity: true),
                        libelleSSegment = c.String(nullable: false, maxLength: 30),
                        idSegment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idSSegment)
                .ForeignKey("dbo.Segments", t => t.idSegment, cascadeDelete: true)
                .Index(t => t.idSegment);
            
            CreateTable(
                "dbo.Questionnaires",
                c => new
                    {
                        idQuestionnaire = c.Int(nullable: false, identity: true),
                        libelleQuestionnaire = c.String(),
                        idType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idQuestionnaire)
                .ForeignKey("dbo.TypeQuestionnaires", t => t.idType, cascadeDelete: true)
                .Index(t => t.idType);
            
            CreateTable(
                "dbo.TypeQuestionnaires",
                c => new
                    {
                        idType = c.Int(nullable: false, identity: true),
                        libelleType = c.String(),
                    })
                .PrimaryKey(t => t.idType);
            
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        idCompte = c.Int(nullable: false, identity: true),
                        libelleCompte = c.String(nullable: false, maxLength: 50),
                        profil_idProfil = c.Int(),
                    })
                .PrimaryKey(t => t.idCompte)
                .ForeignKey("dbo.Profils", t => t.profil_idProfil)
                .Index(t => t.profil_idProfil);
            
            CreateTable(
                "dbo.Profils",
                c => new
                    {
                        idProfil = c.Int(nullable: false, identity: true),
                        libelleProfil = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idProfil);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        idQuestion = c.Int(nullable: false, identity: true),
                        libelleQuestion = c.String(),
                    })
                .PrimaryKey(t => t.idQuestion);
            
            CreateTable(
                "dbo.Reponses",
                c => new
                    {
                        idReponse = c.Int(nullable: false, identity: true),
                        reponse = c.String(),
                        commentaire = c.String(),
                        idQuestion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idReponse)
                .ForeignKey("dbo.Questions", t => t.idQuestion, cascadeDelete: true)
                .Index(t => t.idQuestion);
            
            AddColumn("dbo.Utilisateurs", "Etablissement_idEtablissement", c => c.Int());
            CreateIndex("dbo.Utilisateurs", "Etablissement_idEtablissement");
            AddForeignKey("dbo.Utilisateurs", "Etablissement_idEtablissement", "dbo.Etablissements", "idEtablissement");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reponses", "idQuestion", "dbo.Questions");
            DropForeignKey("dbo.Comptes", "profil_idProfil", "dbo.Profils");
            DropForeignKey("dbo.Etablissements", "Compte_idCompte", "dbo.Comptes");
            DropForeignKey("dbo.Audits", "idQuestionnaire", "dbo.Questionnaires");
            DropForeignKey("dbo.Questionnaires", "idType", "dbo.TypeQuestionnaires");
            DropForeignKey("dbo.Audits", "idEtablissement", "dbo.Etablissements");
            DropForeignKey("dbo.Utilisateurs", "Etablissement_idEtablissement", "dbo.Etablissements");
            DropForeignKey("dbo.Clients", "Etablissement_idEtablissement", "dbo.Etablissements");
            DropForeignKey("dbo.Clients", "idSegment", "dbo.Segments");
            DropForeignKey("dbo.SousSegments", "idSegment", "dbo.Segments");
            DropForeignKey("dbo.Prestations", "Client_idClient", "dbo.Clients");
            DropForeignKey("dbo.Clients", "idInvitation", "dbo.Invitations");
            DropIndex("dbo.Reponses", new[] { "idQuestion" });
            DropIndex("dbo.Comptes", new[] { "profil_idProfil" });
            DropIndex("dbo.Questionnaires", new[] { "idType" });
            DropIndex("dbo.Utilisateurs", new[] { "Etablissement_idEtablissement" });
            DropIndex("dbo.SousSegments", new[] { "idSegment" });
            DropIndex("dbo.Prestations", new[] { "Client_idClient" });
            DropIndex("dbo.Clients", new[] { "Etablissement_idEtablissement" });
            DropIndex("dbo.Clients", new[] { "idInvitation" });
            DropIndex("dbo.Clients", new[] { "idSegment" });
            DropIndex("dbo.Etablissements", new[] { "Compte_idCompte" });
            DropIndex("dbo.Audits", new[] { "idQuestionnaire" });
            DropIndex("dbo.Audits", new[] { "idEtablissement" });
            DropColumn("dbo.Utilisateurs", "Etablissement_idEtablissement");
            DropTable("dbo.Reponses");
            DropTable("dbo.Questions");
            DropTable("dbo.Profils");
            DropTable("dbo.Comptes");
            DropTable("dbo.TypeQuestionnaires");
            DropTable("dbo.Questionnaires");
            DropTable("dbo.SousSegments");
            DropTable("dbo.Segments");
            DropTable("dbo.Prestations");
            DropTable("dbo.Invitations");
            DropTable("dbo.Clients");
            DropTable("dbo.Etablissements");
            DropTable("dbo.Audits");
        }
    }
}
