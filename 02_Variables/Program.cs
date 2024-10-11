using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        public static double result { get; private set; }

        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 5.17;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Manav Fiyat Listesi");
            //Console.WriteLine();

            //double applePrice, bananaPrice, patatoPrice, carrotPrice;

            //applePrice = 10.90;
            //bananaPrice = 20.50;
            //patatoPrice = 21.30;
            //carrotPrice = 8.90;

            //Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----Muz Birim Fiyatı: " + bananaPrice + " TL");
            //Console.WriteLine("----Patates Birim Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("----Havuç Birim Fiyatı: " + carrotPrice + " TL");

            //double appleGram, bananaGram, patatoGram, carrotGram;
            //appleGram = 4.867;
            //bananaGram = 3.750;
            //patatoGram = 5.500;
            //carrotGram = 1.200;

            //double totalApplePrice = applePrice * applePrice;
            //double totalBananaPrice = bananaPrice * bananaPrice;
            //double totalPatatoPrice = patatoPrice * bananaPrice;
            //double totalCarrotPrice = carrotPrice * carrotPrice;

            //Console.WriteLine();
            //Console.WriteLine("----- Manav Fişi -----");
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice +" - Gramaj: " + appleGram + " - Toplam Tutar: " + totalApplePrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + patatoPrice + " - Gramaj: " + patatoGram + " - Toplam Tutar: " + totalPatatoPrice);
            //Console.WriteLine("Alınan Ürün: Havuç - " + "Birim Fiyat: " + carrotPrice + " - Gramaj: " + carrotGram + " - Toplam Tutar: " + totalCarrotPrice);
            //Console.WriteLine("Alınan Ürün: Muz - " + "Birim Fiyat: " + bananaPrice + " - Gramaj: " + bananaGram + " - Toplam Tutar: " + totalBananaPrice);

            //double shoppingTotal = totalApplePrice + totalBananaPrice + totalCarrotPrice + totalPatatoPrice;

            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotal + " TL");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string pessengerName, pessengerSurname, pessengerAge, pessengerCity, pessengerID;
            //Console.Write("Yolcu Adı: ");
            //pessengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //pessengerSurname = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //pessengerID = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //pessengerAge = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //pessengerCity = Console.ReadLine();


            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine("Yolcu Bilgisi: " + pessengerName + " " + pessengerSurname + " " + pessengerAge + " " + pessengerID + " " + pessengerCity);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int pcPrice, klavyePrice, monitörPrice, kameraPrice;
            //pcPrice = 50000;
            //klavyePrice = 2000;
            //monitörPrice = 10000;
            //kameraPrice = 5000;

            //int pcCount, klavyeCount, monitörCount, kameraCount;

            //Console.Write("Lütfen aldığınız pc sayısını girin:");
            //pcCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız klavye sayısını girin:");
            //klavyeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız monitör sayısını girin:");
            //monitörCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız kamera sayısını girin:");
            //kameraCount = int.Parse(Console.ReadLine());

            //int totalPrice = pcPrice * pcCount + klavyePrice * klavyeCount + kameraPrice * kameraCount + monitörPrice * monitörCount;
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " +  totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.Write("Not Ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = Char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " +  gender);
            #endregion 



            Console.Read();
        }
    }
}
