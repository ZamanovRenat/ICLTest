using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICLTest
{
    [Serializable]
    public class Teacher : Person
    {
        public string Patronymic { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Teacher()
        { }

        public Teacher(string surname, string firstname, string patronymic)
        {
            SurName = surname;
            FirstName = firstname;
            Patronymic = patronymic;
        }
        public override string ToString()
        {
            return $"Учитель: {SurName} {FirstName} {Patronymic} ";
        }
    }
}
