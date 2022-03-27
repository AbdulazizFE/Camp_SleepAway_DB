using AbdulazizDB.Data;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.InsertData
{
    public class Insert
    {
        public static void InsertCamper()
        {
                using (var db = new AppContextDB())
                { 
                    var C1 = new Camper()
                    {
                        Camper_FirstName = "Bella",
                        Camper_LastName = "Allan",
                        Camper_Gender = "Female",
                        Camper_Age = 17,
                        Camper_Phone = "2025550132",
                        Camper_Hobby = "Ride horses",

                    };
                    var C2 = new Camper
                    {
                        Camper_FirstName = "Hannah",
                        Camper_LastName = "Abraham",
                        Camper_Gender = "Female",
                        Camper_Age = 16,
                        Camper_Phone = "2025550175",
                        Camper_Hobby = "Basketball",
                    };
                    var C3 = new Camper
                    {
                        Camper_FirstName = "Phil",
                        Camper_LastName = "Nolan",
                        Camper_Gender = "Male",
                        Camper_Age = 18,
                        Camper_Phone = "8035550176",
                        Camper_Hobby = "Fotboll",
                    };
                    var C4 = new Camper
                    {
                        Camper_FirstName = "Jacob",
                        Camper_LastName = "Lewis",
                        Camper_Gender = "Male",
                        Camper_Age = 19,
                        Camper_Phone = "805550155",
                        Camper_Hobby = "Fotboll",
                    };
                var C5 = new Camper
                    {
                        Camper_FirstName = "Blake",
                        Camper_LastName = "Bower",
                        Camper_Gender = "Male",
                        Camper_Age = 19,
                        Camper_Phone = "12414355",
                        Camper_Hobby = "Read books",
                    };
                var C6 = new Camper
                    {
                        Camper_FirstName = "Dominic",
                        Camper_LastName = "Cameron",
                        Camper_Gender = "Male",
                        Camper_Age = 22,
                        Camper_Phone = "23534564",
                        Camper_Hobby = "Fotboll",
                    };
                var C7 = new Camper
                    {
                        Camper_FirstName = "Carl",
                        Camper_LastName = "Edmunds",
                        Camper_Gender = "Male",
                        Camper_Age = 19,
                        Camper_Phone = "21312312",
                        Camper_Hobby = "Fotboll",
                    };
                var C8 = new Camper
                    {
                        Camper_FirstName = "Jake",
                        Camper_LastName = "Davidson",
                        Camper_Gender = "Male",
                        Camper_Age = 17,
                        Camper_Phone = "214134124",
                        Camper_Hobby = "Gym",
                    };
                var C9 = new Camper
                    {
                        Camper_FirstName = "Hart",
                        Camper_LastName = "Hill",
                        Camper_Gender = "Female",
                        Camper_Age = 20,
                        Camper_Phone = "214142",
                        Camper_Hobby = "Fotboll",
                    };
                var C10 = new Camper
                    {
                        Camper_FirstName = "Madeleine",
                        Camper_LastName = "Una",
                        Camper_Gender = "Female",
                        Camper_Age = 19,
                        Camper_Phone = "821323",
                        Camper_Hobby = "Read books",
                    };
                var C11 = new Camper
                    {
                        Camper_FirstName = "Eric",
                        Camper_LastName = "Avery",
                        Camper_Gender = "Male",
                        Camper_Age = 18,
                        Camper_Phone = "213445",
                        Camper_Hobby = "Fotboll",
                    };
                var C12 = new Camper
                    {
                        Camper_FirstName = "Sally",
                        Camper_LastName = "Lewis",
                        Camper_Gender = "Female",
                        Camper_Age = 20,
                        Camper_Phone = "1231242",
                        Camper_Hobby = "Ride horses",
                    };
                var C13 = new Camper
                    {
                        Camper_FirstName = "Victor",
                        Camper_LastName = "Ince",
                        Camper_Gender = "Male",
                        Camper_Age = 19,
                        Camper_Phone = "824324",
                        Camper_Hobby = "Fotboll",
                    };
                var C14 = new Camper
                    {
                        Camper_FirstName = "Sue",
                        Camper_LastName = "Sophie",
                        Camper_Gender = "Female",
                        Camper_Age = 23,
                        Camper_Phone = "234325",
                        Camper_Hobby = "Ride horses",
                    };
                var C15 = new Camper
                    {
                        Camper_FirstName = "Vanessa",
                        Camper_LastName = "Theresa",
                        Camper_Gender = "Female",
                        Camper_Age = 21,
                        Camper_Phone = "545345",
                        Camper_Hobby = "Ride horses",
                    };
                var C16 = new Camper
                    {
                        Camper_FirstName = "Trevor",
                        Camper_LastName = "Max",
                        Camper_Gender = "Male",
                        Camper_Age = 19,
                        Camper_Phone = "67975112",
                        Camper_Hobby = "Fotboll",
                    };
                var C17 = new Camper
                    {
                        Camper_FirstName = "Sean",
                        Camper_LastName = "Gibson",
                        Camper_Gender = "Male",
                        Camper_Age = 23,
                        Camper_Phone = "1234567",
                        Camper_Hobby = "Basketball",
                    };
                var C18 = new Camper
                    {
                        Camper_FirstName = "Allan",
                        Camper_LastName = "Alsop",
                        Camper_Gender = "Male",
                        Camper_Age = 23,
                        Camper_Phone = "9876543",
                        Camper_Hobby = "Basketball",
                    };
         db.Campers.AddRange( C1,C2, C3, C4, C5, C6, C7, C8, C9,
                             C10, C11,C12,C13, C14,C15, C16,C17,C18);
                    db.SaveChanges();
                }
            }
        public static void InsertCabin()
        {
            using (var db = new AppContextDB())
            {
                var Cab1 = new Cabin
                {
                    CabinName = "One",
                    Cabasity = 4
                };

                var Cab2 = new Cabin
                {
                    CabinName = "Two",
                    Cabasity = 4
                };

                var Co3 = new Cabin
                {
                    CabinName = "Three",
                    Cabasity = 4,
                };

                var Co4 = new Cabin
                {
                    CabinName = "Four",
                    Cabasity = 4,
                };
                var Co5 = new Cabin
                {
                    CabinName = "Five",
                    Cabasity = 4,
                };

                db.Cabins.AddRange(Cab1, Cab2, Co3, Co4, Co5);
                db.SaveChanges();
            }
        }
        public static void InsertCounselor()
        {
            using (var db = new AppContextDB())
            {


                var Co1 = new Counselor
                {

                    Co_FirstName = "Abigail",
                    Co_LastName = "Butler",
                    Co_Gender = "Female",
                    Co_Experience = "Football coach",
                    Co_Phone = "1122233"

                };

                var Co2 = new Counselor
                {

                    Co_FirstName = "Christian",
                    Co_LastName = "Allan",
                    Co_Gender = "Male",
                    Co_Experience = "HR",
                    Co_Phone = "1238712"
                };

                var Co3 = new Counselor
                {
                    Co_FirstName = "Donna",
                    Co_LastName = "Ball",
                    Co_Gender = "Female",
                    Co_Experience = "IT",
                    Co_Phone = "234324"
                };

                var Co4 = new Counselor
                {
                    Co_FirstName = "William",
                    Co_LastName = "Avery",
                    Co_Gender = "Male",
                    Co_Experience = "Personal trainer",
                    Co_Phone = "4536536"
                };
                db.Counselors.AddRange(Co1, Co2, Co3, Co4);
                db.SaveChanges();
            }
        }
        public static void InsertNextOfKin()
        {
       
                using (var db = new AppContextDB())
                {
                    var N1 = new NextOfKin()
                    {

                        RealtionShip = "Friend",
                        Next_FirstName = "Ava",
                        Next_LastName = "Berry",
                        Next_Phone = "2025550156"
                    };
                    var N2 = new NextOfKin()
                    {
                        RealtionShip = "Mamma",
                        Next_FirstName = "Angela",
                        Next_LastName = "Bond",
                        Next_Phone = "202-555-0152"
                    };
                    var N3 = new NextOfKin()
                    {
                        RealtionShip = "Pappa",
                        Next_FirstName = "Carl",
                        Next_LastName = "Abraham",
                        Next_Phone = "2025550128"
                    };

                    var N4 = new NextOfKin()
                    {
                        RealtionShip = "Brother",
                        Next_FirstName = "David",
                        Next_LastName = "Abraham",
                        Next_Phone = "2025550101"
                    };

                    var N5 = new NextOfKin()
                    {
                        RealtionShip = "Grandmother",
                        Next_FirstName = "Dorothy",
                        Next_LastName = "Dickens",
                        Next_Phone = "8035550166"
                    };

                    var N6 = new NextOfKin()
                    {

                        RealtionShip = "Friend",
                        Next_FirstName = "Phil",
                        Next_LastName = "Jones",
                        Next_Phone = "805550102"
                    };

                    var N7 = new NextOfKin()
                    {
                        RealtionShip = "cousin",
                        Next_FirstName = "Robert",
                        Next_LastName = "May",
                        Next_Phone = "8035550169"
                    };

                    var N8 = new NextOfKin()
                    { 
                        RealtionShip = "Brother",
                        Next_FirstName = "Ryan",
                        Next_LastName = "McDonald",
                        Next_Phone = "8035550161"
                    };

      db.NextOfKins.AddRange( N1, N2, N3, N4, N5, N6, N7, N8);
      db.SaveChanges();


                }
            }
        public static void InsertCamperStay ()
        {
            using (var db = new AppContextDB())
            {
                var Ca1 = new CamperStay
                {
                    CabinID = 1,
                    CamperID = 1,
                    Arrivel = new DateTime(2022, 01, 03),
                    Departed = new DateTime(2022, 01, 28),

                    CabinName = "One"
                };

                var Ca2 = new CamperStay
                {
                    CabinID = 2,
                    CamperID = 1,
                    Arrivel = new DateTime(2022, 01, 30),
                    Departed = new DateTime(2022, 02, 28),
                    CabinName = "Tow"
                };
                var Ca3 = new CamperStay
                {
                    CabinID = 3,
                    CamperID = 1,
                    Arrivel = new DateTime(2022, 04, 12),
                    Departed = new DateTime(2022, 05, 12),
                    CabinName = "Three"
                };
                var Ca4 = new CamperStay
                {
                    Arrivel = new DateTime(2022, 04, 12),
                    Departed = new DateTime(2022, 05, 12),
                    CabinID = 4,
                    CamperID = 2,
                    CabinName = "Four"
                };
                var Ca5 = new CamperStay
                {
                    Arrivel = new DateTime(2022, 05, 25),
                    Departed = new DateTime(2022, 06, 30),
                    CabinID = 4,
                    CamperID = 2,
                    CabinName = "Four"
                };
                var Ca6 = new CamperStay
                {
                    Arrivel = new DateTime(2022, 05, 25),
                    Departed = new DateTime(2022, 06, 30),
                    CabinID = 5,
                    CamperID = 3,
                    CabinName = "Five"
                };
                var Ca7 = new CamperStay
                {
                    Arrivel = new DateTime(2022, 07, 03),
                    Departed = new DateTime(2022, 07, 30),
                    CabinID = 5,
                    CamperID = 3,
                    CabinName = "Five"
                };
                var Ca8 = new CamperStay
                {
                    Arrivel = new DateTime(2022 , 02 , 12),
                    Departed = new DateTime(2022 , 03 , 17),
                    CabinID = 5,
                    CamperID = 3,
                    CabinName = "Five"
                };

                var Ca9 = new CamperStay
                {
                    Arrivel = new DateTime(2022, 01, 01),
                    Departed = new DateTime(2022, 02, 02),
                    CabinID = 5,
                    CamperID = 3,
                    CabinName = "Five"
                };
                
                db.CamperStays.AddRange(
                    Ca1,
                    Ca2,
                    Ca3,
                    Ca4,
                    Ca5,
                    Ca6,
                    Ca7,
                    Ca8,
                    Ca9
                    );
                db.SaveChanges();
            }
        }
        public static void InsertCounselorStay()
        {
            using (var db = new AppContextDB())
            {
                var Co1 = new CounselorStay
                {
                    Arrivel = new DateTime(2022, 01, 03),
                    Departed = new DateTime(2022, 01, 28),
                    CabinID = 1,
                    CounselorID = 1
                };
                var Co2 = new CounselorStay
                {

                    Arrivel = new DateTime(2022, 01, 30),
                    Departed = new DateTime(2022, 02, 28),
                    CabinID = 2,
                    CounselorID = 1
                };
                var Co3 = new CounselorStay
                {
                    Arrivel = new DateTime(2022, 04, 12),
                    Departed = new DateTime(2022, 05, 12),
                    CabinID = 3,
                    CounselorID = 3
                };
                db.CounselorStays.AddRange(
                    Co1,
                    Co2,
                    Co3
                    );
                db.SaveChanges();
            }
        }
        public static void InsertCamperNextOfKin()

        {
            using (var db = new AppContextDB())
            {
                var N1 = new CamperNextOfKin()
                {
                    NextOfKinID = 1,
                    CamperID = 1,
                };
                var N2 = new CamperNextOfKin()
                {
                    NextOfKinID = 2,
                    CamperID = 2,
                };
                var N3 = new CamperNextOfKin()
                {
                    NextOfKinID = 3,
                    CamperID = 3,
                };
                var N4 = new CamperNextOfKin()
                {
                    NextOfKinID = 4,
                    CamperID = 4,
                };
                var N5 = new CamperNextOfKin()
                {
                    NextOfKinID = 5,
                    CamperID = 1,
                };
                var N6 = new CamperNextOfKin()
                {
                    NextOfKinID = 6,
                    CamperID = 1,
                };
                var N7 = new CamperNextOfKin()
                {
                    NextOfKinID = 7,
                    CamperID = 3,
                };
                var N8 = new CamperNextOfKin()
                {
                    NextOfKinID = 8,
                    CamperID = 4,
                };

                db.CamperNextOfKins.AddRange(
             N1, N2, N3, N4, N5, N6, N7, N8

             );
                db.SaveChanges();
            } 
        }
      }  
   } 