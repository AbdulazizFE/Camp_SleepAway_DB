using AbdulazizDB.Data;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.HandelTbles
{
    public class HandleCounselorStays
    {
        public static void ChekInCounselorInCabin()
        {
            Console.WriteLine("This is all cabin ");
            using (var db = new AppContextDB())
            {
                var result = db.Cabins.Select(x => x).ToList();
                foreach (var c in result)
                {
                    Console.WriteLine("ID : " + c.CabinID + "\t" + "  Cabin ID : " + c.CabinName);
                }
                Console.WriteLine("In Wich cabin do you want to stay?");
                int usercabinid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Plase write the cabin id : ");
                var result1 = db.CounselorStays.Where(x => x.CabinID == usercabinid).Count();
                Console.WriteLine("In this cabin there are {0} Counselor ", result1);
                if (result1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You can stay here");
                    Console.WriteLine("Counselor ID :");
                    int userCounselorID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Arrivel :");
                    DateTime userArrivel = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Departed :");
                    DateTime userDeparted = Convert.ToDateTime(Console.ReadLine());
                    var result2 =db.CounselorStays.Where(x => x.CounselorID == userCounselorID).Where(x => x.Arrivel == userArrivel).Count();
                    if (result2 == 0)
                    {

                  
                    Console.WriteLine("Cabin ID :");
                    int usercabinid1 = Convert.ToInt32(Console.ReadLine());
               
                    using (var db1 = new AppContextDB())
                    {
                        var C1 = new CounselorStay()

                        {
                            CounselorID = userCounselorID,
                            CabinID = usercabinid1,
                            Arrivel = userArrivel,
                            Departed = userDeparted
                        };

                        db1.CounselorStays.Add(C1);
                        db1.SaveChanges();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Counselor added");
                    }
                }
                    else
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("You can't Chek In the Counselor In this Cabin, because Counselor stays in another cabin at the same time");
                    }
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cabin is full you can't add counselor");
                }
            }
        }
        public static void ChikOutCounselor()
        {
            Console.WriteLine("This is all Counsoler in the cabin ");
            using (var db = new AppContextDB())
            {
                var result = db.CounselorStays.Join(db.Counselors , a => a.CabinID, b => b.CounselorID, (a,b) => new
                {
                    //CounselorStays
                    a.CabinID,
                    a.Arrivel,
                    a.Departed,
                    a.CounselorStayID,
                    //Counselors
                    b.CounselorID,
                    b.Co_FirstName, 
                    b.Co_Gender
                }).Join(db.Cabins , q =>q.CounselorID, m => m.CabinID, (q,m) => new{
                        //CounselorStays
                        q.CabinID,
                        q.Arrivel,
                        q.Departed,
                        q.CounselorStayID,
                        //Counselors
                        q.CounselorID,
                        q.Co_FirstName,
                        q.Co_Gender,
                        //Cabins
                        m.CabinName
               }).OrderBy(x => x.Co_FirstName).ToList();

            foreach (var c in result)
            {
                Console.WriteLine("CounselorStay ID :" + c.CounselorStayID  +"\t"+ "Cabin ID : " + c.CabinID + "\t" +  " Cabin Name : " +   "\t " +  "- Counselor ID : " + c.CounselorID 
                    + "\t" + c.Co_FirstName + "\t" + c.Co_Gender + "\t" + c.Arrivel + "\t" + c.Departed );  
            }
                Console.WriteLine("Wich Counsloer do you want to remove ?");
                int userCoid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entre CoumsloerStays ID :");
                int userCoumsloerStaysID = Convert.ToInt32(Console.ReadLine());
                var result1 = db.CounselorStays.Where(x => x.CounselorStayID == userCoumsloerStaysID).Count();
                Console.WriteLine("In this cabin there are {0} Counselor ", result1);
                if (result1 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    using (var db1 = new AppContextDB())
                    {
                        var C1 = new CounselorStay()
                        {
                            CounselorStayID = userCoumsloerStaysID,
                            CounselorID = userCoid
                        };
                        db.Remove<CounselorStay>(C1);
                        db.SaveChanges();
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("Counselor removde");
                    }
                }
            }
        }
    }
}
