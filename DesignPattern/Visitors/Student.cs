namespace DesignPattern.Visitors;

public class Student : IElement
{
    public string Name { get; set; }
    public int PublishedPapers { get; set; }
    public int AverageScore { get; set; }

    public Student(string name, int publishedPapers, int averageScore)
    {
        Name = name;
        PublishedPapers = publishedPapers;
        AverageScore = averageScore;
    }
    public void Accept(IVisitor visitor)
    {
        visitor.VisitStudent(this);
    }
}