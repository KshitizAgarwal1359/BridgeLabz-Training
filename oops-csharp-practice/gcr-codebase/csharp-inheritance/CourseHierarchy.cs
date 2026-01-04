using System;
class Course{
    public string courseName;
    public string duration;
    public Course(string CourseName, string Duration){
    courseName = CourseName;
    duration = Duration;
    }
    public virtual void DisplayCourseInfo(){
    Console.WriteLine("Course Name: " + courseName);
    Console.WriteLine("Duration: " + duration);
    }
}
class OnlineCourse : Course{
    public string platform;
    public bool isRecorded;
    public OnlineCourse(string CourseName, string Duration,string Platform, bool IsRecorded): base(CourseName, Duration){
    platform = Platform;
    isRecorded = IsRecorded;
    }
    public override void DisplayCourseInfo(){
    base.DisplayCourseInfo();
    Console.WriteLine("Platform: " + platform);
    Console.WriteLine("Recorded: " + (isRecorded ? "Yes" : "No"));
    }
}

class PaidOnlineCourse : OnlineCourse{
    public double fee;
    public double discount;
    public PaidOnlineCourse(string CourseName, string Duration,string Platform, bool IsRecorded,double Fee, double Discount): base(CourseName, Duration, Platform, IsRecorded){
    fee = Fee;
    discount = Discount;
    }
    public override void DisplayCourseInfo(){
    base.DisplayCourseInfo();
    Console.WriteLine("Course Fee: " + fee);
    Console.WriteLine("Discount: " + discount + "%");
    Console.WriteLine("Final Price: " + (fee - (fee * discount / 100)));
    }
}
class CourseHierarchy{
    public static void Main(String[] args){
    PaidOnlineCourse poc = new PaidOnlineCourse("OOPs","8 Weeks","CourseEra",true,5800,20);
    Console.WriteLine("COURSE DETAILS");
    poc.DisplayCourseInfo();
    }
}