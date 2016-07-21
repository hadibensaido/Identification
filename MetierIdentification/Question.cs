using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MetierIdentification.Models
{
    public class Question
    {
        [Key]
        public int idQuestion { get; set; }
        public string libelleQuestion { get; set; }

        //les réponses relatives à la question

        public virtual ICollection<Reponse> Reponses { get; set; }
     //   public virtual Questionnaire Questionnaire { get; set; }
    }
}