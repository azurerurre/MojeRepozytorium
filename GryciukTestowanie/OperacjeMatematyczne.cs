using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryciukTestowanie
{
    public class OperacjeMatematyczne
    {
        public int Dodaj(int liczbaA, int liczbaB)
        {
            return liczbaA + liczbaB;
        }

        public int Odejmij(int liczbaA, int liczbaB)
        {
            return liczbaA - liczbaB;
        }

        public int Mnoz(int liczbaA, int liczbaB)
        {
            return liczbaA * liczbaB;
        }

        public int Dziel(int liczbaA, int liczbaB)
        {
            if (liczbaB == 0)
                throw new ArgumentOutOfRangeException();
            return liczbaA / liczbaB;
        }
    }
}
