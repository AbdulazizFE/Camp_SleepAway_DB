using AbdulazizDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Data
{
    public class AppContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>

     options.UseSqlServer("Data Source=DESKTOP-UUDGVU3;Initial Catalog=Abdulaziz_Alsayed_Ahmad;Integrated Security=True");
        // 
        public DbSet<Camper> Campers { get; set; }
        public DbSet<CamperStay> CamperStays { get; set; }
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<CamperNextOfKin> CamperNextOfKins { get; set; }
        //
        public DbSet<Counselor> Counselors { get; set; }
        public DbSet<CounselorStay> CounselorStays { get; set; }
        //
        public DbSet<Cabin> Cabins{ get; set; }
        
        
       
    }
}
