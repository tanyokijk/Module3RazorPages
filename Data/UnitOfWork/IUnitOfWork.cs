using Data.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;
    public interface IUnitOfWork
    {
        GenericRepository<Film> FilmsRepository { get; }

        GenericRepository<Style> StylesRepository { get; }

        GenericRepository<Session> SessionsRepository { get; }
    }
