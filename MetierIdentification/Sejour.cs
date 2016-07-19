using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierIdentification.Models
{
    public class Sejour:Prestations
    {

        public int libelleSejour { get; set; }

    }
}