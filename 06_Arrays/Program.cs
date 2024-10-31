using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı,mavi,mor
            //adana,ankara,istanbul
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[0] = "Mavi";
            //colors[0] = "Sarı";
            //colors[0] = "Yeşil";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[4];
            //cities[0] = "Milano";
            //cities[0] = "Budapeşte";
            //cities[0] = "Lyon";
            //cities[0] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];   
            //numbers[0] = 13;
            //numbers[1] = 27;
            //numbers[2] = 32;
            //numbers[3] = 49;
            //numbers[8] = 98;
            //numbers[9] = 56;
            //Console.WriteLine(numbers[5]);  //indexe değer ataması yapmazsam karşılık default değeri 0 dır.


            //string[] cities = { "Prag", "Roma", "Ankara" };  //buda diğer dizi tanımlaması
            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Mavi", "Yeşil", "Mor", "Pembe", "Beyaz", "Siyah" };

            //for (int i =0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 21, 39, 45,66,89,189,568,789,4555};
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', '+', '*', '-'};
            //for ( int i = 0; i < symbols.Length; i++ ) 
            //{
            //    Console.WriteLine(symbols[i] );
            //}

            //***********************************************************

            //EN BÜYÜK DEĞERİ YAZDIRMA
            //int[] myArray = { 34, 56, 78, 90, 124, 567, 598, 876, 982 };
            //int maxNumber = myArray[0];

            //for (int i =0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //***********************************************************

            //**LENGTH**  LİSTE UZUNLUĞU BULMA
            //string[] people = { "Ahmet", "Burak", "Deniz", "Ceren", "Damla" };
            //Console.WriteLine(people.Length);



            //**SORT**  KÜÇÜKTEN BÜYÜĞE SIRALAMA YAPAR
            //int[] numbers = { 47, 91, 15, 45, 6, 89, 9, 3, 77};
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //**REVERSE**  DİZİYİ TERSTEN YAZDIRIR
            //int[] numbers = { 47, 91, 15, 45, 6, 89, 9, 3, 77};
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotlar

            //**INDEX.OF**  DİZİ İÇERİSİNDE ARAMA YAPAR
            //string[] customers = {"ali", "ayşe", "ezgi", "sude", "eliz", "elçin" };
            //int index = Array.IndexOf(customers, "eliz");
            //Console.WriteLine(index);

            //**MİN** Dizinin en küçük elemanını verir
            //**MAX** Dizinin en büyük elemanını verir
            //int[] numbers = { 7, 14, 35, 43, 56, 89, 901 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "  Dizinin en küçük elemanı: " + numbers.Min());



            //**SUM** TOPLAMA METHODU
            //int[] numbers = {10, 20, 30, 40, 50};
            //int sum = 0;

            //for (int i = 0;  i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);
            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Girininiz:  ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");

            //for ( int i = 0; i < cities.Length;i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 39, 220 };

            //Console.WriteLine("Çift Sayılar: ");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("*************************************");

            //Console.WriteLine("Tek Sayılar: ");
            //Console.WriteLine();


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            #endregion

            Console.Read();
        }
    }
}
