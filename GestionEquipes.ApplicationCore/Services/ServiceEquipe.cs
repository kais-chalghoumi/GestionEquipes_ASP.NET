using GestionEquipes.ApplicationCore.Domain;
using GestionEquipes.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipes.ApplicationCore.Services
{
    public class ServiceEquipe:Service<Equipe>, IServiceEquipe
    {
        public ServiceEquipe(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        //Service1
        public double Recompense(Equipe e) 
        {
            var req = e.Trophees;
            double somme = 0;
            foreach (Trophee t in req)
                somme = somme + t.Recompense;
            return somme;
        }

        public String EquipeMaxTrophees()
        {
            var req = from e in GetAll()
                      orderby e.Trophees.Count
                      select e.NomEquipe;
            return req.First();
        }

        public void Add(Equipe entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Equipe entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Equipe entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<Equipe, bool>> where)
        {
            throw new NotImplementedException();
        }

        Equipe IService<Equipe>.GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        //IEnumerable<Equipe> IService<Equipe>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Equipe> GetMany(System.Linq.Expressions.Expression<Func<Equipe, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Equipe Get(System.Linq.Expressions.Expression<Func<Equipe, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
