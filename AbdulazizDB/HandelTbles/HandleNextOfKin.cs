using AbdulazizDB.Data;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.HandelTbles
{
    public class HandleNextOfKin
    {
        public static void AddNextOfKin()
        {
            Console.WriteLine("First Name :");
            string username = Console.ReadLine();
            Console.WriteLine("Last Name :");
            string userlastname = Console.ReadLine();
            Console.WriteLine("Phone :");
            string userphone = Console.ReadLine();
            Console.WriteLine("RealtionShip :");
            string userRealtionShip = Console.ReadLine();
            using (var db = new AppContextDB())
            {
                var C1 = new NextOfKin()

                {
                    Next_FirstName = username,
                    Next_LastName = userlastname,
                    Next_Phone = userphone,
                    RealtionShip = userRealtionShip,

                };
                db.NextOfKins.Add(C1);
                db.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("NextOfKins added");
            }
        }
        public static void RemoveNextOfKin()
        {
            using (var db1 = new AppContextDB())
            {
                var result = db1.NextOfKins.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : " + c.NextOfKinID + "\t"
                        + "- FirstName : " + c.Next_FirstName + "\t"
                        + "- LastName : " + c.Next_LastName + "\t"
                        + "- Phone: " + c.Next_Phone + "\t"
                        + "- RealtionShip : " + c.RealtionShip

                        );
                }


                Console.WriteLine("Wich nextOfKins id you want to remove ?");
                int userid = Convert.ToInt32(Console.ReadLine());
                using (var db = new AppContextDB())
                {
                    var C1 = new NextOfKin()
                    { NextOfKinID = userid };
                    db.Remove<NextOfKin>(C1);
                    db.SaveChanges();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("NextOfKin removde");
                }
            }
        }
        public static void UpdateNextOfKin()
            {
            using (var db1 = new AppContextDB())
            {
                var result = db1.NextOfKins.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : " + c.NextOfKinID + "\t"
                        + "- FirstName : " + c.Next_FirstName + "\t"
                        + "- LastName : " + c.Next_LastName + "\t"
                        + "- Phone: " + c.Next_Phone + "\t"
                        + "- RealtionShip : " + c.RealtionShip

                        );
                }

            }
            Console.WriteLine("Wich NextOfKin do you want to Update?\n" +
                    "Please select one of the NextOfKin ID : ");
                int userid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("First Name :");
                string username = Console.ReadLine();
                Console.WriteLine("Last Name :");
                string userlastname = Console.ReadLine();
                Console.WriteLine("Gender :");
                string usergener = Console.ReadLine();
                Console.WriteLine("Phone :");
                string userphone = Console.ReadLine();
                Console.WriteLine("RealtionShip :");
                string userRealtionShip = Console.ReadLine();
                using (var db = new AppContextDB())
                {
                    var C1 = new NextOfKin()
                    {
                        NextOfKinID = userid,
                        Next_FirstName = username,
                        Next_LastName = userlastname,
                        Next_Phone = userphone,
                        RealtionShip = userRealtionShip,
                    };
                    db.Update<NextOfKin>(C1);
                    db.SaveChanges();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("NextOfKin updated");
                }
            }
        }
    }
