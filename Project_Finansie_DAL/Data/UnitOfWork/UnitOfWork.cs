using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Finansie_DAL.DomainModel;
using Project_Finansie_DAL.Data.Repositorys;

namespace Project_Finansie_DAL.Data.UnitOfWork
{
    class UnitOfWork
    {
        #region attributen
        public IRepository<Betalingen> _betalingenRepo;

        public IRepository<Ontvangste> _ontvangsteRepo;

        public IRepository<Users> _usersRepo;

        #endregion

        public UnitOfWork(Finansie_Enteties finansie_Entities)
        {
            this.Finansie_Enteties = finansie_Entities;
        }

        private Finansie_Enteties Finansie_Enteties { get; }

        #region repositories

        public IRepository<Betalingen> BetalingenRepo
        {
            get
            {
                if (_betalingenRepo == null)
                {
                    _betalingenRepo = new Repository<Betalingen>(this.Finansie_Enteties);
                }
                return _betalingenRepo;
            }
        }

        public IRepository<Ontvangste> OntvangsteRepo
        {
            get
            {
                if (_ontvangsteRepo == null)
                {
                    _ontvangsteRepo = new Repository<Ontvangste>(this.Finansie_Enteties);
                }
                return _ontvangsteRepo;
            }
        }

        public IRepository<Users> UsersRepo
        {
            get
            {
                if (_usersRepo == null)
                {
                    _usersRepo = new Repository<Users>(this.Finansie_Enteties);
                }
                return _usersRepo;
            }
        }

        #endregion
    }
}
