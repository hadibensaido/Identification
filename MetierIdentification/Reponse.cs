﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierIdentification.Models
{
    public class Reponse
    {
        
       
        [Key]
        public int idReponse { get; set; }
        public string reponse { get; set; }
        public string commentaire { get; set; }

        // Foreign key la question concernée
        
        [ForeignKey("Question")]
        public int idQuestion { get; set; }

        [ForeignKey("Invitation")]
        public int idInvitation { get; set; }

        
        
        public virtual Question Question { get; set; }
        public virtual Invitation Invitation { get; set; }
    }
}