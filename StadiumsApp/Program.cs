using System;
using System.Data.SqlClient;
using StadiumsApp.Models;
using StadiumsApp.Data;

namespace StadiumsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StadiumData stadiumData = new StadiumData();
            UserData userData = new UserData();
            Reservation reservations = new Reservation();

            var check = true;
            string ans;
            do
            {
                Console.WriteLine("1. Stadion əlavə et");
                Console.WriteLine("2. Stadionları göstər");
                Console.WriteLine("3. Verilmiş id-li stadionu göstər");
                Console.WriteLine("4. Verilmiş id-li stadionu sil");
                Console.WriteLine("5. İstifadəçi əlavə et");
                Console.WriteLine("6. İstifadəçiləri göstər");
                Console.WriteLine("7. Rezervasiyaları göstər");
                Console.WriteLine("8. Rezervasiya yarat");
                Console.WriteLine("9. Verilmiş id-li stadionun rezervasiyalarını göstər");
                ans = Console.ReadLine();

                switch (ans)
                {
                    case "1":
                        Console.WriteLine("inser");
                        byte cap = 4;
                        decimal price = 45;
                        string name = "stadion";

                        Stadium stadium = new Stadium
                        {
                            Capacity = cap,
                            Name = name,
                            HourlyPrice = price,
                        };

                        stadiumData.Add(stadium);
                        break;
                    case "2":
                        var stadiums = stadiumData.GetAll();

                        foreach (var item in stadiums)
                        {
                            Console.WriteLine(item.Id + " - " + item.Name + " - " + item.HourlyPrice);
                        }
                        break;

                    case "3":

                        Console.WriteLine("Id daxil et:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Stadium std = stadiumData.GetById(id);

                        Console.WriteLine(std.Name);
                        break;
                    case "4":
                        Console.WriteLine("Id daxil et:");
                        int iddel = Convert.ToInt32(Console.ReadLine());
                        stadiumData.Delete(iddel);
                        break;
                 

                       
                    case "6":
                        var users = userData.GetAll();

                        foreach (var item in users)
                        {
                            Console.WriteLine(item.Id + " - " + item.FullName + " - " + item.Emaile);
                        }
                        break;
                    


                    default:
                        break;
                }





            } while (check);
        }
    }
}
