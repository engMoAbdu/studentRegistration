using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Project
{
    class Teacher : Human , InterfaceStuff
    {
        int ID;
        int Age;
        string TeacherName;
        String Subject;
        String[] ClassesName = new string[10];
        public void setArray(String[]ClassesName)
        {
            this.ClassesName = ClassesName;
        }
        public string getArray()
        {
            return ClassesName[0];
            return ClassesName[1];
            return ClassesName[2];
            return ClassesName[3];
            return ClassesName[4];
            return ClassesName[5];
            return ClassesName[6];
            return ClassesName[7];
            return ClassesName[8];
            return ClassesName[9];
        }
        public Teacher() : base("Teacher Name")
        {

        }
        public void setTeacherName(string TeacherName)
        {
            this.TeacherName = TeacherName;
        }
        public string getTeacherName()
        {
            return TeacherName;
        }

        public void setSubject (string Subject)
        {
            this.Subject = Subject;
        }
        public string getSubject()
        {
            return Subject;
        }
        public void setAge(int Age)
        {
            this.Age = Age;
        }
        public int getAge()
        {
            return Age;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return ID;
        }
        public int CalucateSalary(int NamberOfDays)
        {
            int SalaryOfTeacher = 50 * NamberOfDays; //Salary of Teacher = Namber Of Days * 50 Pounds 
            return SalaryOfTeacher;
        }
        


        public override void PrintInformation()
        {
            Console.WriteLine("ID is : \t"+"Name is : \t"+ " Age is : \t" + " Subject is :" + "\t Class Name is :" 
                +getID() + "\t"+"\t" +getTeacherName() +"\t" + "\t" + "\t" + getAge() + "\t" + "\t" + getSubject() + "\t" + "\t" + getArray());
            
        }
    }
}
