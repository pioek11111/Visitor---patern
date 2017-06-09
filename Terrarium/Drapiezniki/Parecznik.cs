using System;

namespace SymulatorTerrarium
	{
	public class Parecznik : Drapieznik
		{
		public Parecznik(int energia)
			: base(energia)
			{
			}

		public override string Status()
			{
			return base.Status() + "/parecznik";
			}

		public static Parecznik ZLosowaEnergia(Random rand) => new Parecznik(rand.Next() % (40 - 20) + 20);

        public override void Eat(Zwierze z, Terrarium t)
        {
            Random r = new Random();
            int rand = r.Next(1, 3);
            if (z.PoziomSmaku() > 0.5 && t.Temperatura >= 1 && t.Temperatura < 5 && rand == 1)
            {
                //Console.WriteLine(this.Status() + " zjadla " + z.Status());
                this.DodajEnergie(this.Energia);
                z.WyzerujWielkosc();
            }
        }
        public override void Eat(Roslina r, Terrarium t)
        {
            if (!r.CzyMiekkie() && t.Temperatura >= 5 && t.Temperatura < 20)
            {
                //Console.WriteLine(this.Status() + " zjadla " + r.Status());
                this.DodajEnergie(r.Wielkosc);
                r.WyzerujWielkosc();
            }
        }
    }
	}

