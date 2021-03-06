using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auta
{
    public class Auto
    {

        private int naklad;
        public int Naklad { get => naklad; }
        public string Znacka { get; }
        public int Nosnost { get; }

        public Auto(int nosnost, string znacka)
        {
            Nosnost = nosnost;
            Znacka = znacka;
        }

        public int Nalozit(int naklad)
        {
            var misto = Nosnost - Naklad;
            if (misto < naklad)
            {
                this.naklad += misto;
                return misto;               // throw new Exception("Naklad přesahuje nosnost."); Dá info že se to nedá přeložit a to je vše 
            }                               // pokud je mista v autě dost naloží to, když se přeskočí max nosnost tak se naloží jen do maxima a zbytek nenaloží
            else
            {
                this.naklad += naklad;
                return naklad;
            }
            
        }

        public int Vylozit(int naklda)
        {
            if (Naklad < naklad)
            {
                var vylozeni = Naklad;
                this.naklad = 0;
                return vylozeni;
            }
            else
            {
                this.naklad -= naklad;
                return naklad;
            }
        }

        public int Zaparkovat()
        {
            var vylozeni = Naklad;
            this.naklad = 0;
            return vylozeni;
        }


    }
}
