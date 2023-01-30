using Microsoft.VisualBasic.FileIO;
using System;
using System.Text.RegularExpressions;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework1-Car
            //Car car1 = new Car("Toyoto", "k5", 100)
            //{
            //    FuelCapacity = 150,
            //    CurrentFuel = 50
            //};
            //car1.AddFuel(101);
            #endregion

            #region Homework2- Student
            Student[] students = new Student[0];
            string option;
            string fullname;
            string groupno;   
                do
                {
                    Console.WriteLine("1. Bütün telebelere bax");
                    Console.WriteLine("2.Telebeler üzre axtarış et");
                    Console.WriteLine("3.Telebe elave et");
                    Console.WriteLine("0. Menudan çıx");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            foreach (var item in students)
                            {
                                Console.WriteLine($"Fullname:{item.Fullname}, Groupno{item.GroupNo}");
                            }
                            break;
                        case "2":
                            foreach (var item in students)
                            {
                                Console.WriteLine("write wantedstudent:");
                                string wantedstudent = Console.ReadLine();
                                if (item.Fullname == wantedstudent)
                                    Console.WriteLine($"Fullname:{item.Fullname}");
                            }
                            break;

                        case "3":
                            do
                            {
                                Console.WriteLine("Write Fullname:");
                                fullname = Console.ReadLine();
                            } while (IsFullname(fullname));

                            do
                            {

                                Console.WriteLine("Write Groupno:");
                                groupno = Console.ReadLine();
                            } while (IsGroup(groupno));

                            Student student = new Student("Jack Sparrow")
                            {
                                Fullname = fullname,
                                GroupNo = groupno
                            };
                            Array.Resize(ref students, students.Length + 1);

                            Student newstudent = new Student("Rehim Ismayilov")
                            {
                                Fullname = fullname,
                                GroupNo = groupno
                            };

                            students[students.Length - 1] = newstudent;
                            break;

                        case "0":
                            Console.WriteLine("Menu");
                            break;
                        default:
                            Console.WriteLine("Yanlis secim etdiniz yenide cehd edin");
                            break;
                    }
                } while (true);
            

            #endregion
    }
        static bool IsGroup(string word)
        {
            if (char.IsUpper(word[0]) && word.Length == 4)
            {
                return true;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsDigit(word[i]))
                {
                    return false;
                }
            }
            return false;
        }
        static bool IsFullname(string word)
        {
            var words = word.Split(' ');
            if (word.Length < 2) return false;
            for (var  i = 0; i < words.Length; i++)
            {
                if (IsName(words[i]))
                {
                    return false;
                }
                else if (char.IsDigit(word[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsName(string word)
        {
            if (!char.IsUpper(word[0])) return false;
            if (string.IsNullOrEmpty(word)) return false;
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
