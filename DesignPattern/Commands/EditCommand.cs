using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Commands;

internal class EditCommand : ICommand
{
    private readonly BoardScreen _boardScreen;

    public EditCommand(BoardScreen boardScreen)
    {
        _boardScreen = boardScreen;
    }
    public void Execute()
    {
        _boardScreen.Edit();
    }
}
