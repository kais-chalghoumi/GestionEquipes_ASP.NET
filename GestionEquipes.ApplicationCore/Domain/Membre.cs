﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipes.ApplicationCore.Domain
{
    public class Membre
    {
        [Key]
        public int Identifiant { get; set; }
        [Required(ErrorMessage ="Champs obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Champs obligatoire")]
        public string Prenom { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNaisssance { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }
    }
}
