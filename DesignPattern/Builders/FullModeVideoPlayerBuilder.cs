namespace DesignPattern.Builders;

public class FullModeVideoPlayerBuilder : VideoPlayerBuilder
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
        Console.WriteLine("\t菜单");
    }

    public override void BuildPlaylist()
    {
        Console.WriteLine("\t播放列表");
    }

    public override void BuildWindow()
    {
        Console.WriteLine("\t主窗口");
    }
}
