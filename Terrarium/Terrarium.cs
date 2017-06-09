using System;
using System.Linq;
using System.Collections.Generic;

namespace SymulatorTerrarium
{
    public class Terrarium
    {
        readonly private Random rand;

        public List<Drapieznik> ListaDrapieznikow { get; }

        public List<Pozywienie> ListaPozywienia { get; }

        public int Temperatura { get; set; }

        public Terrarium(Random rand)
        {
            ListaDrapieznikow = new List<Drapieznik>();
            ListaPozywienia = new List<Pozywienie>();
            Temperatura = 35;
            this.rand = rand;
        }

        public void DodajLosoweDrapiezniki(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var r = rand.Next(0, 3);
                if (r == 0)
                    ListaDrapieznikow.Add(Skorpion.ZLosowaEnergia(rand));
                if (r == 1)
                    ListaDrapieznikow.Add(Parecznik.ZLosowaEnergia(rand));
                if (r == 2)
                    ListaDrapieznikow.Add(Tarantula.ZLosowaEnergia(rand));
            }
        }

        public void DodajLosowePozywienie(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var r = rand.Next(0, 4);
                if (r == 0)
                    ListaPozywienia.Add(Zuk.LosowaWielkosc(rand));
                if (r == 1)
                    ListaPozywienia.Add(Salata.LosowaWielkosc(rand));
                if (r == 2)
                    ListaPozywienia.Add(Pszenica.LosowaWielkosc(rand));
                if (r == 3)
                    ListaPozywienia.Add(Mysz.LosowaWielkosc(rand));
                
            }
        }

        public void Symuluj(int steps)
        {
            for (int i = 0; i < steps; ++i)
                Krok();
        }

        private void Krok()
        {
            for (int i = ListaDrapieznikow.Count-1; i >= 0; i--)
            {
                ListaDrapieznikow[i].UzyjEnergii();
                if (ListaDrapieznikow[i].Energia <= 0)
                    ListaDrapieznikow.RemoveAt(i);
            }
            for (int i = ListaPozywienia.Count - 1; i >= 0; i--)
            {
                if (ListaPozywienia[i].Wielkosc == 0)
                    ListaPozywienia.RemoveAt(i);                
            }
            foreach (var p in ListaPozywienia)
            {
                p.Rosnij();
            }                

            foreach (var d in ListaDrapieznikow)
            {
                foreach (var p in ListaPozywienia)
                {
                    p.ZjedzMnie(d, this);
                }
            }
            
        }
    }
}
