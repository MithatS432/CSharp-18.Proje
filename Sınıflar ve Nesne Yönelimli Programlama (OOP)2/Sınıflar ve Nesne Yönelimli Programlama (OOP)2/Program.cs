using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar_ve_Nesne_Yönelimli_Programlama__OOP_2
{
    internal class Program
    {

        class BankaHesabi
        {
            // Fields
            private string hesapSahibi;
            private decimal bakiye;

            // Properties
            public string HesapSahibi
            {
                get { return hesapSahibi; }
                set { hesapSahibi = value; }
            }

            public decimal Bakiye
            {
                get { return bakiye; }
                private set { bakiye = value; } // dışarıdan sadece okunabilir
            }

            // Constructor
            public BankaHesabi(string hesapSahibi, decimal ilkBakiye)
            {
                this.hesapSahibi = hesapSahibi;
                this.bakiye = ilkBakiye;
            }

            // Methods
            public void ParaYatir(decimal miktar)
            {
                if (miktar > 0)
                    bakiye += miktar;
                else
                    Console.WriteLine("Geçersiz tutar.");
            }

            public void ParaCek(decimal miktar)
            {
                if (miktar > 0 && miktar <= bakiye)
                    bakiye -= miktar;
                else
                    Console.WriteLine("Yetersiz bakiye veya geçersiz tutar.");
            }

            public void HesapOzeti()
            {
                Console.WriteLine($"Hesap Sahibi: {hesapSahibi} - Bakiye: {bakiye}₺");
            }
        }
        static void Main(string[] args)
        {
            BankaHesabi hesap = new BankaHesabi("Mithat", 1000m);

            hesap.HesapOzeti();
            hesap.ParaYatir(250m);
            hesap.ParaCek(300m);
            hesap.HesapOzeti();

            // hesap.Bakiye = 9999m; // Derleme hatası çünkü set private
        }
    }
}
