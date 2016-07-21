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


            /* Question */
            int cptQuestions = 1;
            /* Les questions relatives aux enquêtes de satisfaction client */
            MetierIdentification.Models.Question question_1 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Recommanderiez-vous notre établissement à vos amis ou collègues  ?" };
            question_1.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_1.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 1, idQuestion = cptQuestions,  idReponse = i, Question = question_1 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_2 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Globalement êtes vous satisfait de votre séjour dans notre établissement  ?" };
            question_2.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_2.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 1, idQuestion = cptQuestions, idReponse = i, Question = question_2 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_3 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Comment évaluez-vous votre satisfaction au regard du service en général  ?" };
            question_3.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_3.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 1, idQuestion = cptQuestions, idReponse = i, Question = question_3 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_4 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Comment évaluez-vous votre satisfaction au regard de la propreté en général  ?" };
            question_4.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_4.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 1, idQuestion = cptQuestions, idReponse = i, Question = question_4 });
            }
            cptQuestions++;
            context.Question.AddOrUpdate(i => i.idQuestion, question_4);
            MetierIdentification.Models.Question question_5 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Comment évaluez-vous votre satisfaction au regard de l'accueil en général  ?" };
            question_5.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_5.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 1, idQuestion = cptQuestions, idReponse = i, Question = question_5 });
            }
            cptQuestions++;
            context.Question.AddOrUpdate(i => i.idQuestion, question_1, question_2, question_3, question_4, question_5);

           
            /* les questions de l'audit produit et service (réponse C/NC) */
            MetierIdentification.Models.Question question_AP001 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Lors de votre réservation par téléphone, le/la réceptionniste a décroché avant la 5eme sonnerie ?" };
            question_AP001.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP001.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP001 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP002 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "La chambre était-elle équipée d'un téléphone ?" };
            question_AP002.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP002.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP002 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP003 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "La chambre était-elle équipée de 2 lampes de chevet ?" };
            question_AP003.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP003.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP003 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP004 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "La chambre était-elle équipée d'un bureau ?" };
            question_AP004.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP004.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP004 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP005 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "La propreté des rideaux" };
            question_AP005.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP005.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP005 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP006 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "La propreté de la SDB" };
            question_AP006.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP006.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP006 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP007 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Les nuisances sonores" };
            question_AP007.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP007.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP007 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP008 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "La musique d'ambiance dans les couloirs" };
            question_AP008.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP008.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP008 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP009 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "L'établissement est-il équipé d'un parking" };
            question_AP009.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP009.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP009 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP010 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Lors de votre réservation par téléphone, le/la réceptionniste a décroché avant la 5eme sonnerie ?" };
            question_AP010.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP010.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP010 });
            }
            cptQuestions++;
            MetierIdentification.Models.Question question_AP011 = new MetierIdentification.Models.Question { idQuestion = cptQuestions, libelleQuestion = "Lors de votre réservation par téléphone, le/la réceptionniste a décroché avant la 5eme sonnerie ?" };
            question_AP011.Reponses = new List<MetierIdentification.Models.Reponse>();
            for (int i = 1; i <= 10; i++)//les reponses de 1 à 10
            {
                question_AP011.Reponses.Add(new MetierIdentification.Models.Reponse { idQuestionnaire = 2, idQuestion = cptQuestions, idReponse = i, Question = question_AP011 });
            }
            cptQuestions++;

            context.Question.AddOrUpdate(i => i.idQuestion, question_AP001, question_AP002, question_AP003, question_AP004, question_AP005, question_AP006, question_AP007, question_AP008, question_AP009, question_AP010, question_AP011);


            /* K.A
             * Liste de questions ratachées au questionnaire N°1 *//*
            List<MetierIdentification.Models.Question> listQuestion = new List<MetierIdentification.Models.Question>();
            listQuestion.Add(question_1);

            /* les dates */
            DateTime date1 = DateTime.Parse("05/27/2016", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.Parse("06/21/2016", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date3 = DateTime.Parse("07/23/2016", System.Globalization.CultureInfo.InvariantCulture);
            
            /* Invitation */
            MetierIdentification.Models.Invitation invit_1 = new MetierIdentification.Models.Invitation { idInvitation = 1, libelleInvitation = "Invit 1", dateEnvoi = date1 };
            MetierIdentification.Models.Invitation invit_2 = new MetierIdentification.Models.Invitation { idInvitation = 2, libelleInvitation = "Invit 2", dateEnvoi = date2 };
            MetierIdentification.Models.Invitation invit_3 = new MetierIdentification.Models.Invitation { idInvitation = 3, libelleInvitation = "Invit 3", dateEnvoi = date3 };
            context.Invitation.AddOrUpdate(i => i.idInvitation, invit_1, invit_2, invit_3);
            
            /* Etablissement */
            MetierIdentification.Models.Etablissement etablissement_1 = new MetierIdentification.Models.Etablissement { idEtablissement = 1, libelleEtablissement = "Etablissement_1"};
            MetierIdentification.Models.Etablissement etablissement_2 = new MetierIdentification.Models.Etablissement { idEtablissement = 2, libelleEtablissement = "Etablissement_2" };
            MetierIdentification.Models.Etablissement etablissement_3 = new MetierIdentification.Models.Etablissement { idEtablissement = 3, libelleEtablissement = "Etablissement_3" };
            context.Etablissement.AddOrUpdate(e => e.idEtablissement, etablissement_1, etablissement_2, etablissement_3);
            
            /* TypeQuestionnaire */
            MetierIdentification.Models.TypeQuestionnaire typeQuestionnaire_1 = new MetierIdentification.Models.TypeQuestionnaire { idType=1, libelleType = "Satisfaction" };
            MetierIdentification.Models.TypeQuestionnaire typeQuestionnaire_2 = new MetierIdentification.Models.TypeQuestionnaire { idType = 2, libelleType = "Audit" };
            //MetierIdentification.Models.TypeQuestionnaire typeQuestionnaire_3 = new MetierIdentification.Models.TypeQuestionnaire { idType = 3, libelleType = "Gîte" };
            context.TypeQuestionnaire.AddOrUpdate(t => t.idType, typeQuestionnaire_1, typeQuestionnaire_2);

            /* Questionnaire */
            MetierIdentification.Models.Questionnaire questionnaire_1 = new MetierIdentification.Models.Questionnaire { idQuestionnaire = 1, idType = 1, libelleQuestionnaire = "Evaluation des hotels par la méthode NPS", TypeQuestionnaire = typeQuestionnaire_1 };
            questionnaire_1.Questions = new List<MetierIdentification.Models.Question>();
            questionnaire_1.Questions.Add(question_1);
            questionnaire_1.Questions.Add(question_2);
            questionnaire_1.Questions.Add(question_3);
            questionnaire_1.Questions.Add(question_4);
            questionnaire_1.Questions.Add(question_5);
            MetierIdentification.Models.Questionnaire questionnaire_2 = new MetierIdentification.Models.Questionnaire { idQuestionnaire = 2, idType = 2, libelleQuestionnaire = "produit et service", TypeQuestionnaire = typeQuestionnaire_2 };
            questionnaire_2.Questions = new List<MetierIdentification.Models.Question>();
            questionnaire_2.Questions.Add(question_AP001);
            questionnaire_2.Questions.Add(question_AP002);
            questionnaire_2.Questions.Add(question_AP003);
            questionnaire_2.Questions.Add(question_AP004);
            questionnaire_2.Questions.Add(question_AP005);
            questionnaire_2.Questions.Add(question_AP006);
            questionnaire_2.Questions.Add(question_AP007);
            questionnaire_2.Questions.Add(question_AP008);
            questionnaire_2.Questions.Add(question_AP009);
            questionnaire_2.Questions.Add(question_AP010);
            questionnaire_2.Questions.Add(question_AP011);
            //MetierIdentification.Models.Questionnaire questionnaire_3 = new MetierIdentification.Models.Questionnaire { idQuestionnaire = 3, idType = 3, libelleQuestionnaire = "ISO", TypeQuestionnaire = typeQuestionnaire_2 };
            //questionnaire_3.Questions = new List<MetierIdentification.Models.Question>();
            context.Questionnaire.AddOrUpdate(q => q.idQuestionnaire, questionnaire_1, questionnaire_2);

            /* Audit */
            MetierIdentification.Models.Audit audit_1 = new MetierIdentification.Models.Audit { idAudit = 1, libelleAudit = "audit 1 Test", dateAudit = date1, idEtablissement = etablissement_1.idEtablissement, idQuestionnaire = questionnaire_1.idQuestionnaire };
            MetierIdentification.Models.Audit audit_2 = new MetierIdentification.Models.Audit { idAudit = 2, libelleAudit = "audit 2 Test", dateAudit = date2, idEtablissement = etablissement_2.idEtablissement, idQuestionnaire = questionnaire_2.idQuestionnaire };
          //  MetierIdentification.Models.Audit audit_3 = new MetierIdentification.Models.Audit { idAudit = 3, libelleAudit = "audit 3 Test", dateAudit = date3, idEtablissement = etablissement_3.idEtablissement, idQuestionnaire = questionnaire_3.idQuestionnaire };
            context.Audit.AddOrUpdate(a => a.idAudit, audit_1, audit_2);

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
            segment_1.SSegments = new List<MetierIdentification.Models.SousSegment>();
            segment_1.SSegments.Add(context.SousSegment.Find(1));
            segment_1.SSegments.Add(context.SousSegment.Find(2));
            segment_1.SSegments.Add(context.SousSegment.Find(3));
            MetierIdentification.Models.Segment segment_2 = new MetierIdentification.Models.Segment { idSegment = 2, libelleSegment = "Social" };
            segment_2.SSegments = new List<MetierIdentification.Models.SousSegment>();
            segment_2.SSegments.Add(context.SousSegment.Find(4));
            segment_2.SSegments.Add(context.SousSegment.Find(5));
            MetierIdentification.Models.Segment segment_3 = new MetierIdentification.Models.Segment { idSegment = 3, libelleSegment = "Côte" };
            segment_3.SSegments = new List<MetierIdentification.Models.SousSegment>();
            segment_3.SSegments.Add(context.SousSegment.Find(6));
            segment_3.SSegments.Add(context.SousSegment.Find(7));
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
            invit_1.Clients = new List<MetierIdentification.Models.Client>();
            invit_1.Clients.Add(context.Client.Find(1));
            invit_2.Clients = new List<MetierIdentification.Models.Client>();
            invit_2.Clients.Add(context.Client.Find(2));
            invit_3.Clients = new List<MetierIdentification.Models.Client>();
            invit_3.Clients.Add(context.Client.Find(3));
            context.Invitation.AddOrUpdate(i => i.idInvitation, invit_1, invit_2, invit_3);


            


           
        }
    }
}
