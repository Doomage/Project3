using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace Project3
{
    internal class File
    {
        internal string Path{get; private set;}
        // dimioutgei mia lista parts
        private List<string[]> parts = new List<string[]>();
        //dimiourgei mia lista apo antikeimena student
        private List<student> studentslist = new List<student>();

        internal File(string Path)
        {
            //perinei thn kathe grammh tou arxeio kai thn vazei se ena pinaka Lines
            string[] Lines = System.IO.File.ReadAllLines(Path);
            foreach (string line in Lines)
            {
                parts.Add(line.Split(','));
            }
            foreach (string[] part in parts)
            {
                student student1 = new student(part[0], part[1], part[2], part[3], part[4], part[5], part[6]);
                studentslist.Add(student1);
            }
            studentslist.RemoveAt(0);
            //sugkrish vash LastName
            var CompareByName = new CompareLastName();
            studentslist.Sort(CompareByName);
            Console.WriteLine("Sorted By Last Name\n");
            foreach (student part in studentslist)
            {
                Console.WriteLine($"{ part.Name} | { part.LastName} | { part.Age} | { part.Height} | { part.Phone} | { part.Date} | { part.Tuition} | { part.conduct}");
            }


            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sorted By Age\n");
            //sugkrish vash ilikias
            var CompareByAge = new CompareAge();
            studentslist.Sort(CompareByAge);
            foreach (student part in studentslist)
            {
                Console.WriteLine($"{ part.Name} | { part.LastName} | { part.Age} | { part.Height} | { part.Phone} | { part.Date} | { part.Tuition} | { part.conduct}");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine(("Sorted By Phone\n"));
            //sugkrish vash phone
            var CompareByPhone = new ComparePhone();
            studentslist.Sort(CompareByPhone);
            foreach (student part in studentslist)
            {
                Console.WriteLine($"{ part.Name} | { part.LastName} | { part.Age} | { part.Height} | { part.Phone} | { part.Date} | { part.Tuition} | { part.conduct}");
            }

        }


    }
}
