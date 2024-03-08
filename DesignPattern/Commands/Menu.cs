namespace DesignPattern.Commands;

public class Menu
{
    private readonly IList<MenuItem> _menuItems;

    public Menu()
    {
        _menuItems = new List<MenuItem>();
    }

    public void AddMenuItem(MenuItem menuItem)
    {
        _menuItems.Add(menuItem);
    }
}
