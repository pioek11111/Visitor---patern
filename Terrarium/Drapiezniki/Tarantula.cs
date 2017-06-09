using System;

namespace SymulatorTerrarium
{
    public class Tarantula : Drapieznik
    {
        public Tarantula(int energia)
            : base(energia)
        {
        }

        public override string Status()
        {
            return base.Status() + "/tarantula";
        }

        public static Tarantula ZLosowaEnergia(Random rand) => new Tarantula(rand.Next() % (15 - 5) + 5);

        public override void Eat(Zwierze z, Terrarium t)
        {
            if (z.PoziomSmaku() > 0.7 && t.Temperatura >= 25 && t.Temperatura < 40)
            {
                //Console.WriteLine(this.Status() + " zjadla " + z.Status());
                this.DodajEnergie(this.Energia);
                z.WyzerujWielkosc();
            }
        }
        public override void Eat(Roslina r, Terrarium t)
        {
            if (r.CzyMiekkie() && t.Temperatura >= 25 && t.Temperatura < 40)
            {
                //Console.WriteLine(this.Status() + " zjadla " + r.Status());
                this.DodajEnergie(r.Wielkosc);
                r.WyzerujWielkosc();
            }
        }
    }
}

