using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioanalisiLibrary
{
    public class Class1
    {
        public static bool IsDetermined(int età, double numerobattiti)
        {
            int frequenza_cardiaca = 0;
            frequenza_cardiaca = 220 - età;

            double minimo = 0;
            double massimo = 0;
            bool risultato = false;

            minimo = frequenza_cardiaca * 70 / 100;
            massimo = frequenza_cardiaca * 90 / 100;

            if (numerobattiti > minimo && numerobattiti < massimo)
            {
                risultato = true;
            }
            else
            {
                risultato = false;
            }

            return risultato;
        }

        public static string IsDetermined1(double numerobattiti)
        {

            string risultato = "";

            if (numerobattiti < 60)
            {
                risultato = "Bradicardia";
            }

            if (numerobattiti >= 60 && numerobattiti <= 100)
            {
                risultato = "Normale";
            }

            if (numerobattiti > 100)
            {
                risultato = "Tachicardia";
            }
            return risultato;
        }
}   }
