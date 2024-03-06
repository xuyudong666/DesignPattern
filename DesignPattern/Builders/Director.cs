namespace DesignPattern.Builders;

public class Director(VideoPlayerBuilder videoPlayerBuilder)
{
    private readonly VideoPlayerBuilder _videoPlayerBuilder = videoPlayerBuilder;

    public VideoPlayer Construct()
    {
        _videoPlayerBuilder.BuildControlStrip();
        _videoPlayerBuilder.BuildFavoritesList();
        _videoPlayerBuilder.BuildFavoritesList();
        _videoPlayerBuilder.BuildWindow();
        _videoPlayerBuilder.BuildMenu();
        return _videoPlayerBuilder.CreateVideoPlayer();
    }
}
