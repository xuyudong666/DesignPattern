namespace DesignPattern.Visitors;

public class ExcellentAwardVisitor : IVisitor
{
    public void VisitStudent(Student student)
    {
        if(student.AverageScore >= 90)
            Console.WriteLine($"{student.Name}同学被评为优秀奖");
    }

    public void VisitTeacher(Teacher teacher)
    {
        if (teacher.TeachingFeedback >= 90)
            Console.WriteLine($"{teacher.Name}老师被评为优秀奖");
    }
}
