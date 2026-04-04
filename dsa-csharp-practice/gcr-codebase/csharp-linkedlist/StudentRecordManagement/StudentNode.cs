using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.StudentRecordManagement
{
    class StudentNode
    {
        public int rollNo;
        public string name;
        public int age;
        public string grade;
        public StudentNode next;
        public StudentNode(int rollNo, string name, int age,string grade)
        {
            this.rollNo = rollNo;
            this.name = name; 
            this.age = age;
            this.grade = grade;
            next = null;
        }
    }
}
