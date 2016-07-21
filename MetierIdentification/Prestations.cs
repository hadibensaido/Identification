using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierIdentification.Models
{
    public abstract class Prestations
    {
        [Key]
        public int idPrestation { get; set; }
        [Required]
        public DateTime datePrestation { get; set; }

        // Navigation property
        public virtual Etablissement Etablissement { get; set; }
        public virtual Client Client { get; set; }
    }
}