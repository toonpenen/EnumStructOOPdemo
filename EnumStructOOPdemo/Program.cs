using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStructOOPdemo
{
    public enum Subjects
    {
        CSharp,
        Java,
        Networking,
        Taal
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {




        }
    }
    public struct Student
    {
        public string Name;
        public int Age;
        public Subjects Subject;

        public Student()
        {

        }
    }
}
