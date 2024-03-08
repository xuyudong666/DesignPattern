using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Commands;

public class OpenCommand : ICommand
{
    private readonly BoardScreen _boardScreen;

    public OpenCommand(BoardScreen boardScreen)
    {
        _boardScreen = boardScreen;
    }
    public void Execute()
    {
        _boardScreen.Open();
    }
}
