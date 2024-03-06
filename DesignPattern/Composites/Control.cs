

namespace DesignPattern.Composites
{
    public abstract class Control
    {
        protected Control(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void Add(Control control);
        public abstract void Remove(Control control);
        public abstract void Display(int depth);
    }
}
