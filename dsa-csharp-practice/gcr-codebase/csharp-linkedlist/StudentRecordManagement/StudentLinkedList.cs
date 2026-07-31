using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.StudentRecordManagement
{
    class StudentLinkedList
    {
        private StudentNode head;
        public void AddAtBeginning(int rollNo,string name,int age,string grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.next= head;
            head = newNode;
        }
        public void AddAtEnd(int rollNo,string name,int age,string grade) //add at end
        {
            StudentNode newNode = new StudentNode(rollNo,name,age, grade);
            if (head == null)
            {
                head = newNode;
                return;
            }
            StudentNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        public void AddAtPosition(int position,int rollNo,string name,int age,string grade)
        {
            if (position <= 0)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(rollNo, name, age, grade);
                return;
            }
            StudentNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.next = temp.next;
            temp.next = newNode;
        }
        // Delete by Roll Number
        public void DeleteByRollNo(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            if (head.rollNo == rollNo)
            {
                head = head.next;
                Console.WriteLine("Student deleted successfully.");
                return;
            }
            StudentNode temp = head;
            while (temp.next != null && temp.next.rollNo != rollNo)
            {
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
            temp.next = temp.next.next;
            Console.WriteLine("Student deleted successfully.");
        }
        // Search by Roll Number
        public void SearchStudent(int rollNo)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.rollNo == rollNo)
                {
                    DisplayStudent(temp);
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found.");
        }
        // Update Grade
        public void UpdateGrade(int rollNo, string newGrade)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.rollNo == rollNo)
                {
                    temp.grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("Student not found.");
        }
        // Display all students
        public void DisplayAllStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                DisplayStudent(temp);
                temp = temp.next;
            }
        }
        private void DisplayStudent(StudentNode student)
        {
            Console.WriteLine(
                $"RollNo: {student.rollNo}, Name: {student.name}, Age: {student.age}, Grade: {student.grade}"
            );
        }
    }
}
