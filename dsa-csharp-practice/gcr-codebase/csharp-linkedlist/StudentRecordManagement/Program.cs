using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.StudentRecordManagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            StudentLinkedList studentList = new StudentLinkedList();
            studentList.AddAtBeginning(1, "Aman", 20, "A");
            studentList.AddAtEnd(2, "Riya", 21, "B");
            studentList.AddAtPosition(2, 3, "Kunal", 22, "A");
            Console.WriteLine("\nAll Students:");
            studentList.DisplayAllStudents();
            Console.WriteLine("\nSearching Roll No 2:");
            studentList.SearchStudent(2);
            Console.WriteLine("\nUpdating Grade for Roll No 1:");
            studentList.UpdateGrade(1, "A+");
            Console.WriteLine("\nDeleting Roll No 3:");
            studentList.DeleteByRollNo(3);
            Console.WriteLine("\nFinal Student List:");
            studentList.DisplayAllStudents();
        }
    }
}
