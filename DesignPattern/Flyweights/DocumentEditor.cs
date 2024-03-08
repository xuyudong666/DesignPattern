using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweights;

public class DocumentEditor
{
    private MultimediaFlyweightFactory _factory = new MultimediaFlyweightFactory();

    public void InsertMultimedia(string multimediaPath,MultimediaContext context)
    {
        var multimediaFlyweight = _factory.GetFlyweight(multimediaPath);
        multimediaFlyweight.Display(context);
    }
}
