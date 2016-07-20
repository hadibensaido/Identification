namespace Identification.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Identification.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Identification.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            /* K.A              
            * Question */
            MetierIdentification.Models.Question question_1 = new MetierIdentification.Models.Question { idQuestion = 1, libelleQuestion = "Quelle est la probabilité que vous recommandiez l'entreprise Aston à un ami ou à un collègue ?" };
            context.Question.AddOrUpdate(i => i.idQuestion, question_1);

            /* K.A
             * Liste de questions ratachées au questionnaire N°1 */
            List<MetierIdentification.Models.Question> listQuestion = new List<MetierIdentification.Models.Question>();
            listQuestion.Add(question_1);

            /* les dates */
            DateTime date1 = DateTime.Parse("05/27/2016", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.Parse("06/21/2016", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date3 = DateTime.Parse("07/23/2016", System.Globalization.CultureInfo.InvariantCulture);
            
            /* Invitation */
            MetierIdentification.Models.Invitation invit_1 = new MetierIdentification.Models.Invitation { idInvitation = 1, libelleInvitation = "Invit 1", dateEvoi = date1 };
            MetierIdentification.Models.Invitation invit_2 = new MetierIdentification.Models.Invitation { idInvitation = 2, libelleInvitation = "Invit 2", dateEvoi = date2 };
            MetierIdentification.Models.Invitation invit_3 = new MetierIdentification.Models.Invitation { idInvitation = 3, libelleInvitation = "Invit 3", dateEvoi = date3 };
            context.Invitation.AddOrUpdate(i => i.idInvitation, invit_1, invit_2, invit_3);
            
            /* Etablissement */
            MetierIdentification.Models.Etablissement etablissement_1 = new MetierIdentification.Models.Etablissement { idEtablissement = 1, libelleEtablissement = "Etablissement_1"};
            MetierIdentification.Models.Etablissement etablissement_2 = new MetierIdentification.Models.Etablissement { idEtablissement = 2, libelleEtablissement = "Etablissement_2" };
            MetierIdentification.Models.Etablissement etablissement_3 = new MetierIdentification.Models.Etablissement { idEtablissement = 3, libelleEtablissement = "Etablissement_3" };
            context.Etablissement.AddOrUpdate(e => e.idEtablissement, etablissement_1, etablissement_2, etablissement_3);
           
            /* TypeQuestionnaire */
            MetierIdentification.Models.TypeQuestionnaire typeQuestionnaire_1 = new MetierIdentification.Models.TypeQuestionnaire { idType=1, libelleType = "Satisfaction" };
            MetierIdentification.Models.TypeQuestionnaire typeQuestionnaire_2 = new MetierIdentification.Models.TypeQuestionnaire { idType = 2, libelleType = "type camping" };
            MetierIdentification.Models.TypeQuestionnaire typeQuestionnaire_3 = new MetierIdentification.Models.TypeQuestionnaire { idType = 3, libelleType = "type gite" };
            context.TypeQuestionnaire.AddOrUpdate(t => t.idType, typeQuestionnaire_1, typeQuestionnaire_2, typeQuestionnaire_3);

            /* Questionnaire */
            MetierIdentification.Models.Questionnaire questionnaire_1 = new MetierIdentification.Models.Questionnaire { idQuestionnaire = 1, idType = 1, libelleQuestionnaire = "Evaluation des hotels par la méthode NPS", TypeQuestionnaire = typeQuestionnaire_1 };
            MetierIdentification.Models.Questionnaire questionnaire_2 = new MetierIdentification.Models.Questionnaire { idQuestionnaire = 2, idType = 2, libelleQuestionnaire = "Camping", TypeQuestionnaire = typeQuestionnaire_2 };
            MetierIdentification.Models.Questionnaire questionnaire_3 = new MetierIdentification.Models.Questionnaire { idQuestionnaire = 3, idType = 3, libelleQuestionnaire = "Gîte", TypeQuestionnaire = typeQuestionnaire_3 };
            context.Questionnaire.AddOrUpdate(q => q.idQuestionnaire, questionnaire_1, questionnaire_2, questionnaire_3);

            /* Audit */
            MetierIdentification.Models.Audit audit_1 = new MetierIdentification.Models.Audit { idAudit = 1, libelleAudit = "audit 1 Test", dateAudit = date1, idEtablissement = etablissement_1.idEtablissement, idQuestionnaire = questionnaire_1.idQuestionnaire };
            MetierIdentification.Models.Audit audit_2 = new MetierIdentification.Models.Audit { idAudit = 2, libelleAudit = "audit 2 Test", dateAudit = date2, idEtablissement = etablissement_2.idEtablissement, idQuestionnaire = questionnaire_2.idQuestionnaire };
            MetierIdentification.Models.Audit audit_3 = new MetierIdentification.Models.Audit { idAudit = 3, libelleAudit = "audit 3 Test", dateAudit = date3, idEtablissement = etablissement_3.idEtablissement, idQuestionnaire = questionnaire_3.idQuestionnaire };
            context.Audit.AddOrUpdate(a => a.idAudit, audit_1, audit_2, audit_3);

            /* SousSegment */
            context.SousSegment.AddOrUpdate(s => s.idSSegment,
               new MetierIdentification.Models.SousSegment { idSSegment = 1, idSegment = 1, libelleSSegment = "sous segment1" },
               new MetierIdentification.Models.SousSegment { idSSegment = 2, idSegment = 1, libelleSSegment = "sous segment2" },
               new MetierIdentification.Models.SousSegment { idSSegment = 3, idSegment = 1, libelleSSegment = "sous segment3" },
               new MetierIdentification.Models.SousSegment { idSSegment = 4, idSegment = 2, libelleSSegment = "sous segment4" },
               new MetierIdentification.Models.SousSegment { idSSegment = 5, idSegment = 2, libelleSSegment = "sous segment5" },
               new MetierIdentification.Models.SousSegment { idSSegment = 6, idSegment = 3, libelleSSegment = "sous segment6" },
               new MetierIdentification.Models.SousSegment { idSSegment = 7, idSegment = 3, libelleSSegment = "sous segment7" }
                );

            /* Segment */
            MetierIdentification.Models.Segment segment_1 = new MetierIdentification.Models.Segment { idSegment = 1, libelleSegment = "Busines" };
            List<MetierIdentification.Models.SousSegment> ss1 = new List<MetierIdentification.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(1));
            ss1.Add(context.SousSegment.Find(2));
            ss1.Add(context.SousSegment.Find(3));
            MetierIdentification.Models.Segment segment_2 = new MetierIdentification.Models.Segment { idSegment = 2, libelleSegment = "Social" };
            List<MetierIdentification.Models.SousSegment> ss2 = new List<MetierIdentification.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(4));
            ss1.Add(context.SousSegment.Find(5));
            MetierIdentification.Models.Segment segment_3 = new MetierIdentification.Models.Segment { idSegment = 3, libelleSegment = "Côte" };
            List<MetierIdentification.Models.SousSegment> ss3 = new List<MetierIdentification.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(6));
            ss1.Add(context.SousSegment.Find(7));
            context.Segment.AddOrUpdate(s => s.idSegment, segment_1, segment_2, segment_3);

            context.SaveChanges();

            /* Prestations */
            context.Prestations.AddOrUpdate(
               new MetierIdentification.Models.Banquet { idPrestation = 1, datePrestation = date1, libelleBanquet = "Banquet_1" },
               new MetierIdentification.Models.Banquet { idPrestation = 2, datePrestation = date1, libelleBanquet = "Banquet_2" },
               new MetierIdentification.Models.Banquet { idPrestation = 3, datePrestation = date1, libelleBanquet = "Banquet_3" },
               new MetierIdentification.Models.Seminaire { idPrestation = 4, datePrestation = date2, libelleSeminaire = "Séminaire_1" },
               new MetierIdentification.Models.Seminaire { idPrestation = 5, datePrestation = date2, libelleSeminaire = "Séminaire_2" },
               new MetierIdentification.Models.Seminaire { idPrestation = 6, datePrestation = date2, libelleSeminaire = "Séminaire_3" },
               new MetierIdentification.Models.Sejour { idPrestation = 7, datePrestation = date3, libelleSejour = "Séjour_1" },
               new MetierIdentification.Models.Sejour { idPrestation = 8, datePrestation = date3, libelleSejour = "Séjour_2" },
               new MetierIdentification.Models.Sejour { idPrestation = 9, datePrestation = date3, libelleSejour = "Séjour_3" }
            );

            context.SaveChanges();

            /*  listes de Prestations pour clients */
            List<MetierIdentification.Models.Banquet> listBanquet = new List<MetierIdentification.Models.Banquet>();
            List<MetierIdentification.Models.Seminaire> listSeminaire = new List<MetierIdentification.Models.Seminaire>();
            List<MetierIdentification.Models.Sejour> listSejour = new List<MetierIdentification.Models.Sejour>();

            MetierIdentification.Models.Client client_1 = new MetierIdentification.Models.Client { idClient = 1, nomClient = "John", idSegment = segment_1.idSegment, Segment = segment_1, idInvitation = invit_1.idInvitation, Invitation = invit_1 };
            listBanquet.Add(context.Banquet.Find(1));
            listSeminaire.Add(context.Seminaire.Find(4));
            listSejour.Add(context.Sejour.Find(7));
            context.Client.AddOrUpdate(c => c.idClient, client_1);
            context.SaveChanges();

            MetierIdentification.Models.Client client_2 = new MetierIdentification.Models.Client { idClient = 2, nomClient = "Sarah", idSegment = segment_2.idSegment, Segment = segment_2, idInvitation = invit_2.idInvitation, Invitation = invit_2 };
            listBanquet.Clear();
            listSeminaire.Clear();
            listSejour.Clear();
            listBanquet.Add(context.Banquet.Find(2));
            listSeminaire.Add(context.Seminaire.Find(5));
            listSejour.Add(context.Sejour.Find(8));
            context.Client.AddOrUpdate(c => c.idClient, client_2);
            context.SaveChanges();

            MetierIdentification.Models.Client client_3 = new MetierIdentification.Models.Client { idClient = 3, nomClient = "Briand", idSegment = segment_3.idSegment, Segment = segment_3, idInvitation = invit_3.idInvitation, Invitation = invit_3 };
            listBanquet.Clear();
            listSeminaire.Clear();
            listSejour.Clear();
            listBanquet.Add(context.Banquet.Find(3));
            listSeminaire.Add(context.Seminaire.Find(6));
            listSejour.Add(context.Sejour.Find(9));
            context.Client.AddOrUpdate(c => c.idClient, client_1, client_2, client_3);
            context.SaveChanges();

            /* Invitation => Client */
            List<MetierIdentification.Models.Client> listClient_1 = new List<MetierIdentification.Models.Client>();
            listClient_1.Add(context.Client.Find(1));
            List<MetierIdentification.Models.Client> listClient_2 = new List<MetierIdentification.Models.Client>();
            listClient_2.Add(context.Client.Find(2));
            List<MetierIdentification.Models.Client> listClient_3 = new List<MetierIdentification.Models.Client>();
            listClient_3.Add(context.Client.Find(3));
            invit_1 = new MetierIdentification.Models.Invitation { idInvitation = 1, libelleInvitation = "Invit 1", dateEvoi = date1, Clients = listClient_1 };
            invit_2 = new MetierIdentification.Models.Invitation { idInvitation = 2, libelleInvitation = "Invit 2", dateEvoi = date2, Clients = listClient_2 };
            invit_3 = new MetierIdentification.Models.Invitation { idInvitation = 3, libelleInvitation = "Invit 3", dateEvoi = date3, Clients = listClient_3 };
            context.Invitation.AddOrUpdate(i => i.idInvitation, invit_1, invit_2, invit_3);


            


           
        }
    }
}
