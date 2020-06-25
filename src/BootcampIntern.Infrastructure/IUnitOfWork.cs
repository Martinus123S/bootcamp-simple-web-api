using BootcampIntern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampIntern.Infrastructure
{
    public interface IUnitOfWork
    {
        IRepository<Character> Characters { get; }
        IRepository<CharacterSkill> CharacterSkills { get; }
        IRepository<Skill> Skills { get; }
        void Commit();
    }
}
