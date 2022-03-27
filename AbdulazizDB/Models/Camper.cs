using AbdulazizDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Models
{
    public class Camper
    {
        public int CamperID { get; set; }
        public string Camper_FirstName { get; set; }
        public string Camper_LastName { get; set; }
        public int Camper_Age { get; set; }
        public string Camper_Gender { get; set; }
        public string Camper_Phone { get; set; }
        public string Camper_Hobby { get; set; }
        public List<CamperStay> CamperStays { get; set; }
        public List<CamperNextOfKin> CamperNextOfKins { get; set; }

    }
}
