using AbdulazizDB.Data;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.HandelTbles
{
  public class HandleCabin
    {
        public static void AddCabin()
        {
            Console.WriteLine("Add a new Cabin name  :");
            string username = Console.ReadLine();
            Console.WriteLine("Cabasity :");
            int  userCabasity =Convert.ToInt32(Console.ReadLine());
         
            using (var db = new AppContextDB())
            {
                var C1 = new Cabin()
                {
                    CabinName = username,
                    Cabasity = userCabasity,   
                };

                db.Cabins.Add(C1);
                db.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cabin added");
            }
        }
        public static void RemoveCabin()
        {
            using (var db = new AppContextDB())
            {
                var result = db.Cabins.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("Cabin ID :" + c.CabinID + "\t"
                        + "Cabin Name :" + c.CabinName + "\t" + "Cabasity :" + c.Cabasity);
                }
            };

            Console.WriteLine("Wich cabin id you want to remove ?");
            int userid = Convert.ToInt32(Console.ReadLine());
            using (var db = new AppContextDB())
            {
                var C1 = new Cabin()
                {CabinID = userid};
                db.Remove<Cabin>(C1);
                db.SaveChanges();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Cabin has removd");
            }
        }
        public static void UpdateCabin()
        {
            using (var db = new AppContextDB())
            {
                var result = db.Cabins.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("Cabin ID :" + c.CabinID + "\t"
                        + "Cabin Name :" + c.CabinName + "\t" + "Cabasity :" + c.Cabasity);
                }
            };

            Console.WriteLine("Wich cabin id do you want to update?");
            int userid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add a new Cabin name  :");
            string username = Console.ReadLine();
            Console.WriteLine("New Cabasity :");
            int userCabasity = Convert.ToInt32(Console.ReadLine());

            using (var db = new AppContextDB())
            {
                var C1 = new Cabin()
                {
                    CabinID = userid,
                    CabinName = username,
                    Cabasity = userCabasity,
                };

                db.Update<Cabin>(C1);
                db.SaveChanges();
                Console.WriteLine("The Cabin has been updated");
            }
        }
    }
}
