using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Halil";
            ogrenci.Soyad = "Özcan";
            ogrenci.Ogrenci_no = 200905050;
            ogrenci.Sinif = 6;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Hakan", "Söylemez", 1, 200905032);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
            
        }
    }

    class Ogrenci
    {
        string ad;
        string soyad;
        int sinif;
        int ogrenci_no;

        public string Ad { get => ad; set => ad = value; } // get ismi return ediyor, set ise value değerini atıyor
        public string Soyad { get => soyad; set => soyad = value; }
        public int Sinif { 

            get => sinif; 
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("sınıf değeri 1  den küçük olamaz");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
               
            } 
            }
        public int Ogrenci_no { get => ogrenci_no; set => ogrenci_no = value; }

         public Ogrenci(string ad, string soyad, int sinif, int ogrenci_no)
        {
            Ad = ad;
            Soyad = soyad;
            Sinif = sinif;
            Ogrenci_no = ogrenci_no;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******** Öğrenci Bilgileri ***********");
            Console.WriteLine("Ögrenci Adı:  {0}", this.Ad);
            Console.WriteLine("Ögrenci Soyadı: {0}", this.Soyad);
            Console.WriteLine("Öğrenci Okul Numarasi: {0}", this.Ogrenci_no);
            Console.WriteLine("Öğrenci Sinifi: {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif -1;
        }

        
    }
}
