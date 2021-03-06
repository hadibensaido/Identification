﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierIdentification.Models
{
    public class TypeQuestionnaire
    {
        [Key]
        public int idType { get; set; }
        [Display(Name = "Type")]
        public string libelleType { get; set; }

        // les questionnaires d'un même type
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
    }
}