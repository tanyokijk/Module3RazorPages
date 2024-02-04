using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data;

public class UnitOfWork(List<Film> films, List<Style> styles, List<Session> sessions) : IUnitOfWork
{
    private GenericRepository<Film> filmsRepository;
    private GenericRepository<Style> stylesRepository;
    private GenericRepository<Session> sessionsRepository;

    public GenericRepository<Film> FilmsRepository
    {
        get
        {
            if (this.filmsRepository == null)
            {
                this.filmsRepository = new GenericRepository<Film>(films);
            }

            return filmsRepository;
        }
    }

    public GenericRepository<Style> StylesRepository
    {
        get
        {
            if (this.stylesRepository == null)
            {
                this.stylesRepository = new GenericRepository<Style>(styles);
            }

            return stylesRepository;
        }
    }

    public GenericRepository<Session> SessionsRepository
    {
        get
        {
            if (this.sessionsRepository == null)
            {
                this.sessionsRepository = new GenericRepository<Session>(sessions);
            }

            return sessionsRepository;
        }
    }
}
