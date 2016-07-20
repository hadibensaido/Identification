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



            DateTime date1 = DateTime.Parse("05/27/2016", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.Parse("06/21/2016", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date3 = DateTime.Parse("07/23/2016", System.Globalization.CultureInfo.InvariantCulture);


            /* Invitation */
            MetierIdentification.Models.Invitation invit_1 = new MetierIdentification.Models.Invitation { idInvitation = 1, libelleInvitation = "Invit 1", dateEvoi = date1 };
            MetierIdentification.Models.Invitation invit_2 = new MetierIdentification.Models.Invitation { idInvitation = 2, libelleInvitation = "Invit 2", dateEvoi = date2 };
            MetierIdentification.Models.Invitation invit_3 = new MetierIdentification.Models.Invitation { idInvitation = 3, libelleInvitation = "Invit 3", dateEvoi = date3 };
            context.Invitation.AddOrUpdate(i => i.idInvitation, invit_1, invit_2, invit_3);

            context.SousSegment.AddOrUpdate(s => s.idSSegment,
               new MetierIdentification.Models.SousSegment { idSSegment = 1, idSegment = 1, libelleSSegment = "sous segment1" },
               new MetierIdentification.Models.SousSegment { idSSegment = 2, idSegment = 1, libelleSSegment = "sous segment2" },
               new MetierIdentification.Models.SousSegment { idSSegment = 3, idSegment = 1, libelleSSegment = "sous segment3" },
               new MetierIdentification.Models.SousSegment { idSSegment = 4, idSegment = 2, libelleSSegment = "sous segment4" },
               new MetierIdentification.Models.SousSegment { idSSegment = 5, idSegment = 2, libelleSSegment = "sous segment5" },
               new MetierIdentification.Models.SousSegment { idSSegment = 6, idSegment = 3, libelleSSegment = "sous segment6" },
               new MetierIdentification.Models.SousSegment { idSSegment = 7, idSegment = 3, libelleSSegment = "sous segment7" }
                );


            MetierIdentification.Models.Segment s1 = new MetierIdentification.Models.Segment { idSegment = 1, libelleSegment = "Busines" };
            List<MetierIdentification.Models.SousSegment> ss1 = new List<MetierIdentification.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(1));
            ss1.Add(context.SousSegment.Find(2));
            ss1.Add(context.SousSegment.Find(3));
            MetierIdentification.Models.Segment s2 = new MetierIdentification.Models.Segment { idSegment = 2, libelleSegment = "Social" };
            List<MetierIdentification.Models.SousSegment> ss2 = new List<MetierIdentification.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(4));
            ss1.Add(context.SousSegment.Find(5));
            MetierIdentification.Models.Segment s3 = new MetierIdentification.Models.Segment { idSegment = 3, libelleSegment = "Côte" };
            List<MetierIdentification.Models.SousSegment> ss3 = new List<MetierIdentification.Models.SousSegment>();
            ss1.Add(context.SousSegment.Find(6));
            ss1.Add(context.SousSegment.Find(7));
            context.Segment.AddOrUpdate(s => s.idSegment, s1, s2, s3);

            context.SaveChanges();


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


            /* K.A              
            * Question */
            MetierIdentification.Models.Question question_1 = new MetierIdentification.Models.Question { idQuestion = 1, libelleQuestion = "Quelle est la probabilité que vous recommandiez l'entreprise Aston à un ami ou à un collègue ?" };
             context.Question.AddOrUpdate(i => i.idQuestion, question_1);

            /* K.A
             * Type Questionnaire */
            MetierIdentification.Models.TypeQuestionnaire typequestionnaire_1 = new MetierIdentification.Models.TypeQuestionnaire { idType = 1, libelleType = "Satisfaction" };
            context.Question.AddOrUpdate(i => i.idQuestion, question_1);

            /* K.A
             * Liste de questions ratachées au questionnaire N°1 */
            List<MetierIdentification.Models.Question> listQuestion = new List<MetierIdentification.Models.Question>();
            listQuestion.Add(question_1);

            /* K.A
             * Questionnaire */
            MetierIdentification.Models.Questionnaire questionnaire_1 = new MetierIdentification.Models.Questionnaire { idQuestionnaire = 1, libelleQuestionnaire = "Evaluation des hotels par la méthode NPS", TypeQuestionnaire= typequestionnaire_1 };
            context.Questionnaire.AddOrUpdate(i => i.idQuestionnaire, questionnaire_1);


            /* Prestations pour clients *//*
            List<MetierIdentification.Models.Banquet> listBanquet = new List<MetierIdentification.Models.Banquet>();
            List<MetierIdentification.Models.Seminaire> listSeminaire = new List<MetierIdentification.Models.Seminaire>();
            List<MetierIdentification.Models.Sejour> listSejour = new List<MetierIdentification.Models.Sejour>();

            MetierIdentification.Models.Client client_1 = new MetierIdentification.Models.Client { idClient = 1, nomClient = "John", Segment = s1, Invitation = invit_1 };
            listBanquet.Add(context.Banquet.Find(1));
            listSeminaire.Add(context.Seminaire.Find(4));
            listSejour.Add(context.Sejour.Find(7));
            context.Client.AddOrUpdate(c => c.idClient, client_1);
            context.SaveChanges();
            /*
                        MetierIdentification.Models.Client client_2 = new MetierIdentification.Models.Client { idClient = 2, nomClient = "Sarah", Segment = s2, Invitation = invit_2 };
                        listBanquet.Clear();
                        listSeminaire.Clear();
                        listSejour.Clear();
                        listBanquet.Add(context.Banquet.Find(2));
                        listSeminaire.Add(context.Seminaire.Find(5));
                        listSejour.Add(context.Sejour.Find(8));
                        context.Client.AddOrUpdate(c => c.idClient, client_2);
                        context.SaveChanges();
            /*
                        MetierIdentification.Models.Client client_3 = new MetierIdentification.Models.Client { idClient = 3, nomClient = "Briand", Segment = s3, Invitation = invit_3 };
                        listBanquet.Clear();
                        listSeminaire.Clear();
                        listSejour.Clear();
                        listBanquet.Add(context.Banquet.Find(3));
                        listSeminaire.Add(context.Seminaire.Find(6));
                        listSejour.Add(context.Sejour.Find(9));
                        context.Client.AddOrUpdate(c => c.idClient, client_1, client_2, client_3);
                        context.SaveChanges();*/

            /* Invitation => Client *//*
            MetierIdentification.Models.Invitation invit_1 = new MetierIdentification.Models.Invitation { idInvitation = 1, libelleInvitation = "Invit 1", dateEvoi = date1, Clients  = client_1 };
            MetierIdentification.Models.Invitation invit_2 = new MetierIdentification.Models.Invitation { idInvitation = 2, libelleInvitation = "Invit 2", dateEvoi = date2 };
            MetierIdentification.Models.Invitation invit_3 = new MetierIdentification.Models.Invitation { idInvitation = 3, libelleInvitation = "Invit 3", dateEvoi = date3 };
            context.Invitation.AddOrUpdate(i => i.idInvitation, invit_1, invit_2, invit_3);
        */
        }
    }
}
