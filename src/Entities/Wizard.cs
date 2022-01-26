namespace GFT.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
        }

        public override string Attack(int bonus)
        {
            this.MP = MP - bonus;
            if(bonus > 5){
            return this.Name + " Lançou Magia super efetiva de: " + bonus;
            }else{

                return this.Name + " Lançou Magia fraca de: " + bonus;
            }
        }
    }
}