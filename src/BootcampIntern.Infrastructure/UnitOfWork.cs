using BootcampIntern.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampIntern.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BootcampLegendDbContext _dbContext;
        private IRepository<Character> _characters;
        private IRepository<CharacterSkill> _characterSkills;
        private IRepository<Skill> _skills;

        public UnitOfWork(BootcampLegendDbContext dbContext, IServiceProvider serviceProvider)
        {
            _dbContext = dbContext;
            _characters = serviceProvider.GetService<IRepository<Character>>();
            _characterSkills = serviceProvider.GetService<IRepository<CharacterSkill>>();
            _skills = serviceProvider.GetService<IRepository<Skill>>();
        }

        public IRepository<Character> Characters
        {
            get
            {
                return _characters ??
                    (_characters = new BaseRepository<Character>(_dbContext));
            }
        }

        public IRepository<CharacterSkill> CharacterSkills
        {
            get
            {
                return _characterSkills ??
                    (_characterSkills = new BaseRepository<CharacterSkill>(_dbContext));
            }
        }

        public IRepository<Skill> Skills
        {
            get
            {
                return _skills ??
                    (_skills = new BaseRepository<Skill>(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
