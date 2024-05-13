namespace Zachary_Renyhart_Assignment_2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(); //This is creating an object from the class Student
            myStudent.StudentId = 169059;
            myStudent.StudentFName = "Zack";
            myStudent.StudentLName = "Renyhart";
            myStudent.StudentGrade = Convert.ToChar("A");
            Console.WriteLine("StudentID is: " +  myStudent.StudentId);
            Console.WriteLine("Student's first name is: " + myStudent.StudentFName);
            Console.WriteLine("Student's last name is: " + myStudent.StudentLName);
            Console.WriteLine("Student's grade is: " + myStudent.StudentGrade);



        }
    }



    public class Student
    {

        private int _studentId; //field
        public int StudentId  //property
        {
            get { return _studentId; } //get method
            set { _studentId = value; } //set method
        }




        private string _studentFName;
        public string StudentFName
        {
            get { return _studentFName; }
            set { _studentFName = value; }

        }
        



        private string _studentLName;

        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }

        }



        private char _studentGrade;

        public char StudentGrade
        {
        get { return _studentGrade; }
        set { _studentGrade = value; }
        
        }          



    }
}
