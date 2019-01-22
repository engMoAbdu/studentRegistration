using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Project
{
    class Employee : Human , InterfaceStuff
    {
        int ID;
        int Age;
        String EmployeeName;
        int NamberOfDays;
       public  Employee () : base ("Employee Name")
        {
            
        }
        public int CalucateSalary(int NamberOfDays)
        {
            int SalaryOfEmployee = 30 * NamberOfDays;
            return SalaryOfEmployee;
        }
        public override void PrintInformation()
        {
            Console.WriteLine("ID is:"+ "\t \t EmployeeName is:" + "\t Age is :"+"\t Salary is :"
                               + "\t"+ "\t" + ID + "\t" + "\t" + "\t" +EmployeeName + "\t" + "\t" + Age + "\t" + "\t" + "\t" +CalucateSalary(NamberOfDays));
        }
        public void setEmployeeName(string EmployeeName)
        {
            this.EmployeeName = EmployeeName;
        }
        public string getEmployeeName()
        {
            return EmployeeName;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return ID;
        }
        public void setAge(int Age)
        {
            this.Age = Age;
        }
        public int getAge()
        {
            return Age;
        }
        public void setNamberOfDays(int NamberOfDays)
        {
            this.NamberOfDays = NamberOfDays;
        }
        public int getNamberOfDays()
        {
            return NamberOfDays;
        }
    }
}
