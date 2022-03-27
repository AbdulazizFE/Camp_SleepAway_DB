using AbdulazizDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Models
{
    public class CamperNextOfKin
    {
        public int Id { get; set; }
        public int NextOfKinID { get; set; }
        [ForeignKey("NextOfKinID")]
        public NextOfKin NextOfKin { get; set; }
        public int CamperID { get; set; }
        [ForeignKey("CamperID")]
        public Camper Camper { get; set; }
    }
}