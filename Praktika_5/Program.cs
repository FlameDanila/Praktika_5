using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_5
{
   
    class student
    {
        public static ArrayList mass = new ArrayList() { 10, "Имя", "20-11-1", "01.01.2000" };

        public static void ADD(int id, string name, string group, string date)
        {
            mass.Add(id);
            mass.Add(name);
            mass.Add(group);
            mass.Add(date);
        }
        public static void PoiskID(int index)
        {
            for (int i = 0; i < mass.Count - 3; i += 4)
            {
                if (mass[i].ToString().Equals(index.ToString()))
                {
                    Console.WriteLine("Индекс студента: " + mass[i] + "\nФИО студента: " + mass[i + 1] + "\nГруппа студента: " + mass[i + 2] + "\nДата рождения студента: " + mass[i + 3] + "\n\n");
                    break;
                }
            }
        }
        public static void Delete(int index)
        {
            for (int i = 0; i < mass.Count - 2; i++)
            {
                if (mass[i].ToString().Equals(index.ToString()))
                {
                    mass.RemoveAt(i + 3);
                    mass.RemoveAt(i + 2);
                    mass.RemoveAt(i + 1);
                    mass.RemoveAt(i);
                    break;
                }
            }
        }
        public static void Fio()
        {
            for (int i = 1; i < mass.Count - 2; i += 4)
            {
                Console.WriteLine("ФИО студента: " + mass[i] + "\n");
            }
        }
        public static void Prosmotr()
        {
            for (int i = 0; i < mass.Count - 3; i += 4)
            {
                Console.WriteLine("Индекс студента: " + mass[i] + "\nФИО студента: " + mass[i + 1] + "\nГруппа студента: " + mass[i + 2] + "\nДата рождения студента: " + mass[i + 3] + "\n");
            }
        }
        public static void Years(int index)
        {
            string date = "";
            string Date = "";
            for (int i = 0; i < mass.Count - 2; i++)
            {
                if (mass[i].ToString().Equals(index.ToString()))
                {
                    date += mass[i + 3].ToString();
                    for (int j = 6; j < date.Length; j++)
                    {
                        Date += date[j];
                    }
                    Convert.ToInt32(Date);
                    Console.WriteLine(2021 - Convert.ToInt32(Date));
                    break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


