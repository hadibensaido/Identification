﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierIdentification.Models
{
    public class Questionnaire
    {
        [Key]
        public int idQuestionnaire { get; set; }

        [Display(Name = "Libellé")]
        public string libelleQuestionnaire { get; set; }

        // Foreign key
        [ForeignKey("TypeQuestionnaire")]
        public int idType { get; set; }       
        public virtual TypeQuestionnaire TypeQuestionnaire { get; set; }
        
       // les audits relatifs à un questionnaire donné
       public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Reponse> Reponse { get; set; }

    }
}