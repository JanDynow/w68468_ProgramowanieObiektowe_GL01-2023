using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Zd2
{
    public class Student : Person
    {
        public string School { get; set; }
        public bool CanGoHomeAlone { get; set; }
        public void SetSchool(string school)
        {
            if (string.IsNullOrEmpty(School))
                School = school;
            else
                throw new Exception("School is set");
        }
        public void ChangeSchool(string newschool)
        {
            School = newschool;
        }
        public void SetCanGoHomeAlone(bool CanGo)
        {
            CanGoHomeAlone = CanGo;
        }
        public string Info()
        {
            if (GetAge() >= 12)
                return "Może isć sam, ma 12< lat";
            else
                return "Nie ma 12 lat ani nie ma zgody";
        }
        public override string GetEducationInfo()
        {
            return School;
        }

        public override string GetFullName()
        {
            return FirstName;
        }

        public override string CanGoAloneToHome()
        {
            return Info();
        }
    }
}
