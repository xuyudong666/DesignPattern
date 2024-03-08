using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Commands;

public class MenuItem
{
    private readonly ICommand _command;

    public MenuItem(ICommand command)
    {
        _command = command;
    }

    public void Click()
    {
        _command.Execute();
    }
}
