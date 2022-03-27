
using AbdulazizDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Models
{
    public class CounselorStay
    {
        public int CounselorStayID { get; set; }
        public int CabinID { get; set; }
        [ForeignKey("CabinID")]
        public Cabin Cabin { get; set; }    
        public DateTime Arrivel { get; set; }
        public DateTime Departed { get; set; }
        public int CounselorID { get; set; }
        [ForeignKey("CounselorID")]
        public Counselor Counselor { get; set; }
        }
    }

