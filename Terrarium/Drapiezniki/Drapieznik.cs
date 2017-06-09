using System;

namespace SymulatorTerrarium
{
	public abstract class Drapieznik
	{
		public int Energia { get; private set; }

		public Drapieznik (int energia)
		{			
			Energia = energia;
		}

		public void UzyjEnergii()
		{
			Energia -= 5;
		}

		public void DodajEnergie(int ilosc)
		{
			Energia += ilosc;
		}

		public virtual string Status()
		{
			return string.Format("drapieznik(energia={0})", Energia);
		}

        public abstract void Eat(Zwierze z, Terrarium t);
        public abstract void Eat(Roslina r, Terrarium t);
    }
}

