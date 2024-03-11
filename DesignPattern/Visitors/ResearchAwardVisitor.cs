namespace DesignPattern.Visitors;

public class ResearchAwardVisitor : IVisitor
{
    public void VisitStudent(Student student)
    {
        if(student.PublishedPapers >=2)
        {
            Console.WriteLine($"{student.Name}同学被评为科研奖");
        }
    }

    public void VisitTeacher(Teacher teacher)
    {
        if (teacher.PublishedPapers >= 10)
        {
            Console.WriteLine($"{teacher.Name}老师被评为科研奖");
        }
    }
}
