using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ICLTest
{
    class Program
    {
        static async void ReadWriteAsync()
        {
            Teacher teacher1 = new Teacher("Sidorova", "Marina", "Ivanovna");
            Teacher teacher2 = new Teacher("Mikhailov", "Sergey", "Viktorovich");
            Teacher teacher3 = new Teacher("Yakovlev", "Anatoliy", "Petrovich");

            Student student1 = new Student("Petrov", "Ivan", 20, teacher1);
            Student student2 = new Student("Sidorov", "Egor", 20, teacher1);
            Student student3 = new Student("Zakharov", "Mikhail", 20, teacher2);
            Student student4 = new Student("Kozlov", "Maksim", 20, teacher3);
            Student student5 = new Student("Sidorov", "Ivan", 20, teacher3);
            Student student6 = new Student("Idiarov", "Bulat", 20, teacher2);
            Student student7 = new Student("Zakharov", "Ivan", 20, teacher1);
            Student student8 = new Student("Petrov", "Anton", 20, teacher1);
            Student student9 = new Student("Semenova", "Inna", 20, teacher2);
            Student student10 = new Student("Petrov", "Ivan", 20, teacher1);
            Student student11 = new Student("Tagirov", "Airat", 20, teacher3);
            Student student12 = new Student("Falieva", "Marina", 20, teacher1);

            Student[] students = new Student[] {student1,
                    student2,
                    student3,
                    student4,
                    student5,
                    student6,
                    student7,
                    student8,
                    student9,
                    student10,
                    student11,
                    student12,
                };
            //Сохранение списка студентов в текстовом файле в кодировке UTF8
            using (var sw = new StreamWriter("test.txt", false, Encoding.UTF8))
            {
                foreach (var s in students)
                {
                    await sw.WriteLineAsync($"Студент: {s.SurName} {s.FirstName}, его учитель {s.Teacher.ToString()}");
                }
            }

            using (StreamReader reader = new StreamReader("test.txt"))
            {
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
       
            ReadWriteAsync();
            //удаление последних 5 строк файла, сохранение в отдельный текстовый файл text.txt
            int k = 5;
            var text = File.ReadAllLines("test.txt").Reverse().Skip(k).Reverse();
            File.WriteAllLines("text.txt", text);

            //XmlSerializer formatter = new XmlSerializer(typeof(Student[]));

            //using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, students);
            //}


            //XDocument xdoc = new XDocument(new XElement("students",
            //    new XElement("student",
            //        new XAttribute("Teacher", $"{student1.Teacher.ToString()}"),
            //        new XElement("Surname", $"{student1.SurName}"),
            //        new XElement("Firstname", $"{student1.FirstName}")),
            //        new XElement("Age", $"{student1.Age}")),

            //    new XElement("student",
            //        new XAttribute("Teacher", $"{student2.Teacher.ToString()}"),
            //        new XElement("Surname", $"{student2.SurName}"),
            //        new XElement("Firstname", $"{student2.FirstName}")),
            //        new XElement("Age", $"{student2.Age}"));
            //xdoc.Save("students.xml");

        }
    }
}
