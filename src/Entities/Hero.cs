using System.Diagnostics.Tracing;

namespace GFT.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set;}
        public int HP { get; set; }
        public int MP { get; set; }
        public Hero(string name, int level, string heroType, int hp, int mp)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HP = hp;
            this.MP = mp;
        }

        public override string ToString()
        {
            return  this.Name + " " + System.Environment.NewLine +
                    "   Lv. " + this.Level + " " + this.HeroType + System.Environment.NewLine +
                    "   HP   " + this.HP + System.Environment.NewLine+
                    "   MP   " + this.MP;
        }

        public virtual string Attack(int attack){
            return this.Name + " Atacou com a sua espada";
        }
    }
}