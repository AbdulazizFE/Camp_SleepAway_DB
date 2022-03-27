using AbdulazizDB.Data;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.HandelTbles
{
    public class HandleCounselor
    {
        public static void AddCounselor()
        {
            Console.WriteLine("First Name :");
            string username = Console.ReadLine();
            Console.WriteLine("Last Name :");
            string userlastname = Console.ReadLine();
            Console.WriteLine("Gender :");
            string usergener = Console.ReadLine();
            Console.WriteLine("Phone :");
            string userphone = Console.ReadLine();
            Console.WriteLine("Experience :");
            string userExperience = Console.ReadLine();

            using (var db = new AppContextDB())
            {
                var C1 = new Counselor ()

                {
                    Co_FirstName = username,
                    Co_LastName = userlastname,
                    Co_Gender = usergener,
                    Co_Phone = userphone,
                    Co_Experience = userExperience,
                };

                db.Counselors.Add(C1);
                db.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Counselor added");
            }

        }
        public static void RemoveCounselor()
        {
            Console.WriteLine("Wich Counselor id do you want to remove ?");
            int userid = Convert.ToInt32(Console.ReadLine());
            using (var db = new AppContextDB())
            {
                var C1 = new Counselor()
                {CounselorID = userid};
                db.Remove<Counselor>(C1);
                db.SaveChanges();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Counselor removde");
            }
        }
        public static void UpdateCounselor()
        {
            Console.WriteLine("Wich Counselor you want to Update?\nPlease select one of Counselor id :");
            int userid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Name :");
            string username = Console.ReadLine();
            Console.WriteLine("Last Name :");
            string userlastname = Console.ReadLine();
            Console.WriteLine("Gender :");
            string usergener = Console.ReadLine();
            Console.WriteLine("Phone :");
            string userphone = Console.ReadLine();
            Console.WriteLine("Experience :");
            string userExperience = Console.ReadLine();
            using (var db = new AppContextDB())
            {
                var C1 = new Counselor()
                {
                    CounselorID = userid,
                    Co_FirstName = username,
                    Co_LastName = userlastname,
                    Co_Gender = usergener,
                    Co_Phone = userphone,
                    Co_Experience = userExperience,
                };
                db.Update<Counselor>(C1);
                db.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Counselor updated");
            }
        }
    }
}

