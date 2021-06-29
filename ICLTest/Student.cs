using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICLTest
{
    [Serializable]
    public class Student : Person
    {
        public virtual Teacher Teacher { get; set; }
        public override string ToString()
        {
            return $"{SurName} {FirstName} - Возраст: {Age} ";
        }
        public Student()
        { }
        public Student(string surname, string firstname, int age, Teacher teacher)
        {
            SurName = surname;
            FirstName = firstname;
            Age = age;
            Teacher = teacher;
        }
    }
}
