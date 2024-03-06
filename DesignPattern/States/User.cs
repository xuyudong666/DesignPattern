using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.States;

public class User
{
    public User(int score)
    {
        Score = score;
        LevelState = new PrimaryState(this);
    }

    public LevelState LevelState { get; set; }
    public int Score { get; set; }

    public void Play()
    {
        LevelState.Play();
        StateCheck();
    }

    public void Win()
    {
        LevelState.Win();
        StateCheck();
    }

    public void Defeat()
    {
        LevelState.Defeat();
        StateCheck();
    }
    public void StateCheck()
    {
        LevelState = Score switch
        {
            >= 80 => new FinalState(this),
            >= 60 => new ProfessionalState(this),
            >= 40 => new SecondaryState(this),
            >= 20 => new PrimaryState(this),
            _ => new PrimaryState(this),
        };
    }
}
