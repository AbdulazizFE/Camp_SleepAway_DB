using AbdulazizDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Models
{
    public class Cabin
    {
        public int CabinID { get; set; }
        public int Cabasity { get; set; }
        public string CabinName { get; set; }
        public List<CounselorStay> CounselorStays { get; set; }
        public List<CamperStay> CamperStays { get; set; }
    }
}
