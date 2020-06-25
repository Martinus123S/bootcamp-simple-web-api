using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampIntern.Data
{
    public class CharacterSkill
    {
        public CharacterSkill(int characterId, int skillId)
        {
            CharacterId = characterId;
            SkillId = skillId;
        }

        public int Id { get; private set; }
        public int CharacterId { get; private set; }
        public int SkillId { get; private set; }
    }
}
