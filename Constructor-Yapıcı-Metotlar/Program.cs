using System;

namespace Sınıf
{
    class Program
    {
        static void Main()
        {
            Calisan calisan1 = new Calisan("Furkan", "Yılmaz", 52423532, "Yazılım");
            calisan1.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan2 = new Calisan("Faruk", "Yılmaz", 52535325, "Güvenlik");
            //calisan2.Adi = "Faruk";
            //calisan2.Soyadi = "Yılmaz";
            //calisan2.No = 52335320;
            //calisan2.Departman = "Güvenlik";
            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Adi;
        public string Soyadi;
        public int No;
        public string Departman;

        public Calisan(string adi, string soyadi, int no, string departman)
        {
            this.Adi = adi;
            this.Soyadi = soyadi;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan() { }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın adı:{0}", Adi);
            Console.WriteLine("Çalışanın soyadı:{0}", Soyadi);
            Console.WriteLine("Çalışanın numarası:{0}", No);
            Console.WriteLine("Çalışanın departmanı:{0}", Departman);
        }
    }
}