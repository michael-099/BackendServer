using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuthentication.Models
{
    public class Doctor : User
    {
        public string? LicensePath { get; set; }
        public string Specialization { get; set; } = "";
        public int? YearOfExperience { get; set; }
        public bool? Verified { get; set; }
        public Doctor(string Email, string Phonenumber, string Profession) : base(Email, Phonenumber, Profession, UserRole.Doctor)
        {

        }
    }
}