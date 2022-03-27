using AbdulazizDB.Data;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.HandelTbles
{
    public class HandleCamperStay
    {
        public static void CheckInCamperStay()
        {
            Console.WriteLine("This is all cabin ");
            using (var db = new AppContextDB())
            {
                var result = db.Cabins.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : " + c.CabinID + "\t" + " - CabinName : " + c.CabinName);
                }
                Console.WriteLine("Wich cabin do you want to stay?");
                string usercabin = Console.ReadLine();
                var result1 = db.CamperStays.Where(x => x.CabinName == usercabin).Count();
                Console.WriteLine("In this cabin there are {0} campers ", result1);
                var result2 = db.CamperStays.Where(c => (c.CabinName == usercabin)).Select(c => new
                {
                    ArrivelDate = c.Arrivel,
                    DepartedDate = c.Departed,
                }).ToList();

                foreach (var c in result2)
                {
       Console.WriteLine("Arrivel Date : " + c.ArrivelDate + "\t"
           + "Departed Date :" + c.DepartedDate);
                }

                if (result1 < 4)
                {
                    Console.WriteLine("You can stay here");
                    Console.WriteLine("CabinName :");
                    string usercabinname = Console.ReadLine();
                    Console.WriteLine("CabinID :");
                    int usercabinid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("CamperID :");
                    int usercamperid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Arrivel :");
                    DateTime userArrivel = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Departed :");
                    DateTime userDeparted = Convert.ToDateTime(Console.ReadLine());
                    using (var db1 = new AppContextDB())
                    {
                        var C1 = new CamperStay()

                        {
                            CabinName = usercabinname,
                            CabinID = usercabinid,
                            CamperID = usercamperid,
                            Arrivel = userArrivel,
                            Departed = userDeparted
                        };

                        db1.CamperStays.Add(C1);
                        db1.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Camper added");
                    }
                }

                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Cabin is full");
                }
            };
        }
        public static void CheckOutCamperStay()
        {
            Console.WriteLine("This is all Camper in the cabin ");
            using (var db = new AppContextDB())
            {
                var result = db.CamperStays.Join(db.Campers, a => a.CabinID, b => b.CamperID, (a, b) => new
                {
                    //CamperStays
                    a.CabinID,
                    a.Arrivel,
                    a.Departed,
                    a.CamperStayID,
                    //Camper
                    b.CamperID,
                    b.Camper_FirstName,
                    b.Camper_Gender
                }).Join(db.Cabins, q => q.CamperID, m => m.CabinID, (q, m) => new {
                        //CamperStays
                        q.CabinID,
                        q.Arrivel,
                        q.Departed,
                        q.CamperStayID,
                        //Camper
                        q.CamperID,
                        q.Camper_FirstName,
                        q.Camper_Gender,
                        //Cabins
                        m.CabinName
                    }).OrderBy(x => x.Camper_FirstName).ToList();

                foreach (var c in result)
                {
                    Console.WriteLine("CamperStays ID : " + c.CamperStayID + "\t" + "Cabin ID : " + c.CabinID + "\t" + " Cabin Name : " + c.CabinName + "\t " + " Camper ID : " + c.CamperID
                        + "\t" + c.Camper_FirstName + "\t" + c.Camper_Gender + "\t" + c.Arrivel + "\t" + c.Departed);

                }

                Console.WriteLine("Wich Camper do you want to remove ?");
                int userCaid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entre CamperStays ID :");
                int usercamperstaysid = Convert.ToInt32(Console.ReadLine());
                var result1 = db.CamperStays.Where(x =>x.CamperStayID ==usercamperstaysid).Count();
                if (result1 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    using (var db1 = new AppContextDB())
                    {
                        var C1 = new CamperStay()

                        {
                            CamperStayID = usercamperstaysid,
                            CamperID = userCaid
                        };

                        db.Remove<CamperStay>(C1);
                        db.SaveChanges();
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("Camper removde");
                    }
                }
                else
                {
                    Console.WriteLine("HELLOOOOO");
                }
            }
        }
    }
}