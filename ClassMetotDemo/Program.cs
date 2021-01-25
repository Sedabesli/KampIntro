using System;

namespace ClassMetotDemoOdev    
{
    class Program
    {
        static void Main(string[] args)
        {

            string musteriAdi = "Mehmet";
            string musteriSoyadi = "Ali";
            int musteriDoğumYili = 1997;
            int musteriId = 1234;

            string[] musteriler1 = new string[] { "Mehmet", "Merve" };


            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Ali";
            musteri1.DogumYılı = 1997;
            musteri1.Id = 1234;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Merve";
            musteri2.Soyadi = "Öz";
            musteri2.DogumYılı = 1960;
            musteri2.Id = 1235;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.DogumYılı);
                Console.WriteLine(musteri.Id);

            }

            Console.WriteLine("---------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
        }
    }
}
