using Business.Concrete;
using Entities.Concrete;

namespace Workaround1
{
    class Program
    {
        static void Main(string[] args)
        {
            //degiskenler();

            Vatandas vatandas = new Vatandas();

            SelamVer("Feyza");
            SelamVer("İsmail");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla();

            //Diziler / Arrays
            string[] ogrenciler = new string[3];

            ogrenciler[0] = "Feyza";
            ogrenciler[1] = "İsmail";
            ogrenciler[2] = "Amine";

            string[] ogrenciler1 = new[] { ogrenciler[0], ogrenciler[1], ogrenciler[2],"Şura" };
           
            for (int i=0; i<4; i++)
            {
                Console.WriteLine(ogrenciler1[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Feyza";
            person1.LastName = "Sözen";
            person1.DateOfBirthDay = 1997;
            person1.NationalIdentity = 1234;

            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler.Add("Adana 1");

            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        //resharper
        static void SelamVer(string isim="")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam"+sonuc.ToString());
            return sonuc;
        }

        private static void degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000;//db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;


            string ad = "Feyza";
            string soyad = "Sözen";
            int dogumyili = 1997;
            long tcNo = 12345678;

            Person person = new Person();

            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.10);
        }
    }

    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}