using System;
using System.Diagnostics.CodeAnalysis;

namespace initial_commit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ulamekl nowyulame = new ulamekl(14,7);
            ulamekl nowyulame2 = new ulamekl(3,6);
            Console.WriteLine(nowyulame);
            var d = nowyulame + nowyulame2;
            var o = nowyulame - nowyulame2;
            Console.WriteLine(d);
            Console.WriteLine(o);
            
            Console.WriteLine(nowyulame.Equals(nowyulame2));
            Console.WriteLine(nowyulame.CompareTo(nowyulame2));
            Console.WriteLine(nowyulame.licznik2);
            Console.WriteLine( nowyulame.zaokrDol());
            Console.WriteLine(nowyulame.zaokrGora());

        }

    }
    class ulamekl: IEquatable<ulamekl>, IComparable<ulamekl>
    {
        
        private int licznik { get; set; }
        public int licznik2 { get => licznik; }




        private int mianownik { get; set; }
        public int mianownik2 { get => mianownik; }

        public ulamekl()
        {
            licznik = 5;
            mianownik = 2;
        }
        public ulamekl(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }
        public ulamekl(ulamekl copyulamekl)
        {
            this.licznik = copyulamekl.licznik;
            this.mianownik = copyulamekl.mianownik;
        }
        public override string ToString()
        {
            return $"licznnik to {licznik} mianownik to {mianownik}";
        }

        public bool Equals(ulamekl other)
        {
            if(licznik==other.licznik && mianownik == other.mianownik)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }

        public int CompareTo(ulamekl other)
        {
            if(((double)licznik/ (double)mianownik2)>((double)other.licznik/ (double)other.mianownik))
            {
                return +1;
            }
           else if (((double)licznik / (double)mianownik2) < ((double)other.licznik / (double)other.mianownik))
            {
                return -1;
            }
            return 0;
        }

        public static ulamekl operator +(ulamekl o, ulamekl u) => new ulamekl(o.licznik * u.mianownik + u.licznik * o.mianownik, o.mianownik * u.mianownik);
        public static ulamekl operator -(ulamekl o, ulamekl u) => new ulamekl(o.licznik * u.mianownik - u.licznik * o.mianownik, o.mianownik * u.mianownik);
        public static ulamekl operator *(ulamekl o, ulamekl u) => new ulamekl(o.licznik*u.licznik,o.mianownik*u.mianownik);
        public static ulamekl operator /(ulamekl u, ulamekl w) => new ulamekl(u.licznik * w.mianownik, u.mianownik * w.licznik);
                 

        public int zaokrDol()
        {
            return (int)(licznik / mianownik);
        }
        public int zaokrGora()
        {   
            if(licznik%mianownik ==0)
                return (int)(licznik / mianownik);
            else
            return (int)(licznik / mianownik)+1;
            
        }

    }
}
