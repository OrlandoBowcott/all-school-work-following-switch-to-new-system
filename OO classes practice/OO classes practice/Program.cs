namespace OO_classes_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StudentInformation Student1 = new StudentInformation(32, "bob");
            Console.WriteLine("Student Name: " + Student1.GetStudentName());
            Console.WriteLine("Student Age: " + Student1.GetStudentAge());
            Student1.SetStudentInfo(21, "John Doe");
            Console.WriteLine("Student Name: " + Student1.GetStudentName());
            Console.WriteLine("Student Age: " + Student1.GetStudentAge());
        }
    }
}
