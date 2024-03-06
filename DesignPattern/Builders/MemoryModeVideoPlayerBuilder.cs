namespace DesignPattern.Builders;

public class MemoryModeVideoPlayerBuilder : VideoPlayerBuilder
{
    public override void BuildControlStrip()
    {
        Console.WriteLine("\t控制条");
    }

    public override void BuildFavoritesList()
    {
        Console.WriteLine();
    }

    public override void BuildMenu()
    {
        Console.WriteLine();
    }

    public override void BuildPlaylist()
    {
        Console.WriteLine("\t收藏列表");
    }

    public override void BuildWindow()
    {
        Console.WriteLine("\t主窗口");
    }
}
