using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek2_soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            OgrenciKayit kayit = new OgrenciKayit();
            kayit.veriGir();
            kayit.setToplam();
            kayit.setNot();
            kayit.ciktiYaz();
            Console.ReadKey();

        }
    }
}
