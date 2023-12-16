using GestionEquipes.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipes.ApplicationCore.Interfaces
{
    public interface IServiceTrophee : IService<Trophee>
    {
        public DateTime DatePremierChampionnat(Equipe e);
    }
}
