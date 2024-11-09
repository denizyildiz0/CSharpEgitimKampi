using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net
            Console.WriteLine("****** C# Veri Tabanli Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparisler");
            Console.WriteLine("4-Çikis Yap");
            Console.Write("Lütfen getirmek istediginiz tablo numarasini giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------------");

            
         
            SqlConnection connection = new SqlConnection("Data Source=192.168.1.39,1433;Initial Catalog=EgitimKampiDB;User Id=SA;Password=reallyStrongPwd123;");
            
        
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item.ToString());
                    }
                    Console.WriteLine();
                }
            
            

            Console.Read();
        }
    }
}



