namespace DesignPattern.Iterators;

public class PagedIterator<T>(IEnumerable<T> source, int pageSize)
{
    private readonly IList<T> _items = new List<T>(source);
    private readonly int _pageSize = pageSize;
    private int _currentPageIndex = 0;

    public IEnumerable<T> NextPage()
    {
        if(HasNextPage())
        {
            int start = _currentPageIndex * _pageSize;
            for (int i = start; i < start + _pageSize && i < _items.Count; i++)
            {
                yield return _items[i];
            }
        }
        ++_currentPageIndex;
    }

    public bool HasNextPage()
    {
        return _currentPageIndex * _pageSize < _items.Count;
    }

    public void Reset()
    {
        _currentPageIndex = 0;
    }
}
