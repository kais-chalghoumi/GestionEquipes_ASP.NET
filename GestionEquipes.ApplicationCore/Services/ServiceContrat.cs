using GestionEquipes.ApplicationCore.Domain;
using GestionEquipes.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipes.ApplicationCore.Services
{
    public class ServiceContrat : Service<Contrat>, IServiceContrat
    {
        public ServiceContrat(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //Service2
        public IEnumerable<Joueur> JoueursTrophee(Trophee t)
        {
            var req = GetMany(c => c.EquipeFk == t.EquipeFK && (t.DateTrophee - c.DateContrat).Days < c.DureeMois * 30)
                .Select(c => c.Membre).OfType<Joueur>();
            return req;
        }

        //Service3
        public IEnumerable<Entraineur> EntraineurEquipe(Equipe e)
        {
            return GetMany(c => c.EquipeFk == e.EquipeId).
                Select(c => c.Membre).OfType<Entraineur>();
        }
    }
}
