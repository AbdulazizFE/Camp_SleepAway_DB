using AbdulazizDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Models
{
    public class Methods
    {
        public static void CamperNextOfKinByCabin()
        {

            using (var db = new AppContextDB())
            {
                var result = from n in db.NextOfKins
                             join nc in db.CamperNextOfKins on n.NextOfKinID equals nc.NextOfKinID
                             join c in db.Campers on nc.CamperID equals c.CamperID
                             join cs in db.CamperStays on c.CamperID equals cs.CamperID
                             orderby cs.CabinName

                             select new
                             {
                                 c.CamperID,
                                 c.Camper_FirstName,
                                 n.NextOfKinID,
                                 n.Next_FirstName,
                                 cs.CabinID,
                                 cs.CabinName

                             };

                foreach (var x in result)
                {

                    Console.WriteLine("Camper ID: " + x.CamperID + "\t"
                        + "- Camper FirstName :" + x.Camper_FirstName + "\t"
                        + "- NextOfKin ID :" + x.NextOfKinID + "\t"
                        + "- NextOfKin FirstName : " + x.Next_FirstName + "\t" +
                        "- Cabin ID: " + x.CabinID + "\t"
                        +"- Cabin Name : " + x.CabinName
                        );
                }
            };
        }
        public static void ShowCampers()
        {
            using (var db = new AppContextDB())
            {
                var result = db.Campers.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : " + c.CamperID + "\t"
                        + "- FirstName : " + c.Camper_FirstName + "\t"
                        + "- LastName : " + c.Camper_LastName + "\t"
                        + "- Gender : " + c.Camper_Gender + "\t"
                        + "- Hobby : " + c.Camper_Hobby + "\t"
                        + "- Phone : " + c.Camper_Phone + "\t"
                        + "Age : " + c.Camper_Age
                        );
                }
            };
        }
        public static void ShowCabin()
        {
            using (var db = new AppContextDB())
            {
                var result = db.Cabins.Select(x => x).ToList();
               foreach(var c in result)
                {
                    Console.WriteLine("Cabin ID :" + c.CabinID +"\t"
                        +"Cabin Name :"+ c.CabinName +"\t" + "Cabasity :"+ c.Cabasity );
                }


            };
            }
        public static void ShowCounselor()
        {
            using (var db = new AppContextDB())
            {
                var result = db.Counselors.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : " + c.CounselorID + "\t"
                        + "- FirstName : " + c.Co_FirstName + "\t"
                        + "- LastName : " + c.Co_LastName + "\t"
                        + "- Gender : " + c.Co_Gender + "\t"
                        + "- Hobby : " + c.Co_Experience + "\t"
                        + "- Phone : " + c.Co_Phone

                        );
                }
            }
        }
        public static void SearshACamper()
        {
            using (var db = new AppContextDB())
            {
                string input = Console.ReadLine();
                var result = db.Cabins.Join(db.CamperStays, c1 => c1.CabinID, n => n.CabinID, (c1, n) => new
                {
                    //CabinINFO
                    Cabinid = c1.CabinID,
                    Cabinname = c1.CabinName,
                    //Camperstays
                    Arrivell = n.Arrivel,
                    Departedd = n.Departed,
                    Camid = n.CamperID,
                }).Join(db.Campers, c => c.Camid, d => d.CamperID, (c, d) => new{
                    //CabinINFO
                    Cabinid = c.Cabinid,
                    Cabinname = c.Cabinname,
                    //Camperstays
                    Arrivell = c.Arrivell,
                    Departedd = c.Arrivell,
                    Camid = c.Camid,
                    //CamperINFO
                    Camperid = d.CamperID,
                    Camperfirstname = d.Camper_FirstName,
                }).Where(x => x.Cabinname == input).ToList();
                if (result.Count() != 0)
                {
                    foreach (var x in result)
                    {
                        Console.WriteLine("Cabin id : " + x.Cabinid + "\t"
                            + "- Cabin name :" + x.Cabinname + "\t"
                            + "- Camper id :" + x.Camperid + "\t"
                            + "- Camper FirstName : " + x.Camperfirstname + "\t" +
                            "- Arrivel : " + x.Arrivell + "\t" + "- Departed : " + x.Departedd
                            );
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("We don't have camper or Counselor");
                }
            };
        }
        public static void ShowNextOfKin()
        {
            using (var db = new AppContextDB())
            {
                var result = db.NextOfKins.Select(x => x).ToList();

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
        }
        public static void SearshACounselor()
        {
            using (var db = new AppContextDB())
            {
                string input = Console.ReadLine();
                var result = db.Counselors.Join(db.CounselorStays, c1 => c1.CounselorID, n => n.CounselorID, (c1, n) => new
                {
                    //COINFO
                    COid = c1.CounselorID,
                    CoFirstName = c1.Co_FirstName,
                    //CoStays
                    Arrivell = n.Arrivel,
                    Departedd = n.Departed,
                    Cabinid = n.CabinID,
                }).Join(db.CamperStays, c => c.Cabinid, d => d.CamperStayID, (c, d) => new
              {
                  //COINFO
                  COid = c.COid,
                  CoFirstName = c.CoFirstName,
                  //CoStays
                  Arrivell = c.Arrivell,
                  Departedd = c.Departedd,
                  Cabinid = c.Cabinid,
                  //CamperstaysINFO
                  Arrivel = d.Arrivel,
                  Departed = d.Departed,
                  CabinName = d.CabinName,
                  Camperid = d.CamperID,
              }).Join(db.Campers, e => e.Camperid , f => f.CamperID, (e,f) => new {
                  //COINFO
                  COid = e.COid,
                  CoFirstName = e.CoFirstName,
                  //CoStays
                  Arrivell = e.Arrivell,
                  Departedd = e.Departedd,
                  Cabinid = e.Cabinid,
                  //CamperstaysINFO
                  Arrivel = e.Arrivel,
                  Departed = e.Departed,
                  Camperid = e.Camperid,
                  CabinName = e.CabinName,
                  //CamperINFO
                  CamperFirstName = f.Camper_FirstName
              }) .Where(x => x.CoFirstName == input).ToList();
                if (result.Count() != 0)
                {
                    foreach (var x in result)
                    {
                       Console.WriteLine("Counselors id : " + x.COid + "\t"
                            + "- Counselors FirstName :" + x.CoFirstName + "\t"
                            + "- Camper id :" + x.Camperid + "\t"
                            + "- Camper FirstName : " + x.CamperFirstName + "\t" +
                             "- Cabin ID : " + x.Cabinid + "\t" +
                              "- Cabin Name : " + x.CabinName + "\t" +
                            "- Arrivel : " + x.Arrivel + "\t" + "- Departed : " + x.Departed
                            );
                    }
                }

                else
                {
                    Console.WriteLine("We don't have camper or Counselor");

                }

            };
        }
    }
}

    

