namespace BootcampIntern.Data
{
    public class Skill
    {
        public Skill(string name, int power, int magicCost)
        {
            Name = name;
            Power = power;
            MagicCost = magicCost;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Power { get; private set; }
        public int MagicCost { get; private set; }
    }
}
