using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.States;

public abstract class LevelState(User user)
{
    protected User User = user;
    public abstract void Play();
    public abstract void Defeat();
    public abstract void Win();
}
