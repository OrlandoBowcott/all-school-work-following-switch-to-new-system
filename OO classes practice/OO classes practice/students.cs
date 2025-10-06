class StudentInformation
{
    private int studentAge;
    private string studentName;

    public StudentInformation(int age, string name)
    {
        studentAge = age;
        studentName = name;
    }

    public void SetStudentInfo(int age, string name)
    {
        studentAge = age;
        studentName = name;
    }
    public int GetStudentAge()
    {
        return studentAge;
    }
    public string GetStudentName()
    {
        return studentName;
    }
}
