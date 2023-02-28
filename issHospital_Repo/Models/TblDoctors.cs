using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace issHospital_Repo.Models
{
    public class Tbldoctors
    {
        public int Id { get; set; }
        public int doctorId { get; set; }
        public int ENo { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Phone1 { get; set; }
        public string Email { get; set; }
        public string Dept { get; set; }
        public string Marital { get; set; }
        public string HighSchl { get; set; }
        public string HighSchlLoc { get; set; }
        public string HighSec { get; set; }
        public string HighSecLoc { get; set; }
        public string Ug { get; set; }
        public string UgLoc { get; set; }
        public string PG { get; set; }
        public string PGLoc { get; set; }
        public string Specialist { get; set; }
        public string SpecLoc { get; set; }
        public string Degree { get; set; }
        public string DegreeLoc { get; set; }
        public string HName1 { get; set; }
        public string H1Loc { get; set; }
        public string Year1 { get; set; }
        public string Skill1 { get; set; }
        public string HName2 { get; set; }
        public string H2Loc { get; set; }
        public string Year2 { get; set; }
        public string Skill2 { get; set; }
        public string HName3 { get; set; }
        public string H3Loc { get; set; }
        public string Year3 { get; set; }
        public string Skill3 { get; set; }
        public DateTime DOB { get; set; }
        public string userName { get; set; }
        public bool isDeleted { get; set; } = false;
        public int deletedBy { get; set; }

        public DateTime deletedOn { get; set; }
        public int updatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }







    }
}
