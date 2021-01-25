using System;

namespace ETicaretOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Name = "Bilgisayar";
            urun1.Brand = "Lenovo";
            urun1.Price = 8000;

            Urun urun2 = new Urun();
            urun2.Name = "Telefon";
            urun2.Brand = "Samsung";
            urun2.Price = 4000;

            Urun urun3 = new Urun();
            urun3.Name = "Televizyon";
            urun3.Brand = "LG";
            urun3.Price = 6000;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Name +"/"+urun.Brand +":"+urun.Price);
            }
            Console.WriteLine("-----foreach bitti ------");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Name + "/" + urunler[i].Brand +":" + urunler[i].Price);
            }
            Console.WriteLine("-----for bitti ------");

            int a = 0;
            while (a<urunler.Length)
            {
                Console.WriteLine(urunler[a].Name + "/" + urunler[a].Brand + ":" + urunler[a].Price+ a++ ) ;
            }
            Console.WriteLine("-----while bitti ------");
        }
    }
    class Urun
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
    }
}
