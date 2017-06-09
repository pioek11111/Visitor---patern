using System;

namespace SymulatorTerrarium
	{
	public class Skorpion : Drapieznik
		{
		public Skorpion(int energia)
			: base(energia)
			{
                
			}

		public override string Status()
			{
			return base.Status() + "/skorpion";
			}

		public static Skorpion ZLosowaEnergia(Random rand) => new Skorpion(rand.Next() % (30 - 5) + 5);

        public override void Eat(Zwierze z, Terrarium t)
        {
            if (t.Temperatura > 30)
            {
                //Console.WriteLine(this.Status() + " zjadla " + z.Status());
                this.DodajEnergie(this.Energia);
                z.WyzerujWielkosc();
            }
        }
        public override void Eat(Roslina r, Terrarium t)
        {
            return;
        }
    }
	}
