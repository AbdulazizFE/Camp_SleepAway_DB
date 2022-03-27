using AbdulazizDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazizDB.Models
{
    public class NextOfKin
    {
        public int NextOfKinID { get; set; }
        public string Next_FirstName { get; set; }
        public string Next_LastName { get; set; }
        public string Next_Phone { get; set; }
        public string RealtionShip { get; set; }
        public List<CamperNextOfKin> CamperNextOfKins { get; set; }

        }
}
