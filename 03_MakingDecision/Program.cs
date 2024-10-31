using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password= Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Şehir Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülke Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Bilgi");
            //}


            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 7)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}


            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Birinci sınav notunu girin: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sınav notunu girin: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınav notunu girin: ");
            //exam3 = int.Parse(Console.ReadLine());

            // average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Not Ortalamanız: " +  average);
            //if (average > 0 & average <= 50)
            //{
            //    result = "\nKötü";
            //}
            // if (average > 50 & average <= 70 )
            //{
            //    result = "\nOrta";
            //}
            //if (average > 84)
            //{
            //    result = "\nÇok İyi";
            //}
            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "bursa" | city == "izmir")
            //{
            //    Console.WriteLine("Şehir Bilgisi Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Bilgisi Yanlış");
            //}


            //Console.WriteLine("Kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin") 
            //{
            //    Console.WriteLine("Kullanıcı bilgisi yanlış");
            //}
            //else 
            //{
            //Console.WriteLine("Hoş Geldiniz...");
            //}

            //Console.Read();
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int result = sayi1 % sayi2;
            //Console.Write("Birinci sayinin ikinci sayiya bölümünden kalan: " + result);


            //Console.WriteLine("Lütfen sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //if (sayi % 2 == 0) 
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char takim;
            //Console.Write("Takım Karakteri giriniz: ");
            //takim = char.Parse(Console.ReadLine());
            //if (takim == 'g' |  takim == 'G') 
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (takim == 'f' | takim == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (takim == 'b' | takim == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else 
            //{
            //    Console.Write("Takim Yok");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("---Restorana Hoşgeldiniz---");
            //Console.WriteLine();

            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Tatlılar");
            //Console.WriteLine("4- İçecekler");

            //int secim;
            //Console.Write("Menü içeriğini görmek istediğiniz seçimi yapınız: ");
            //secim = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (secim == 1) 
            //{
            //    Console.WriteLine("------Ana Yemekler------");
            //    Console.WriteLine("***Köri Tavuk");
            //    Console.WriteLine("***Karnıyarık");
            //    Console.WriteLine("***Adana Kebap");
            //}
            //if (secim == 2)
            //{
            //    Console.WriteLine("------Çorbalar------");
            //    Console.WriteLine("***Tavuk Çorba");
            //    Console.WriteLine("***Merco");
            //    Console.WriteLine("***Ezo gelin");
            //}
            //if (secim == 3)
            //{
            //    Console.WriteLine("------Tatlılar------");
            //    Console.WriteLine("***Cheescake");
            //    Console.WriteLine("***Sebastian");
            //    Console.WriteLine("***Mozaik");
            //}
            //if (secim == 4)
            //{
            //    Console.WriteLine("------İçecekler------");
            //    Console.WriteLine("***Kola");
            //    Console.WriteLine("***Ayran");
            //    Console.WriteLine("***Su");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay bilgisi girin: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break ;
            //}

            #endregion

            #region  Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz:");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("1.sayıyı giriniz:");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarım: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme: " + result);
            //        break;

            //}

            #endregion


            Console.Read();
        }
    }
}
