using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierIdentification.Models
{
    public class Invitation
    {
        // Primary key 
        [Key]
        public  int idInvitation { get; set; }

        [Required]
        public DateTime dateEvoi { get; set; }

        [Required]
        [StringLength(30)]
        public String libelleInvitation { get; set; }
       
        [ForeignKey("Prestations")]
        public int idPrestations { get; set; }
        
        [ForeignKey("Questionnaire")]
        public int idQuestionnaire { get; set; }
        
        // Navigation property 
        public virtual ICollection<Client> Clients { get; set; }
        public virtual Prestations Prestations { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual Etablissement Etablissement { get; set; }
    }
}