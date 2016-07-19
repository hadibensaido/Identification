using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierIdentification.Models
{
    public class Utilisateur
    {
        // Primary key 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idUtilisateur { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Veuillez renseigner votre nom")]
        public string nomUtilisateur { get; set; }

        // Navigation properties 
        ICollection<Profil> profil { get; set; }
    }
}