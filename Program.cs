using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            beg:
            #region Choose
            int NamberOfDays;
            Console.WriteLine("press 1 to select Student");
            Console.WriteLine("press 2 to select Teacher");
            Console.WriteLine("press 3 to select Employee");
            Console.WriteLine("press e to Exit");
            string Key = Console.ReadLine();
            #endregion
            //Student Information
            if (Key == "1")
            {
                #region StudentOpject,ID,Name,Age,ClassName
                for (int i = 1; i <= 5; i++)
                {
                    Student St = new Student();
                    Console.WriteLine("Enter the information of the Students");
                    Console.WriteLine("Student"+i);
                    Console.Write("ID is :");
                    St.setID(int.Parse(Console.ReadLine()));
                    Console.Write("Student name is :");
                    St.setStudentName(Console.ReadLine());
                    Console.Write("Age is :");
                    St.setAge(int.Parse(Console.ReadLine()));
                    Console.Write("Class Name is :");
                    St.setClassName(Console.ReadLine());
                    Console.Write("Mark is");
                    St.setMark(int.Parse(Console.ReadLine()));
                    St.PrintInformation();
                    #endregion
                }
            }

            else if (Key == "2")
            {
                #region TeacherOpject
                Teacher Th = new Teacher();
                Console.WriteLine("Enter the information of the Teachers");
                #endregion
                #region Teacher ID,Name,Age,Subject
                Console.Write("ID is :");
                Th.setID(int.Parse(Console.ReadLine()));
                Console.Write("Teacher name is :");
                Th.setTeacherName(Console.ReadLine());
                Console.Write("Age is :");
                Th.setAge(int.Parse(Console.ReadLine()));
                Console.Write("Subject is :");
                Th.setSubject(Console.ReadLine());
                #endregion
                #region ClassesName
                // The classes Name you can teacher teach it
                Console.Write("enter Number of your Class Name :");
                int NumOfClasses = int.Parse(Console.ReadLine());

                string[] ClassesName = new string[10];

                if (NumOfClasses == 1)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 2)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 3)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    ClassesName[3] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 4)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    ClassesName[3] = Console.ReadLine();
                    ClassesName[4] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 5)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    ClassesName[3] = Console.ReadLine();
                    ClassesName[4] = Console.ReadLine();
                    ClassesName[5] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 6)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    ClassesName[3] = Console.ReadLine();
                    ClassesName[4] = Console.ReadLine();
                    ClassesName[5] = Console.ReadLine();
                    ClassesName[6] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 7)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    ClassesName[3] = Console.ReadLine();
                    ClassesName[4] = Console.ReadLine();
                    ClassesName[5] = Console.ReadLine();
                    ClassesName[6] = Console.ReadLine();
                    ClassesName[7] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 8)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    ClassesName[3] = Console.ReadLine();
                    ClassesName[4] = Console.ReadLine();
                    ClassesName[5] = Console.ReadLine();
                    ClassesName[6] = Console.ReadLine();
                    ClassesName[7] = Console.ReadLine();
                    ClassesName[8] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else if (NumOfClasses == 9)
                {
                    Console.WriteLine("classes Name is :");
                    ClassesName[0] = Console.ReadLine();
                    ClassesName[1] = Console.ReadLine();
                    ClassesName[2] = Console.ReadLine();
                    ClassesName[3] = Console.ReadLine();
                    ClassesName[4] = Console.ReadLine();
                    ClassesName[5] = Console.ReadLine();
                    ClassesName[6] = Console.ReadLine();
                    ClassesName[7] = Console.ReadLine();
                    ClassesName[8] = Console.ReadLine();
                    ClassesName[9] = Console.ReadLine();
                    Th.setArray(ClassesName);
                }
                else
                {
                    Console.WriteLine("just work");
                }
                #endregion
                #region Teacher Salary
                Console.Write("NamOfDays is :");
                NamberOfDays = int.Parse(Console.ReadLine());

                int SalaryTeacher = Th.CalucateSalary(NamberOfDays);
                Th.PrintInformation();
                Console.Write("\n The salary of Teacher :" + SalaryTeacher);
                #endregion
            }
            else if (Key == "3")
            {
                #region Case3
                Employee Emp = new Employee();
                Console.WriteLine("Enter the information of the Employee");
                Console.Write("ID is           :");
                Emp.setID(int.Parse(Console.ReadLine()));
                Console.Write("EmployeeName is :");
                Emp.setEmployeeName(Console.ReadLine());
                Console.Write("Age is          :");
                Emp.setAge(int.Parse(Console.ReadLine()));
                Console.Write("NamberOfDays    :");
                Emp.setNamberOfDays(int.Parse(Console.ReadLine()));
                Console.WriteLine("This information Storted as :");
                Emp.PrintInformation();
                #endregion
            }
            else
            {
                while (Console.ReadLine() != "e")
                {
                    Console.WriteLine("please enter 1 or 2 or 3 \n");
                    goto beg;
                }
            }
        }
    }
}
