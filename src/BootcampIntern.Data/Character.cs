namespace BootcampIntern.Data
{
    public class Character
    {
        public Character(string name, int gender)
        {
            Name = name;
            Gender = gender;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Gender { get; private set; }
    }
}
