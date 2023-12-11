using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
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
        //Service2
        public IEnumerable<Joueur> JoueursTrophee(Trophee t)
        {
            IUnitOfWork utwk = new UnitOfWork(factory);
            var req = utwk.Repository<Contrat>().
                GetMany(c => c.EquipeFk == t.EquipeFK && (t.DateTrophee - c.DateContrat).Days < c.DureeMois * 30)
                .Select(c => c.Membre).OfType<Joueur>();
            return req;
        }

        //Service3
        public IEnumerable<Entraineur> EntraineurEquipe(Equipe e)
        {
            IUnitOfWork utwk = new UnitOfWork(factory);
            return utwk.Repository<Contrat>().
                GetMany(c => c.EquipeFk == e.EquipeId).
                Select(c => c.Membre).OfType<Entraineur>();
        }
        
        //Service4
        public DateTime DatePremierChampionnat(Equipe e)
        {
            IUnitOfWork utwk = new UnitOfWork(factory);
            return utwk.Repository<Trophee>().
                   GetMany(t => t.TypeTrophee == "Championnat" && t.EquipeFK == e.EquipeId).
                   OrderBy(t => t.DateTrophee).
                   Select(t => t.DateTrophee).First();
        }

        public String EquipeMaxTrophees()
        {
            var req = from e in GetAll()
                      orderby e.Trophees.Count
                      select e.NomEquipe;
            return req.First();
        }

        //public double Recompense(Equipe e)
        //{
        //    throw new NotImplementedException();
        //}

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

        IEnumerable<Equipe> IService<Equipe>.GetAll()
        {
            throw new NotImplementedException();
        }

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
