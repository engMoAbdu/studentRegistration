using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Project
{
    class Student : Human
    {
        int ID ;
        int age;
        int Mark;
        String className;
        String StudentName;
        public Student() : base ("Student Name")
        {
            
        }
        public override void PrintInformation()
        {
            Console.WriteLine("Student ID : \t" + "Student name : \t"+ "Age : \t" + "Class name : \t" + "Grade :" +
                                "\t"+ "\t" + "\t" + "\t" + ID + "\t" + "\t" + StudentName + "\t"+ age +"\t"+ className +"\t" + "\t" + Grade(Mark));
        }
        public string S;
        public string Grade(int Mark)
        {
            
            if (Mark >= 85)
            {
                S = "Excellent";
                Console.WriteLine(S);
            }
            else if (Mark >= 75)
            {
                S = "v.good";
                Console.WriteLine(S);
            }
            else if (Mark >= 50)
            {
                S = "good";
                Console.WriteLine(S);
            }
            else if (Mark >= 0)
            {
                S = "Fail";
                Console.WriteLine(S);
            }
            return S;
        }
        public void setMark(int Mark)
        {
            this.Mark = Mark;
        }
        public int getMark()
        {
            return Mark;
        }
        public void setStudentName(String StudentName)
        {
            this.StudentName = StudentName;
        }

      
        public String getStudentName()
        {
            return StudentName;
        }
        public void setClassName(String className)
        {
            this.className = className;
        }
        public String getClassName()
        {
            return className;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return ID;
        }
      
    }
}
