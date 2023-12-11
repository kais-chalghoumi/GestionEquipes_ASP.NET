using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceEquipe : IService<Equipe>
    {
        double Recompense(Equipe e);
    }
}
