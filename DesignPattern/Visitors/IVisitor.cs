using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitors;

public interface IVisitor
{
    void VisitTeacher(Teacher teacher);
    void VisitStudent(Student student);
}
