using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxys;

public class ImageViewer
{
    private IList<IImage> _images = [];

    public void LoadImage(IList<string> filenames)
    {
        foreach (var filename in filenames)
        {
            _images.Add(new ProxyImage(filename));
        }
    }

    public void DisplayImage()
    {
        foreach (var image in _images)
        {
            image.Display();
        }
    }
}
