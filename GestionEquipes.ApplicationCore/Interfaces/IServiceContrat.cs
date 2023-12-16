using GestionEquipes.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipes.ApplicationCore.Interfaces
{
    public interface IServiceContrat : IService<Contrat>
    {
        public IEnumerable<Joueur> JoueursTrophee(Trophee t);
        public IEnumerable<Entraineur> EntraineurEquipe(Equipe e);
    }
}
