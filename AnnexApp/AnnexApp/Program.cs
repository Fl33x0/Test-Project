using System;
using System.Text.RegularExpressions;

namespace AnnexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Приложение А";

            Annex a = new Annex(s);
            Console.WriteLine("Результат метода Annex.ToString(): " + a.ToString());

            Console.WriteLine("");

            Annex b = a.GetNextAnnex();
            Console.WriteLine("Результат метода Annex.GetNextAnnex(): " + b.ToString());
        }
    }
}
