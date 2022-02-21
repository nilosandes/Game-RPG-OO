namespace Game_RPG_OO
{
    public abstract class Hero
    {
        public string Name;
        public int level;
        public string HeroType;

        public Hero(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string ToString()
        {
            return this.Name + " " + this.level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}