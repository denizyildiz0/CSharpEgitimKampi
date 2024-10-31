using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            // Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach(string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 45, 56, 78, 90, 453, 567, 357, 2, 456, 5678, 2234 };
            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 56, 78, 90, 453, 567, 357, 2, 456, 5678, 2234 };
            //foreach (int number in numbers) 
            //{
            //    if( number % 2 == 0 )
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 45, 56, 78, 90, 453, 567, 357, 2, 456, 5678, 2234 };
            //int total = 0;

            //foreach (int i in numbers) 
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //FOREACH SADECE DİZİ DEĞİL LİSTELERLEDE ÇALIŞIR
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8
            //};

            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}


            //KELİMELERİ PARÇALAMA
            //string word = "Merhaba";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}






            #endregion


            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınzda Kaç Öğrenci Var: ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////öğremnci isimlerini ve not ortalamalrını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i< studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //her öğrenci için 3 sınav girişi
            //    for (int j = 0; j<3; j++) 
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            ////Sınav Ortalamaları
            
            //for ( int i = 0; i < studentCount;i++) 
            //{
            //    Console.WriteLine("---------------------------------------");

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //   // öğrencielrin ortalaması ve geçip kalma durumları
            //   if (studentExamAvg[i]>=50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci geçti");
            //    }
            //   else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci kaldı");
            //    }
            //   Console.WriteLine("---------------------------------------") ;

            //}
            

            #endregion




            Console.Read();
        }
    }
}
