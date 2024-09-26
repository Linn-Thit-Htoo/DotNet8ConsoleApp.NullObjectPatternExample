public class Program
{
    public static void Main(string[] args)
    {
        IStudent student = GetStudent(1);

        // Instead of checking for null, you can directly call the method
        student.Study();

        Console.ReadKey();
    }

    public static IStudent GetStudent(int id)
    {
        if (id == 1)
        {
            return new RealStudent { StudentId = 1, StudentName = "John Doe" };
        }

        return new NullObjectStudent();
    }
}

public interface IStudent
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    void Study();
}

public class RealStudent : IStudent
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }

    public void Study()
    {
        Console.WriteLine($"{StudentName} is studying...");
    }
}

public class NullObjectStudent : IStudent
{
    public int StudentId { get; set; } = 0;
    public string StudentName { get; set; } = "Unknown Student";

    public NullObjectStudent() { }

    public void Study()
    {
        Console.WriteLine($"{StudentName} is studying...");
    }
}