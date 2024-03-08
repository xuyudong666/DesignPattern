using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweights;

public class MultimediaFlyweightFactory
{
    private Dictionary<string, IMultimediaFlyweight> flyweights = new Dictionary<string, IMultimediaFlyweight>();

    public IMultimediaFlyweight GetFlyweight(string key)
    {
        if(!flyweights.ContainsKey(key))
        {
            byte[] data = LoadMultimediaData(key);
            flyweights[key] = new ImageFlyweight(data); 
        }
        return flyweights[key]; 
    }

    private byte[] LoadMultimediaData(string key)
    {
        // 加载图片、动画或视频的数据
        // 根据实际情况实现数据加载过程
        return new byte[0]; // 示例数据
    }
}
