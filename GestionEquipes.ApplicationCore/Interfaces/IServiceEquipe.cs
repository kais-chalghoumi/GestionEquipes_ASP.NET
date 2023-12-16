using GestionEquipes.ApplicationCore.Domain;
using GestionEquipes.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEquipes.ApplicationCore.Interfaces
{
    public interface IServiceEquipe : IService<Equipe>
    {
        double Recompense(Equipe e);
    }
}
