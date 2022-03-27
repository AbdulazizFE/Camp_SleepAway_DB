using AbdulazizDB.Data;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB
{
    public class HandleCamper
    {
        public static void AddCamper ()
        {
            Console.WriteLine("Your First Name :");
            string username = Console.ReadLine();
            Console.WriteLine("Your Last Name :");
            string userlastname = Console.ReadLine();
            Console.WriteLine("Your Gender :");
            string usergener = Console.ReadLine();
            Console.WriteLine("Your Age :");
            int userage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Phone :");
            string userphone = Console.ReadLine();
            Console.WriteLine("Your Hobby :");
            string userHobby = Console.ReadLine();
            using (var db = new AppContextDB())
            {
                var C1 = new Camper()
                {
                    Camper_FirstName = username,
                    Camper_LastName = userlastname,
                    Camper_Gender = usergener,
                    Camper_Age = userage,
                    Camper_Phone = userphone,
                    Camper_Hobby = userHobby,
                };
                db.Campers.Add(C1);
                db.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Camper added");
            }

        }
        public static void RemoveCamper()
        {

            using (var db = new AppContextDB())
            {
                Console.WriteLine("Here is all Campers");
                var result = db.Campers.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : " + c.CamperID + "\t"
                        + "- FirstName :" + c.Camper_FirstName + "\t"
                        + "- LastName :" + c.Camper_LastName + "\t"
                        + "- Gender :" + c.Camper_Gender + "\t"
                        + "- Hobby :" + c.Camper_Hobby + "\t"
                        + "- Phone :" + c.Camper_Phone + "\t"
                        + "Age :" + c.Camper_Age
                        );
                }
            };

            Console.WriteLine("Wich camper id do you want to remove?");
            int userid = Convert.ToInt32(Console.ReadLine());
            using (var db = new AppContextDB())
            {
                var C1 = new Camper()
                {CamperID = userid};
                db.Remove<Camper>(C1);
                db.SaveChanges();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Camper removde");
            }
        }
        public static void UpdateCamper()
        {
            using (var db = new AppContextDB())
            {
                Console.WriteLine("Here is all Campers");
                var result = db.Campers.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : "+c.CamperID+"\t"
                        + "- FirstName :"+c.Camper_FirstName+"\t"
                        + "- LastName :"+ c.Camper_LastName+"\t"
                        + "- Gender :"+ c.Camper_Gender+"\t"
                        + "- Hobby :"+ c.Camper_Hobby+"\t"
                        + "- Phone :"+ c.Camper_Phone+"\t"
                        + "Age :"+c.Camper_Age
                        );
                }
            };
            Console.WriteLine("Wich camper id do you want to Update?");
            int userid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("New First Name your name :");
            string username = Console.ReadLine();
            Console.WriteLine("New Last Name your name :");
            string userlastname = Console.ReadLine();
            Console.WriteLine("New Gender :");
            string usergener = Console.ReadLine();
            Console.WriteLine("New Age :");
            int userage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("New Phone :");
            string userphone = Console.ReadLine();
            Console.WriteLine("New Hobby :");
            string userHobby = Console.ReadLine();
            using (var db = new AppContextDB())
            {
                var C1 = new Camper()
                {
                    CamperID = userid,
                    Camper_FirstName = username,
                    Camper_LastName = userlastname,
                    Camper_Gender = usergener,
                    Camper_Age = userage,
                    Camper_Phone = userphone,
                    Camper_Hobby = userHobby,
                };
                db.Update<Camper>(C1);
                db.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Camper updated");
            }
        }
    }
}
