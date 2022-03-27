using AbdulazizDB.HandelTbles;
using AbdulazizDB.InsertData;
using AbdulazizDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Meny
{
    public class Meny
    {
        public static void TheMeny()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
                                         ╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐
                                         ║║║├┤ │  │  │ ││││├┤    │ │ │   
                                         ╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘
                              ");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(@"

██████╗ █████╗ ███╗   ███╗██████╗     ███████╗██╗     ███████╗███████╗██████╗  █████╗ ██╗    ██╗ █████╗ ██╗   ██╗    
██╔════╝██╔══██╗████╗ ████║██╔══██╗    ██╔════╝██║     ██╔════╝██╔════╝██╔══██╗██╔══██╗██║    ██║██╔══██╗╚██╗ ██╔╝    
██║     ███████║██╔████╔██║██████╔╝    ███████╗██║     █████╗  █████╗  ██████╔╝███████║██║ █╗ ██║███████║ ╚████╔╝     
██║     ██╔══██║██║╚██╔╝██║██╔═══╝     ╚════██║██║     ██╔══╝  ██╔══╝  ██╔═══╝ ██╔══██║██║███╗██║██╔══██║  ╚██╔╝      
╚██████╗██║  ██║██║ ╚═╝ ██║██║         ███████║███████╗███████╗███████╗██║     ██║  ██║╚███╔███╔╝██║  ██║   ██║       
╚═════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝         ╚══════╝╚══════╝╚══════╝╚══════╝╚═╝     ╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝   ╚═╝       
                                                                                                                      
                                                                                              By: Abdulaziz                                                          
                                                                                               
                             ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) - If you want to load the entire data\n" +
                "(2) - If you already have data\n" +
                "(3) - To Add, Remove, Update\n(0) - To exit");
            string n = Console.ReadLine();

            if (n == "1")
            {
                Insert.InsertCamper();
                Console.WriteLine("Loading all Campers ");
                Insert.InsertNextOfKin();
                Console.WriteLine("Loading all NextOfKin ");
                Insert.InsertCounselor();
                Console.WriteLine("Loading all Counselor");
                Insert.InsertCabin();
                Console.WriteLine("Loading all Cbins");
                Insert.InsertCamperStay();
                Console.WriteLine("Loading all CamperSaty");
                Insert.InsertCounselorStay();
                Console.WriteLine("Loading all CounselorStays");
                Insert.InsertCamperNextOfKin();
                Console.WriteLine("Loading all CamperNextOfKin");
                Console.WriteLine("All data is loading");
            }
            else if (n == "2")
            {
                Console.Clear();
                bool options = true;
                do
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Select one option\n");
                        Console.WriteLine(
                        "(1) - To see all Campers \n" +
                        "(2) - Search a camper sort by Cabin\n" +
                        "(3) - To see all NextOfKin\n" +
                        "(4) - To see all Counselor\n" +
                        "(5) - Which NextOfKin is for which camper, sort by cabin?\n" +
                        "(6) - Search a Camper sort by Counselor" +
                        "(7) - To see all Cabin" +
                        //"8.Wich Camper in wich CamperStay"+
                        "\n(0) - Exit from our program"
                        );

                        int choice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (choice)
                        {
                            case 1:
                                Methods.ShowCampers();
                                break;
                            case 2:
                                Console.WriteLine("Write the name of Cabin : ");
                                Methods.SearshACamper();
                                break;

                            case 3:
                                Methods.ShowNextOfKin();
                                break;

                            case 4:
                                Methods.ShowCounselor();
                                break;
                            case 5:
                                Methods.CamperNextOfKinByCabin();
                                break;
                            case 6:
                                Console.WriteLine("Plase Write First Name of Counselor : ");
                                Methods.SearshACounselor();
                                break;
                            case 7:
                                Methods.ShowCabin();
                                break;
                            case 0:
                                Console.WriteLine("You've decided to quit.");
                                options = false;
                                break;
                            default:
                                Console.WriteLine("Please insert either 1,2,3,4,5,6,7 or 0");
                                break;

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    Console.WriteLine();
                } while (options);
            }
            else if (n == "3")
            {

                Console.Clear();
                bool options2 = true;

                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("(1) - Add a new Cabin\n" +
                        "(2) - Remove the Cabin\n" +
                        "(3) - Updtae the Cabin");
                    Console.WriteLine("--------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("(4) - Add a new Camper\n" +
                        "(5) - Remove the Camper\n" +
                        "(6) - Update the Camper");
                    Console.WriteLine("--------------------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("(7) - Add a new Counselor\n" +
                        "(8) - Remove the Counselor\n" +
                        "(9) - Update the Counselor");
                    Console.WriteLine("--------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("(10) - Add a new NextOfKin\n" +
                        "(11) - Remove the NextOfKin\n" +
                        "(12) - Update the NextOfKin");
                    Console.WriteLine("--------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("(13) - Check In Camper in the Cbin\n" +
                        "(14) - Check Out Camper from the Cabin");
                    Console.WriteLine("--------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("(15) - Check In Counselor in the Cabin\n" +
                        "(16) - Check Out the Counselor from the Cabin\n");
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine("(0) - Exit from our program");
                    int choice2 = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    try
                    {
                        Console.Clear();
                        switch (choice2)
                        {
                            case 1:
                                HandleCabin.AddCabin();
                                break;

                            case 2:
                                HandleCabin.RemoveCabin();
                                break;

                            case 3:
                                HandleCabin.UpdateCabin();
                                break;

                            case 4:
                                HandleCamper.AddCamper();
                                break;

                            case 5:
                                HandleCamper.RemoveCamper();
                                break;

                            case 6:
                                HandleCamper.UpdateCamper();
                                break;

                            case 7:
                                HandleCounselor.AddCounselor();
                                break;

                            case 8:
                                HandleCounselor.RemoveCounselor();
                                break;

                            case 9:
                                HandleCounselor.UpdateCounselor();
                                break;

                            case 10:
                                HandleNextOfKin.AddNextOfKin();
                                break;

                            case 11:
                                HandleNextOfKin.RemoveNextOfKin();
                                break;

                            case 12:
                                HandleNextOfKin.UpdateNextOfKin();
                                break;

                            case 13:
                                HandleCamperStay.CheckInCamperStay();
                                break;

                            case 14:
                                HandleCamperStay.CheckOutCamperStay();
                                break;

                            case 15:
                                HandleCounselorStays.ChekInCounselorInCabin();
                                break;

                            case 16:
                                HandleCounselorStays.ChikOutCounselor();
                                break;

                            case 0:
                                options2 = false;
                                Console.WriteLine("You've decided to quit.");
                                break;

                            default:
                                Console.WriteLine("Please insert either 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 or 0.");
                                break;

                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    Console.WriteLine();

                } while (options2);

            }

        }
    }
}
