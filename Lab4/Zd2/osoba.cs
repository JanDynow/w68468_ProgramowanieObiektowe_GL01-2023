using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Zd2
{
    public abstract class Person
    {
        public string FirstName;
        public string Surname;
        public string Pesel;

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            Surname = lastName;
        }
        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }
        public string GetGender() => int.Parse(Pesel[9].ToString()) % 2 == 0 ? "Woman" : "Man";
        public int GetAge()
        {
            return (DateTime.Now - BirthDate()).Days / 365;
        }
        private DateTime BirthDate()
        {
            var year = int.Parse(Pesel.Substring(0, 2));
            var month = int.Parse(Pesel.Substring(2, 4));
            var day = int.Parse(Pesel.Substring(4, 6));
            if (month > 80)
            {
                year = year + 1800;
                month = month - 80;
            }
            else if( month > 60)
            {
                year = year + 2200;
                month = month - 60;
            }
            else if (month > 40)
            {
                year = year + 2100;
                month = month - 40;
            }
            else if (month > 20)
            {
                year = year + 2000;
                month = month - 20;
            }
            else
            {
                year += 1900;
            }
         return new DateTime(year,month,day);
        }
        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract string CanGoAloneToHome();
    }

}
