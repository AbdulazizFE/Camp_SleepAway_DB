using AbdulazizDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Models
{
    public class Counselor
    {
        public int CounselorID { get; set; }
        public string ?Co_FirstName { get; set; }
        public string Co_LastName { get; set; }
        public string Co_Phone { get; set; }
        public string Co_Gender { get; set; }
        public string Co_Experience { get; set; }
        public List<CounselorStay> CounselorStays { get; set; }
    }
}
