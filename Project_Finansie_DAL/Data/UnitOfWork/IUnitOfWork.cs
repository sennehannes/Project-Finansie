using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project_Finansie_DAL.Data.Repositorys;
using Project_Finansie_DAL.DomainModel;

namespace Project_Finansie_DAL.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<DomainModel.Betalingen> BetalingenRepo { get; }
        IRepository<DomainModel.Ontvangste> OntvangsteRepo { get; }
        IRepository<DomainModel.Users> UsersRepo { get; }
        int save();
    }
}
