using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    public class RoznicaObliczenia
    {
        public double KwotaDoZaplaty { get; set; }
        public double KwotaOtrzymana { get; set; }

        public virtual double ObliczRoznice()
        {
            return KwotaOtrzymana - KwotaDoZaplaty;
        }
    }
}
