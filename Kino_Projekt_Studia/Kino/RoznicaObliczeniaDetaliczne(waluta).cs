using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    public class RoznicaObliczeniaDetaliczna : RoznicaObliczenia
    {
        public string Waluta { get; set; }

        public RoznicaObliczeniaDetaliczna()
        {
            Waluta = "PLN"; // Domyślna waluta
        }

        public override double ObliczRoznice()
        {
            // Można tutaj dodać dodatkową logikę, np. konwersję waluty
            return base.ObliczRoznice();
        }

        public string ObliczRozniceZWaluta()
        {
            double roznica = ObliczRoznice();
            return $"{roznica.ToString("0.00")} {Waluta}";
        }
    }
}

