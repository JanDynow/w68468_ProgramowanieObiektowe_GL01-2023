using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Zd2
{
    public class Teacher : Student
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public override string GetFullName()
        {
            return $"{Title} {base.GetFullName()}";
        }
        public void WhichStudentCanGo()
        {
            
        }
        public void DisplayClass(DateTime date)
        {
            Console.WriteLine($"{GetEducationInfo()} Day {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel {GetFullName()}");
            Console.WriteLine($"Lista Studentów: ");
            int i = 0;
            foreach (var student in Students)
            {
                Console.WriteLine($"{i} {GetFullName()} - {GetGender()} - {Info()}");
            }
        }
    }
}
