using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzDSA.Scenario_Based.EduResults
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public Student(int rollNo, string name, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }
    }
}
