using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer--> Listele, ekle, sil, güncelle
            //Void

            //Üzerinde kilit simgeli küp methodun private olduğunu söyler.
            //Metotlar programcıya mor renkte küp ile gösterilir.
            //Programı tekrar eden kod kalabalığından kurtarmak için kullanılır.


            //void CustomerList()
            //{
            //    Console.WriteLine("Deniz Yıldız");
            //    Console.WriteLine("Damla Yıldırım");
            //    Console.WriteLine("Ezgi Demir");
            //    Console.WriteLine("Mina Güneş");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Deniz Yıldız");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Sude", "Güneş");
            //CustomerCard("Damla", "Yıldız");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);


            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye Değer Döndüren String Paremetreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2) 
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(13, 26));
            //Console.WriteLine(Sum(18, 29));
            //Console.WriteLine(Sum(45, 74));
            //Console.WriteLine(Sum(65, 87));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50) 
            //    {
            //        return student + " isimli öğrenci geçti" + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci başarısız" + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 35, 26, 78));
            //Console.WriteLine(ExamResult("Ayşe", 75, 36, 98));

            #endregion

            Console.Read();

        }
    }
}
