using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Project
{
    abstract class Human
    {
        String name;
        int age;
     public Human(String name)
        {
            this.name = name;
        }
        abstract public void PrintInformation();
    }
}
