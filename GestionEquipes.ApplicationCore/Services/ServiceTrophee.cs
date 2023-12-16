using GestionEquipes.ApplicationCore.Domain;
using GestionEquipes.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipes.ApplicationCore.Services
{
    public class ServiceTrophee : Service<Trophee>, IServiceTrophee
    {
        public ServiceTrophee(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //Service4
        public DateTime DatePremierChampionnat(Equipe e)
        {
            return GetMany(t => t.TypeTrophee == "Championnat" && t.EquipeFK == e.EquipeId).
                   OrderBy(t => t.DateTrophee).
                   Select(t => t.DateTrophee).First();
        }
    }
}
