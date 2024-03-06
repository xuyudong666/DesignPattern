namespace DesignPattern.Builders;

public abstract class VideoPlayerBuilder
{
    private readonly VideoPlayer _videoPlayer;
    protected VideoPlayerBuilder()
    {
        _videoPlayer = new VideoPlayer();
    }
    public abstract void BuildMenu();
    public abstract void BuildPlaylist();
    public abstract void BuildWindow();
    public abstract void BuildControlStrip();
    public abstract void BuildFavoritesList();

    public VideoPlayer CreateVideoPlayer()
    {
        return _videoPlayer;
    }
}
