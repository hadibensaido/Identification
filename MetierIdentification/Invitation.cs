using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime dateEnvoi { get; set; }

        [Required]
        [StringLength(30)]
        public string libelleInvitation { get; set; }

        // Navigation property 
        public virtual ICollection<Client> Clients { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

    }
}