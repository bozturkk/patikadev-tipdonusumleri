using System;

namespace TipDonusumleri // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion (bilinçsiz dönüşüm)
            //** düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli başka bir değişkene atanma işlemidir
            //** burada herhangibir şey yapmaya gerek yok aslında.
            //** çevirimi bizim yerimize makine yapmaktadır.
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            float d = a + b + c;
            //** eğer arada bir kapasite uyumsuzluğu olsaydı yani d bunlardan daha küçük bir değişken olsaydı bu atama işlemini yapamazdık.
            Console.WriteLine("byte türündeki a değerim  : {0}", a);
            Console.WriteLine("sbyte türündeki b değerim : {0}", b);
            Console.WriteLine("short türündeki c değerim : {0}", c);
            Console.WriteLine("int d değerine atanan a + b + c işlemi sonucu : {0}", d);
            
            string e = "Büşra";
            char k ='Ö';
            object o = e + k + d;
            Console.WriteLine(o);

            //explicit conversion (bilinçli dönüşüm)
            //** c# dönüştürmede bilinçli olarak yapılır.
            //** Convert , ToString, Parse ı kullanarak dönüşümü belirtmemiz gerekmektedir.

            int x = 4;
            byte y = Convert.ToByte(x);
            Console.WriteLine(y);
            int z = 100;
            byte t = Convert.ToByte(z);
            Console.WriteLine(t);
            float ondalikliDeğer = 10.3f;
            byte  ondalikliDonusumDeger = Convert.ToByte(ondalikliDeğer);
            Console.WriteLine(ondalikliDonusumDeger); // yuvarlar.
            //** çevrimlerde veri kaybı oluşabilir.

            //ToString

            int sayisalDeger = 10;
            string MetinselDonusum = sayisalDeger.ToString();
            Console.WriteLine(MetinselDonusum);

            string metinselDeger = (12.5f).ToString();
            Console.WriteLine(metinselDeger);
            
            byte r = 12;
            int r1 = Convert.ToInt32(r);

            string s1 = "10", s2="20";
            int sayi10, sayi11;
            int toplam;
            sayi10 = Convert.ToInt32(s1);
            sayi11 = Convert.ToInt32(21);
            toplam = sayi10 + sayi11;

            ParseMethod();

        }
        public static void ParseMethod ()
        {
            string metin1 = "10";
            string metin3 = "10.25";
            int rakam1;
            double double1;        
            rakam1 = Int32.Parse(metin1);
            Console.WriteLine(metin1);
            double1 = double.Parse(metin3);
            Console.WriteLine(double1);
            
        }
    }
}
