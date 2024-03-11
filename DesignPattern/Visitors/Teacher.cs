namespace DesignPattern.Visitors;

public class Teacher : IElement
{
    public string Name { get; set; }
    public int PublishedPapers { get; set; }
    public int TeachingFeedback { get; set; }

    public Teacher(string name, int publishedPapers, int teachingFeedback)
    {
        Name = name;
        PublishedPapers = publishedPapers;
        TeachingFeedback = teachingFeedback;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitTeacher(this);
    }
}