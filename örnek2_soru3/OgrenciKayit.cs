using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek2_soru3
{
    class OgrenciKayit
    {
        public string ad { get; set; }
        public int arasinav { get; set; }
        public int final { get; set; }
        public double toplamPuan { get; set; }
        public char not { get; set; }

        public void veriGir()
        {
            Console.Write("Ad Giriniz:");
            ad = Console.ReadLine();
            Console.Write("Arasınav notunuzu giriniz: ");
            arasinav = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunuzu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
        }
        public void setToplam()
        {
   
            toplamPuan = (60 * final) / 100 + (40 * arasinav) / 100;
        }
        public void setNot()
        {
            if (toplamPuan >= 85)
                not = 'A';
            else if (toplamPuan >= 70 && toplamPuan < 85)
                not = 'B';
            else if (toplamPuan >= 60 && toplamPuan < 70)
                not = 'C';
            else if (toplamPuan >= 50 && toplamPuan < 60)
                not = 'D';
            else
                not = 'F';

            
        }

        public void ciktiYaz()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Ad: "+ad);
            Console.WriteLine("Arasınav Notu: "+arasinav);
            Console.WriteLine("Final Notu: "+final);
            Console.WriteLine("Toplam Puan: "+toplamPuan);
            Console.WriteLine("Harf Notu:  "+not);
            Console.WriteLine("*********************");
        }

    }
}
